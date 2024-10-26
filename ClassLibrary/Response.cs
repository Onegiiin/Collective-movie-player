using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayer
{
    public abstract class Response
    {
        public string ResponseType;

        protected Response(string responseType)
        {
            ResponseType = responseType;
        }
    }


    public class RoomsListResponse : Response
    {
        public Dictionary<int, Room> Rooms;
        public RoomsListResponse(Dictionary<int, Room> rooms) : base("roomsList")
        {
            Rooms = rooms;
        }
    }

    public class UpdateRoomResponse : Response
    {
        public Room updatedRoom;
        public int id;
        public UpdateRoomResponse(int id, Room updateRoom) : base("updateRoom")
        {
            this.id = id;
            updatedRoom = updateRoom;
        }
    }

    public class DisconnectFromRoomResponse : Response
    {
        public DisconnectFromRoomResponse() : base("disconnectFromRoom")
        {

        }
    }

    public class JoinRoomResponse : Response
    {
        public bool result;
        public int id;
        public bool isAdmin;
        public JoinRoomResponse(int id, bool result, bool isAdmin = false) : base("joinResult")
        {
            this.id = id;
            this.result = result;
            this.isAdmin = isAdmin;
        }
    }

    public class MoviesListResponse : Response
    {
        public Dictionary<int, Movie> Movies;
        public MoviesListResponse(Dictionary<int, Movie> movies) : base("moviesList")
        {
            Movies = movies;
        }
    }

    public class SetMovieResponse : Response
    {
        public Movie Movie;
        public SetMovieResponse(Movie movie) : base("setMovie")
        {
            Movie = movie;
        }
    }

    public class PauseMovieResponse : Response
    {
        public PauseMovieResponse() : base("pauseMovie")
        {

        }
    }

    public class StopMovieResponse : Response
    {
        public StopMovieResponse() : base("stopMovie")
        {

        }
    }

    public class PlayMovieResponse : Response
    {
        public PlayMovieResponse() : base("playMovie")
        {

        }
    }

    public class SyncronizeResponse : Response
    {
        public SyncronizeResponse() : base("syncronize")
        {

        }
    }

    public class ChangePositionResponse : Response
    {
        public double Position;
        public ChangePositionResponse(double position) : base("changePosition")
        {
            Position = position;

        }
    }

    public class NewMessageResponse : Response
    {
        public Message Msg;
        public NewMessageResponse(Message msg) : base("newMessage")
        {
            Msg = msg;
        }
    }


}
