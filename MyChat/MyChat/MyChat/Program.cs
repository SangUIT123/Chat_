using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// Ngày tạo 28/03/2016
        /// Sửa cuối cùng 31/03/2016
        /// Có các tính năng:
        /// - Hiển thị web trong form
        /// - Truyền tin qua socket, hình ảnh
        /// - Nhiều client, thread
        /// - Nháy icon taskbar & hiển thị số tin nhắn
        /// - List Button
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Setting.Port = 2910;
            Setting.MarkSendFile = "@#$fileNVN##$#@";

            frmStart frm = new frmStart();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Setting.Mode == Setting.Modes.Client)
                    Application.Run(new frmClient());
                else
                    Application.Run(new frmServer());
            }
            else
                Application.Exit();
        }
    }
}
