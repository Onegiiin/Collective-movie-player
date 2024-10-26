using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VideoPlayer;
using ClassLibrary;
using System.Collections;




namespace Server
{
    public static class WebSocketManager
    {
        private static Dictionary<string, WebSocket> _clients = new Dictionary<string, WebSocket>();

        public static void AddClient(string clientId, WebSocket webSocket)
        {
            if (!_clients.ContainsKey(clientId))
            {
                _clients.Add(clientId, webSocket);
            }
        }

        public static WebSocket GetClient(string clientId)
        {
            _clients.TryGetValue(clientId, out WebSocket webSocket);
            return webSocket;
        }

        public static void RemoveClient(string clientId)
        {
            if (_clients.ContainsKey(clientId))
            {
                _clients[clientId].Dispose();
                _clients.Remove(clientId);
            }
        }

        public static IEnumerable<KeyValuePair<string, WebSocket>> GetAllClients()
        {
            return _clients;
        }
    }


    internal class Program
    {
        private static Dictionary<int, Room> rooms = new Dictionary<int, Room>();
        private static Dictionary<string, int> clientRoom = new Dictionary<string, int>();
        private static Dictionary<int, string> passwords = new Dictionary<int, string>();
        static int roomsCreated = 0;
        private static Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
        static string storageDirectory = "C:\\Фильмы";
        static List<string> waitingClients = new List<string>();   
        static async Task Main(string[] args)
        {
            string link = "http://127.0.0.1";
            int port = 8080;

            Console.WriteLine("Запуск сервера. Введите:\n1 - автоматический запуск\n2 - ручной запуск");
            if (Console.ReadLine() != "1")
            {
                Console.Write("Введите ip сервера: ");
                link = Console.ReadLine();
                Console.Write("Введите порт: ");
                int.TryParse(Console.ReadLine(), out port);
                Console.Write("Введите папку с фильмами: ");
                storageDirectory = Console.ReadLine();
            }

            HttpListener listener = new HttpListener();
            try
            {
                listener.Prefixes.Add($"{link}:{port}/");
                listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не удалось запустить сервер.");
                Console.WriteLine(ex.ToString());
                return;
            }
            LoadMovies();
            Console.WriteLine($"Сервер запущен. Ожидание запросов на порту {port}...");

            while (true)
            {
                HttpListenerContext context = await listener.GetContextAsync();
                Console.WriteLine($"Получен запрос от клиента: {context.Request.Url}");
                if (context.Request.IsWebSocketRequest)
                {
                    _ = ProcessWebSocketRequest(context);
                }
                else if (context.Request.Url.AbsolutePath.StartsWith("/movie/"))
                {
                    string movieIdStr = context.Request.Url.AbsolutePath.Substring("/movie/".Length);
                   _ = ProcessVideoRequestAsync(context, movieIdStr);
       
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.Close();
                }
            }

            
        }
        public static void LoadMovies()
        {
            string metadataFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\movies.json");

            if (File.Exists(metadataFilePath))
            {
                string json = File.ReadAllText(metadataFilePath);
                var loadedMovies = JsonConvert.DeserializeObject<Dictionary<int, Movie>>(json);
                if (loadedMovies != null)
                {
                    movies = loadedMovies;
                }
            }
        }

        static async Task ProcessVideoRequestAsync(HttpListenerContext context, string movieId)
        {
            try
            {

                var request = context.Request;
                var response = context.Response;
                int id = int.Parse(movieId);
                string videoFilePath = $"{storageDirectory}\\{movies[id].Title}.{movies[id].FileExtension}";
                if (File.Exists(videoFilePath))
                {
                    long fileSize = new FileInfo(videoFilePath).Length;

                    response.StatusCode = (int)HttpStatusCode.OK;

                    long startPos = 0;
                    long endPos = fileSize - 1;

                    string rangeHeader = request.Headers["Range"];
                    if (!string.IsNullOrEmpty(rangeHeader))
                    {
                        response.StatusCode = (int)HttpStatusCode.PartialContent;
                        string[] rangeValues = rangeHeader.Replace("bytes=", "").Split('-');
                        startPos = long.Parse(rangeValues[0]);
                        if (rangeValues.Length > 1 && !string.IsNullOrEmpty(rangeValues[1]))
                        {
                            endPos = long.Parse(rangeValues[1]);
                        }
                    }

                    response.Headers.Add("Content-Type", "video/mp4");
                    response.Headers.Add("Accept-Ranges", "bytes");
                    response.Headers.Add("Content-Range", $"bytes {startPos}-{endPos}/{fileSize}");

                    using (var videoStream = File.OpenRead(videoFilePath))
                    {

                        videoStream.Seek(startPos, SeekOrigin.Begin);

                        long contentLength = endPos - startPos + 1;

                        byte[] buffer = new byte[1024 * 1024];

                        int bytesRead;
                        long bytesRemaining = contentLength;

                        while (bytesRemaining > 0 && (bytesRead = videoStream.Read(buffer, 0, (int)Math.Min(buffer.Length, bytesRemaining))) > 0)
                        {
                            await response.OutputStream.WriteAsync(buffer, 0, bytesRead);
                            bytesRemaining -= bytesRead;
                        }
                    }

                    response.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке запроса: {ex.Message}");
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.Close();
            }
        }
        private static async Task ProcessWebSocketRequest(HttpListenerContext context)
        {
            var webSocketContext = await context.AcceptWebSocketAsync(null);
            var webSocket = webSocketContext.WebSocket;
            string clientId = Guid.NewGuid().ToString();
            WebSocketManager.AddClient(clientId, webSocket);

            Console.WriteLine("Установлено соединение с клиентом: " + clientId);
        
            try
            {
                while (webSocket.State == WebSocketState.Open)
                {
                    var buffer = new byte[1024];
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                        WebSocketManager.RemoveClient(clientId);
                        if (clientRoom.ContainsKey(clientId)) 
                            DisconnectUserFromRoom(clientId);
                        Console.WriteLine("Соединение с клиентом " + clientId + " разорвано");
                    }
                    else if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        Console.WriteLine("Получено сообщение от клиента " + clientId + ": " + message);

                        // Deserialize JSON message to Request object
                        var request = JsonConvert.DeserializeObject<Request>(message);

                        // Handle the request based on its type
                        switch (request.RequestType)
                        {
                            case "createRoom":                            
                                CreateRoom(JsonConvert.DeserializeObject<CreateRoomRequest>(message), clientId);
                                await SendMessage(webSocket, JsonConvert.SerializeObject(new MoviesListResponse(movies)));
                                break;
                            case "getRooms":
                                await SendMessage(webSocket, JsonConvert.SerializeObject(new RoomsListResponse(rooms)));
                                break;
                            case "joinRoom":
                                JoinRoom(JsonConvert.DeserializeObject<JoinRoomRequest>(message), clientId);
                                break;   
                            case "disconnectFromRoom":
                                if (DisconnectUserFromRoom(clientId));
                                    await SendMessage(webSocket, JsonConvert.SerializeObject(new DisconnectFromRoomResponse()));
                                break;
                            case "kickMember":
                                string id = JsonConvert.DeserializeObject<KickMemberRequest>(message).id;
                                if (clientId == rooms[clientRoom[id]].adminid && DisconnectUserFromRoom(id))
                                    await SendMessage(WebSocketManager.GetClient(id), JsonConvert.SerializeObject(new DisconnectFromRoomResponse()));
                                break;
                            case "changePassword":
                                if (clientId == rooms[clientRoom[clientId]].adminid)
                                    ChangePassword(clientRoom[clientId], JsonConvert.DeserializeObject<ChangePasswordRequest>(message).password);
                                break;
                            case "setMovie":
                                SetMovieInRoom(clientRoom[clientId], JsonConvert.DeserializeObject<SetMovieRequest>(message).id);
                                break;
                            case "pauseMovie":
                                if (clientRoom.ContainsKey(clientId))
                                {
                                    Room currRoom = rooms[clientRoom[clientId]];
                                    SendToMembers(currRoom.members.Keys.Where(i => i != clientId), JsonConvert.SerializeObject(new PauseMovieResponse()));
                                    SendSystemMessage(currRoom.members.Keys, $"{currRoom.members[clientId]} поставил фильм на паузу");
                                }
                                break;
                            case "stopMovie":
                                if (clientRoom.ContainsKey(clientId))
                                {
                                    Room currRoom = rooms[clientRoom[clientId]];
                                    SendToMembers(currRoom.members.Keys.Where(i => i != clientId), JsonConvert.SerializeObject(new StopMovieResponse()));
                                    SendSystemMessage(currRoom.members.Keys, $"{currRoom.members[clientId]} остановил просмотр фильма");
                                }
                                break;
                            case "playMovie":
                                if (clientRoom.ContainsKey(clientId))
                                {
                                    Room currRoom = rooms[clientRoom[clientId]];
                                    SendToMembers(currRoom.members.Keys.Where(i => i != clientId), JsonConvert.SerializeObject(new PlayMovieResponse()));
                                    SendSystemMessage(currRoom.members.Keys, $"{currRoom.members[clientId]} продолжил просмотр фильма");
                                }
                                break;
                            case "changePosition":
                                var positionRequest = JsonConvert.DeserializeObject<ChangePositionRequest>(message);
                                SendToMembers(rooms[clientRoom[clientId]].members.Keys.Where(i => i != clientId), JsonConvert.SerializeObject(new ChangePositionResponse(positionRequest.position)));
                                SendSystemMessage(rooms[clientRoom[clientId]].members.Keys, $"{rooms[clientRoom[clientId]].members[clientId]} перемотал фильм");

                                break;
                            case "currentRoomState":
                                SendToMembers(waitingClients, JsonConvert.SerializeObject(new ChangePositionResponse(JsonConvert.DeserializeObject<CurrentRoomStateRequest>(message).position)));
                                int state = JsonConvert.DeserializeObject<CurrentRoomStateRequest>(message).state;
                                if (state == 2)
                                    SendToMembers(waitingClients, JsonConvert.SerializeObject(new PauseMovieResponse()));
                                else if (state == 3)
                                    SendToMembers(waitingClients, JsonConvert.SerializeObject(new PlayMovieResponse()));
                                else if (state == 1)
                                    SendToMembers(waitingClients, JsonConvert.SerializeObject(new StopMovieResponse()));

                                waitingClients.Clear();
                                break;                 
                            case "syncronize":
                                Room room = rooms[clientRoom[clientId]];
                                if (clientId != room.adminid && room.movie != null)
                                {
                                    waitingClients.Add(clientId);
                                    _ = SendMessage(WebSocketManager.GetClient(room.adminid), JsonConvert.SerializeObject(new SyncronizeResponse()));
                                }    
                                break;
                            case "movieControlState":
                                if (clientRoom.ContainsKey(clientId))
                                {
                                    room = rooms[clientRoom[clientId]];
                                    if (clientId == room.adminid)
                                    {
                                        MovieControlStateRequest tmpRequest = JsonConvert.DeserializeObject<MovieControlStateRequest>(message);
                                        room.adminControl = tmpRequest.state;
                                        SendToMembers(room.members.Keys, JsonConvert.SerializeObject(new UpdateRoomResponse(clientRoom[clientId], room)));
                                        SendSystemMessage(room.members.Keys, $"Администратор {(tmpRequest.state ? "запретил" : "разрешил")} участникам управлять просмотром");
                                    }
                                }

                                break;
                            case "sendMessage":
                                room = rooms[clientRoom[clientId]];
                                var msg = JsonConvert.DeserializeObject<SendMessageRequest>(message).message;
                                msg.sender = room.members[clientId];
                                SendToMembers(room.members.Keys, JsonConvert.SerializeObject(new NewMessageResponse(msg)));   
                                break;   
                            default:
                                Console.WriteLine("Неизвестный тип запроса: " + request.RequestType);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                WebSocketManager.RemoveClient(clientId);
            }
        }

        public static void SendSystemMessage(IEnumerable<string> clients, string message)
        {
            SendToMembers(clients, JsonConvert.SerializeObject(new NewMessageResponse(new Message(message, "system"))));
        }

        public static void SendToMembers(IEnumerable<string> clients, string message)
        {
            foreach (string client in clients)
            {
                _ = SendMessage(WebSocketManager.GetClient(client), message);
            }
        }
        public static void SetMovieInRoom(int roomId, int movieId)
        {
            Room room = rooms[roomId];  
            room.movie = movies[movieId];
            SendToMembers(room.members.Keys, JsonConvert.SerializeObject(new SetMovieResponse(room.movie)));

            _ = SendUpdatedRoom(roomId, room);
            SendSystemMessage(room.members.Keys, $"Администратор установил фильм {movies[movieId].Title}");
        }

        public static void ChangePassword(int id, string password)
        {
            if (rooms.ContainsKey(id))
            {
                passwords[id] = password;
                Room room = rooms[id];
                if (!room.passwordUsing)
                {
                    room.passwordUsing = true;
                    _ = SendUpdatedRoom(id, room);
                }
                SendSystemMessage(room.members.Keys, $"Администратор сменил пароль комнаты");

            }
        }
        public static void JoinRoom(JoinRoomRequest request, string clientId)
        {
            bool result = false;
            int key = request.roomId;
            if (rooms.TryGetValue(key, out var room))
            {

                result = !room.passwordUsing || PasswordHasher.VerifyHashedPassword(passwords[key], request.password);
                if (result)
                {
                    room.AddMember(clientId, request.nick);
                    clientRoom.Add(clientId, key);
                    SendSystemMessage(room.members.Keys, $"Пользователь {request.nick} подключился к комнате");
                    _ = SendUpdatedRoom(key, room);
                }
            }
         
            _ = SendMessage(WebSocketManager.GetClient(clientId), JsonConvert.SerializeObject(new JoinRoomResponse(key, result, clientId == room.adminid)));
            if (result && room.movie != null)
            {
              
                _ = SendMessage(WebSocketManager.GetClient(clientId), JsonConvert.SerializeObject(new SetMovieResponse(room.movie)));            
            }
        }

        public static void CreateRoom(CreateRoomRequest request, string clientId)
        {
            int roomId = roomsCreated++;
            string password = request.password;
            bool passwordUsing = false;
            if (password != null)
            {
                passwords.Add(roomId, password);
                passwordUsing = true;
            }
            Room newRoom = new Room(clientId, request.title, passwordUsing);
            newRoom.AddMember(clientId, request.nick);
            rooms.Add(roomId, newRoom);         
            clientRoom.Add(clientId, roomId);
            _ = SendNewRooms();
            _ = SendMessage(WebSocketManager.GetClient(clientId), JsonConvert.SerializeObject(new JoinRoomResponse(roomId, true, true)));
            SendSystemMessage(newRoom.members.Keys, $"Администратор {request.nick} создал комнату {request.title}");
        }

        public static bool DisconnectUserFromRoom(string clientId) 
        {
            if (clientRoom.TryGetValue(clientId, out var roomId))
            {
                Room room = rooms[roomId];
                if (room.adminid == clientId)
                {
                    rooms.Remove(roomId);
                    _ = SendNewRooms();
                    foreach (string roomClientId in room.members.Keys)
                    {
                        SendMessage(WebSocketManager.GetClient(roomClientId), JsonConvert.SerializeObject(new DisconnectFromRoomResponse()));
                        clientRoom.Remove(roomClientId);
                    }
                } else
                {
                    string nick = room.members[clientId];
                    room.members.Remove(clientId);
                    _ = SendUpdatedRoom(roomId, rooms[roomId]);
                    clientRoom.Remove(clientId);
                    SendSystemMessage(room.members.Keys, $"Пользователь {nick} отключился");
                }
                
                return true;
            }
            return false;
        }
        public static async Task SendNewRooms()
        {
            RoomsListResponse response = new RoomsListResponse(rooms);
            await SendMessageToAll(JsonConvert.SerializeObject(response));
        }

        public static async Task SendUpdatedRoom(int id, Room newRoom)
        {
            UpdateRoomResponse response = new UpdateRoomResponse(id, newRoom);
            await SendMessageToAll(JsonConvert.SerializeObject(response));
        }

        private static async Task SendMessageToAll(string message)
        {
            var buffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in WebSocketManager.GetAllClients())
            {
                await client.Value.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }

        private static async Task SendMessage(WebSocket webSocket, string message)
        {
            var buffer = Encoding.UTF8.GetBytes(message);
            await webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
}
