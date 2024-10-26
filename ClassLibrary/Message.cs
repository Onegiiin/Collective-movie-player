using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Message
    {
        public string text;
        public string sender;
        public string type;

        public Message(string text, string type, string sender = null)
        {
            this.text = text;
            this.sender = sender;
            this.type = type;
        }
    }
}
