using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayer
{
    public class Request
    {
        public string RequestType;
        

        public Request(string RequestType)
        {
            this.RequestType = RequestType; 
        }
    }

    public class CreateRoomRequest : Request
    {
        public string title;
        public string nick;
        public string password;


        public CreateRoomRequest(string title, string nick, string password) : base("createRoom")
        {
            this.title = title;
            this.password = password;
            this.nick = nick;
        }
    }
    public class DisconnectFromRoomRequest : Request
    {
        public DisconnectFromRoomRequest() : base("disconnectFromRoom")
        {

        }
    }

    public class JoinRoomRequest : Request
    {
        public int roomId;
        public string nick;
        public string password;


        public JoinRoomRequest(int roomId, string nick, string password = null) : base("joinRoom")
        {
            this.roomId = roomId;
            this.nick = nick;   
            this.password = password;
        }
    }

    public class KickMemberRequest : Request
    {
        public string id;
        public KickMemberRequest(string id) : base("kickMember")
        {
            this.id = id;
        }
    }

    public class ChangePasswordRequest : Request
    {
        public string password;
        public ChangePasswordRequest(string password) : base("changePassword")
        {
            this.password = password;
        }
    }

    public class GetMoviesRequest : Request
    {
        public GetMoviesRequest() : base("getMovies")
        {

        }
    }
    public class SetMovieRequest : Request
    {
        public int id;
        public SetMovieRequest(int id ) : base("setMovie")
        {
            this.id = id;
        }
    }

    public class PauseMovieRequest : Request
    {
        public PauseMovieRequest() : base("pauseMovie")
        {

        }
    }

    public class StopMovieRequest : Request
    {
        public StopMovieRequest() : base("stopMovie")
        {

        }
    }

    public class PlayMovieRequest : Request
    {
        public PlayMovieRequest() : base("playMovie")
        {

        }
    }

    public class ChangePositionRequest : Request
    {
        public double position;
        public string time;
        public ChangePositionRequest(double position, string time) : base("changePosition")
        {
            this.position = position;
            this.time = time;   
        }
    }

    public class CurrentRoomStateRequest : Request
    {
        public double position;
        public int state;
        public CurrentRoomStateRequest(double position, int state) : base("currentRoomState")
        {
            this.position = position;
            this.state = state;
        }
    }

    public class SyncronizeRequest : Request
    {

        public SyncronizeRequest() : base("syncronize")
        {
        }
    }

    public class MovieControlStateRequest : Request
    {
        public bool state;
        public MovieControlStateRequest(bool state) : base("movieControlState")
        {
            this.state = state;
        }
    }

    public class SendMessageRequest : Request
    {
        public Message message;
        public SendMessageRequest(Message msg) : base("sendMessage")
        {
            this.message = msg;   
        }
    }


}
