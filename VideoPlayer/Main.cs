using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using ClassLibrary;
using AxWMPLib;
using WMPLib;
using System.IO;

namespace VideoPlayer
{
    public partial class FormMain : MaterialForm
    {
        static Dictionary<int, Room> rooms;
        static Dictionary<int, Movie> movies;
        static string serverAddress = "ws://127.0.0.1:8080";
        static string videoServerLink = "http://127.0.0.1:8080/movie";
        static ClientWebSocket client;
        static Room connectedRoom = null;
        static int connectedRoomId;
        static Movie currentMovie;
        bool serverControl = false;
        bool serverChange = false;
        bool isAdmin = false;

        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            InitializeGraphics();
            _ = InitializeClient();

        }

        void InitializeGraphics()
        {
            labelCinemaRooms.FontType = MaterialSkinManager.fontType.H3;

            labelCinemaRooms.Location = new Point((panelTop.Width - labelCinemaRooms.Width) / 2, (panelTop.Height - labelCinemaRooms.Height) / 2);
            btnCreateRoom.Location = new Point((panelBottom.Width - btnCreateRoom.Width) / 2, (panelBottom.Height - btnCreateRoom.Height) / 2);

        }

        void DisplayRooms(Dictionary<int, Room> rooms)
        {
            tableLayoutPanel.AutoScroll = false;

            tableLayoutPanel.HorizontalScroll.Maximum = 0;
            tableLayoutPanel.HorizontalScroll.Visible = false;
            tableLayoutPanel.HorizontalScroll.Enabled = false;

            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnStyles.Clear();

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            int rowIndex = 0;
            int colIndex = 0;

            foreach (KeyValuePair<int, Room> kvp in rooms)
            {
                Room room = kvp.Value;
                CardControl cardControl = new CardControl(room.title, room.members.Count.ToString(), room.movie?.Title, room.passwordUsing, kvp.Key);
                cardControl.Dock = DockStyle.Fill;

                cardControl.ButtonClicked += CardController_ButtonClicked;

                if (colIndex == 0)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 330));
                }
                tableLayoutPanel.Controls.Add(cardControl, colIndex, rowIndex);

                colIndex++;
                if (colIndex >= 2)
                {
                    colIndex = 0;
                    rowIndex++;
                }
            }
            while (rowIndex < 2)
            {
                if (colIndex == 0)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 330));
                }

                MaterialLabel emptyLabel = new MaterialLabel
                {
                    Text = "Пусто :(",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel.Controls.Add(emptyLabel, colIndex, rowIndex);

                colIndex++;
                if (colIndex >= 2)
                {
                    colIndex = 0;
                    rowIndex++;
                }
            }

            tableLayoutPanel.AutoScroll = true;
        }

        void DrawRoomInterface()
        {
            panelChoose.Visible = false;
            panelRoom.Visible = true;
            Text = connectedRoom.title;
            btnSettings.Visible = isAdmin;
            btnOut.Text = isAdmin ? "Распустить комнату" : "Выйти";
            splitter2.Visible = isAdmin;
            panelSettings.Visible = false;

        }

        void DrawChooseRoomInterface()
        {
            panelRoom.Visible = false;
            panelChoose.Visible = true;
            cbControlState.Checked = false;
            tBoxInput.Clear();
            tBoxChat.Clear();
            Text = "Совместный просмотр фильмов";

        }
        public void UpdatePlayer()
        {
            WMP.URL = videoServerLink + $"/{currentMovie.Id}";
        }



        public void UpdateRoom(int id, Room newRoom)
        {
            rooms[id] = newRoom;
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is CardControl cardControl && cardControl.roomId == id)
                {
                    CardControl card = control as CardControl;
                    card.UpdateView(newRoom.title, newRoom.members.Count.ToString(), newRoom.movie?.Title, newRoom.passwordUsing);
                    break;
                }
            }
        }


        static void JoinRoom(int roomId)
        {
            Room room = rooms[roomId];
            using (JoinRoomDialog inputDialog = new JoinRoomDialog(room.passwordUsing))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    if (room.passwordUsing)
                    {
                        _ = SendMessage(JsonConvert.SerializeObject(new JoinRoomRequest(roomId, inputDialog.nick, inputDialog.password)));
                    }
                    else
                    {
                        _ = SendMessage(JsonConvert.SerializeObject(new JoinRoomRequest(roomId, inputDialog.nick)));
                    }
                }
            }
        }

        public void LeaveRoom()
        {
            connectedRoom = null;
            connectedRoomId = -1;
            if (WMP.URL != null)
            {
                WMP.Ctlcontrols.stop();
                WMP.URL = null;
            }
        }

        static void DisconnectFromRoom()
        {
            _ = SendMessage(JsonConvert.SerializeObject(new DisconnectFromRoomRequest()));
        }

        static void KickMember(string id)
        {
            _ = SendMessage(JsonConvert.SerializeObject(new KickMemberRequest(id)));
        }
        static void SetMovie(int id)
        {
            _ = SendMessage(JsonConvert.SerializeObject(new SetMovieRequest(id)));
        }

        static void ChangePassword(string password)
        {
            _ = SendMessage(JsonConvert.SerializeObject(new ChangePasswordRequest(PasswordHasher.HashPassword(password))));
        }

        static void SendCreateRoomRequest(string title, string name, string password, bool passwordUsing)
        {
            var request = new CreateRoomRequest(title, name, passwordUsing ? PasswordHasher.HashPassword(password) : null);
            _ = SendMessage(JsonConvert.SerializeObject(request));
        }

        static void SendPauseRequest()
        {
            _ = SendMessage(JsonConvert.SerializeObject(new PauseMovieRequest()));
        }

        static void SendStopRequest()
        {
            _ = SendMessage(JsonConvert.SerializeObject(new StopMovieRequest()));
        }

        static void SendPlayRequest()
        {
            _ = SendMessage(JsonConvert.SerializeObject(new PlayMovieRequest()));
        }

        static void SendChangePositionRequest(double pos, string time)
        {
            _ = SendMessage(JsonConvert.SerializeObject(new ChangePositionRequest(pos, time)));
        }

        static void SendMovieControlState(bool state)
        {
            _ = SendMessage(JsonConvert.SerializeObject(new MovieControlStateRequest(state)));
        }

        public void SendChatMessage()
        {
            if (!isAdmin && tBoxInput.Text == "/sync")
                _ = SendMessage(JsonConvert.SerializeObject(new SyncronizeRequest()));

            else if (tBoxInput.Text.Length > 0)
            {
                _ = SendMessage(JsonConvert.SerializeObject(new SendMessageRequest(new ClassLibrary.Message(tBoxInput.Text, "client"))));
            }
            tBoxInput.Clear();
        }
        public void SendEmoji(string emoji)
        {
            _ = SendMessage(JsonConvert.SerializeObject(new SendMessageRequest(new ClassLibrary.Message(emoji, "emoji"))));
        }

        async Task ReceiveRequest()
        {
            var buffer = new byte[1024];
            while (client.State == WebSocketState.Open)
            {
                var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                var receivedMessage = Encoding.UTF8.GetString(buffer, 0, result.Count);
                // Десериализация JSON в объект класса Request
                dynamic response = JsonConvert.DeserializeObject(receivedMessage);
                if (response != null)
                {
                    string responseType = response.ResponseType;

                    // Обработка запроса в зависимости от типа
                    switch (responseType)
                    {
                        case "roomsList":
                            rooms = JsonConvert.DeserializeObject<RoomsListResponse>(receivedMessage).Rooms;
                            DisplayRooms(rooms);
                            break;
                        case "joinResult":
                            response = JsonConvert.DeserializeObject<JoinRoomResponse>(receivedMessage);
                            if (!response.result)
                            {
                                MessageBox.Show("Неправильный пароль", "Не удалось войти в комнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                connectedRoomId = response.id;
                                connectedRoom = rooms[connectedRoomId];
                                isAdmin = response.isAdmin;
                                DrawRoomInterface();
                            }
                            break;
                        case "updateRoom":
                            response = JsonConvert.DeserializeObject<UpdateRoomResponse>(receivedMessage);
                            if (response.id == connectedRoomId)
                            {
                                connectedRoom = response.updatedRoom;
                            }
                            UpdateRoom(response.id, response.updatedRoom);
                            break;
                        case "disconnectFromRoom":
                            LeaveRoom();
                            DrawChooseRoomInterface();
                            break;
                        case "moviesList":
                            movies = JsonConvert.DeserializeObject<MoviesListResponse>(receivedMessage).Movies;
                            break;
                        case "setMovie":
                            currentMovie = JsonConvert.DeserializeObject<SetMovieResponse>(receivedMessage).Movie;
                            UpdatePlayer();
                            isFirstLoad = true;

                            break;
                        case "pauseMovie":
                            if (WMP.playState != WMPPlayState.wmppsPaused)
                            {
                                serverControl = true;
                                WMP.Ctlcontrols.pause();
                                serverControl = false;
                            }
                            break;
                        case "stopMovie":
                            if (WMP.playState != WMPPlayState.wmppsStopped)
                            {
                                serverControl = true;
                                WMP.Ctlcontrols.stop();
                                serverControl = false;
                            }
                            break;
                        case "playMovie":
                            if (WMP.playState != WMPPlayState.wmppsPlaying)
                            {
                                serverControl = true;
                                WMP.Ctlcontrols.play();
                                serverControl = false;
                            }
                            break;
                        case "changePosition":
                            serverChange = true;
                            WMP.Ctlcontrols.currentPosition = JsonConvert.DeserializeObject<ChangePositionResponse>(receivedMessage).Position;
                            break;
                        case "syncronize":
                            _ = SendMessage(JsonConvert.SerializeObject(new CurrentRoomStateRequest(WMP.Ctlcontrols.currentPosition, (int)WMP.playState)));
                            break;
                        case "newMessage":
                            ClassLibrary.Message message = JsonConvert.DeserializeObject<NewMessageResponse>(receivedMessage).Msg;
                            switch (message.type)
                            {
                                case "client":
                                    AddUserMessage(message.sender, message.text);
                                    break;
                                case "emoji":
                                    AddEmojiMessage(message.sender, message.text);
                                    break;
                                case "system":
                                    AddSystemMessage(message.text);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void ShowErrorAndCloseForm(string errorMessage)
        {

                        MessageBox.Show(errorMessage, "Сервер не доступен, проверьте адрес в файле server.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
        }

        async Task InitializeClient()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\server.txt");

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath).Trim();
                serverAddress = "ws://" + fileContent;
                videoServerLink = "http://" + fileContent + "/movie";
            }

            client = new ClientWebSocket();
            try
            {
                await client.ConnectAsync(new Uri(serverAddress), CancellationToken.None);
                if (client.State == WebSocketState.Open)
                {
                    _ = ReceiveRequest();
                }
                await SendMessage(JsonConvert.SerializeObject(new Request("getRooms")));
            }
            catch (WebSocketException ex)
            {
                ShowErrorAndCloseForm($"WebSocket error: {ex.Message}");
            }
            catch (Exception ex)
            {
                ShowErrorAndCloseForm($"General error: {ex.Message}");
            }
        }

        static async Task SendMessage(string message)
        {

            var buffer = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            using (InputRoomDialog inputDialog = new InputRoomDialog())
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    SendCreateRoomRequest(inputDialog.title, inputDialog.userName, inputDialog.password, inputDialog.passwordUsing);
                }
            }
        }

        private void CardController_ButtonClicked(object sender, EventArgs e)
        {
            CardControl cardController = sender as CardControl;
            if (cardController != null)
            {
                JoinRoom(cardController.roomId);
            }
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.State == WebSocketState.Open)
            {
                client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing connection", CancellationToken.None);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DisconnectFromRoom();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = !panelSettings.Visible;

        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            using (SettingsDialog inputDialog = new SettingsDialog(connectedRoom.members))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {

                    KickMember(inputDialog.id);
                }
            }
        }

        private void btnChooseFilm_Click(object sender, EventArgs e)
        {
            using (SettingsDialog inputDialog = new SettingsDialog(movies))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    SetMovie(int.Parse(inputDialog.id));
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (SettingsDialog inputDialog = new SettingsDialog())
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    ChangePassword(inputDialog.newPassword);
                }
            }
        }

        int prevState = -1;
        bool isFirstLoad = false;
        private void WMP_PlayStateChange_1(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {


            if (!serverControl)
            {

                switch (e.newState)
                {
                    case (int)WMPPlayState.wmppsPaused:

                        if (!(connectedRoom.adminControl && !isAdmin))
                            SendPauseRequest();
                        else
                            AddSystemMessage("Администратор запретил управление просмтром. Для синхронизации отправьте команду /sync");
                        break;
                    case (int)WMPPlayState.wmppsStopped:
                        if (!(connectedRoom.adminControl && !isAdmin))
                            SendStopRequest();
                        else
                            AddSystemMessage("Администратор запретил управление просмтром. Для синхронизации отправьте команду /sync");
                        break;
                    case (int)WMPPlayState.wmppsPlaying:
                        if (prevState != 6)
                        {
                            if (isFirstLoad)
                            {
                                _ = SendMessage(JsonConvert.SerializeObject(new SyncronizeRequest()));
                                isFirstLoad = false;
                            }
                            else if (!(connectedRoom.adminControl && !isAdmin))
                            {
                                SendPlayRequest();
                            }
                            else
                                AddSystemMessage("Администратор запретил управление просмтром. Для синхронизации отправьте команду /sync");
                        }
                        break;
                    default:
                        break;
                }
            }
            prevState = e.newState;
        }

        private void WMP_PositionChange(object sender, _WMPOCXEvents_PositionChangeEvent e)
        {
            if (!serverChange)
            {
                double newPosition = e.newPosition;
                string duration = WMP.currentMedia.durationString;
                if (!(connectedRoom.adminControl && !isAdmin))
                    SendChangePositionRequest(newPosition, duration);
                else
                    AddSystemMessage("Администратор запретил управление просмтром. Для синхронизации отправьте команду /sync");
            }
            serverChange = false;
        }

        private void cbControlState_CheckedChanged(object sender, EventArgs e)
        {
            SendMovieControlState(cbControlState.Checked);
        }

        public void AddSystemMessage(string message)
        {
            AppendText(tBoxChat, message + Environment.NewLine, Color.LightGray, 12);
        }
        public void AddEmojiMessage(string username, string message)
        {
            AppendText(tBoxChat, $"{username}: ", Color.LightGray, 12);
            AppendText(tBoxChat, message + Environment.NewLine, Color.WhiteSmoke, 32);
        }

        public void AddUserMessage(string username, string message)
        {
            AppendText(tBoxChat, $"{username}: ", Color.LightGray, 12);
            AppendText(tBoxChat, message + Environment.NewLine, Color.WhiteSmoke, 12);
        }

        private void AppendText(RichTextBox box, string text, Color color, float fontSize)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.SelectionFont = new Font(box.Font.FontFamily, fontSize, FontStyle.Regular);
            box.AppendText(text);
            box.ScrollToCaret();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendChatMessage();
        }

        private void emojiLaugh_DoubleClick(object sender, EventArgs e)
        {
            SendEmoji("🤣");
        }

        private void emojiCry_DoubleClick(object sender, EventArgs e)
        {
            SendEmoji("😭");
        }

        private void emojiSurprise_DoubleClick(object sender, EventArgs e)
        {
            SendEmoji("😲");
        }

        private void tBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendChatMessage();
            }
        }

        private void tBoxChat_SizeChanged(object sender, EventArgs e)
        {
            tBoxChat.ScrollToCaret();
        }
    }
}

