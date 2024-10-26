using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Room
    {
        public string adminid;
        public string title;
        public Movie movie;
        public bool passwordUsing;
        public string time;
        public Dictionary<string, string> members;
        public bool adminControl = false;

        public Room(string adminid, string title, bool passwordUsing)
        {
            this.adminid = adminid;
            this.title = title;
            this.passwordUsing = passwordUsing;
            this.members = new Dictionary<string, string>();
        }

        public void AddMember(string id, string username)
        {
            members.Add(id, username);
        }
    }
}
