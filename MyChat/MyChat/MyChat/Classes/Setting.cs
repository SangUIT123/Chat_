using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace MyChat
{
    static class Setting
    {
        public enum Modes { Client, Server }
        /// <summary>
        /// Chế độ đang chạy Client / Server
        /// </summary>
        public static Modes Mode { get; set; }
        /// <summary>
        /// Cài đặt cổng mặc định
        /// </summary>
        public static int Port { get; set; }
        /// <summary>
        /// Địa chỉ Server, dùng khi chế độ là client
        /// </summary>
        public static string Server { get; set; }
        /// <summary>
        /// Tcp client của server
        /// </summary>
        public static TcpClient TcpServer { get; set; }
        /// <summary>
        /// Chuỗi bắt đầu khi muốn gửi 1 file
        /// </summary>
        public static string MarkSendFile { get; set; }
    }
}
