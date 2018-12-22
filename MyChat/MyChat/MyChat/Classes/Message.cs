using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChat
{
    class Message
    {
        public Sender Sender { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}
