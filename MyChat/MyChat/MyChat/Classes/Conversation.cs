using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MyChat
{
    class Conversation
    {
        public List<Message> Messages { get; set; }
        public List<Sender> Senders { get; set; }


        public Conversation()
        {
            Messages = new List<Message>();
            Senders = new List<Sender>();
        }

        public void AddMessage(Message mes)
        {
            Messages.Add(mes);
            if (!Senders.Contains(mes.Sender))
                Senders.Add(mes.Sender);
        }

        public Sender AddClient(TcpClient client)
        {
            IPEndPoint ipep = (IPEndPoint)client.Client.RemoteEndPoint;
            Sender sender = new Sender();
            sender.Address = ipep.Address.ToString();
            sender.Port = ipep.Port;
            sender.Tcp = client;
            if (!Senders.Contains(sender))
                Senders.Add(sender);

            return sender;
        }

        public void RemoveClient(TcpClient client)
        {
            var sender = Senders.Where(p => p.Tcp != null && p.Tcp.Equals(client)).FirstOrDefault();
            if (sender != null)
            {
                sender.Tcp.Close();
                Senders.Remove(sender);
            }
        }

        public Sender GetSender(TcpClient client)
        {
            var sender = Senders.Where(p => p.Tcp != null && p.Tcp.Equals(client)).FirstOrDefault();
            return sender;
        }

        public string GetHTML
        {
            get
            {
                string start = @"<!DOCTYPE html><html><head><title>Client</title><style type='text/css'>
	                         body{font-family:  'Segoe UI', tahoma, sans-serif;}
	                        .message{padding: 6px;margin: 4px;text-align: left;cursor:default;word-wrap:break-word;}
	                        .mine{margin-left: 100px;background: DarkOrange;}
	                        .remote{margin-right: 100px;background: #999;}
                            </style>
                            <script language='javascript'>
                                window.onload=toBottom;
                                function toBottom(){ window.scrollTo(0, document.body.scrollHeight);}
                            </script></head><body>";
                if (Setting.Mode == Setting.Modes.Server)
                    start = start.Replace("DarkOrange", "ForestGreen");
                string end = @"</body></html>";
                string conver = "";
                foreach (var mes in Messages)
                {
                    if (mes.Sender.Equals(Sender.Me))
                        conver += "<div class='message mine' title='" + mes.Sender.Address + ":" + mes.Sender.Port + " " + mes.Time.ToString("HH:mm:ss dd/MM/yy") + "'>" + mes.Content + "</div>\n";
                    else
                    {
                        conver += "<div class='message remote' title='" + mes.Sender.Address + ":" + mes.Sender.Port + " " + " " + mes.Time.ToString("HH:mm:ss dd/MM/yy") + "'";
                        if (mes.Sender.Color.Name != "0")
                            conver += " style='background:" + GetHTMLColor(mes.Sender.Color) + "'";
                        conver += ">" + (Senders.Count > 2 ? "<b>" + mes.Sender.NickName + "</b>: " : "") + mes.Content + "</div>";
                    }
                }
                return start + conver + end;
            }
        }

        private string GetHTMLColor(Color col)
        {
            return ColorTranslator.ToHtml(col);
        }
    }
}
