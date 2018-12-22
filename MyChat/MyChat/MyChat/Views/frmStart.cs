using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MyChat
{
    public partial class frmStart : Form
    {
        #region Khai Báo biến
        /// <summary>
        /// Di chuyển form
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;
        #endregion

        public frmStart()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Drop Shadow cho form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                // Bóng đổ
                cp.ClassStyle |= CS_DROPSHADOW;
                // Load các control cùng lúc
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void frmStart_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void frmStart_MouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            // Client
            Setting.Mode = Setting.Modes.Client;
            // Connect to server 
            Setting.Server = txtServer.Text;
            
            try
            {
                Setting.TcpServer = new TcpClient(Setting.Server, Setting.Port);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Setting.Mode = Setting.Modes.Server;
            // Start server

            this.DialogResult = DialogResult.OK;
        }

        private void frmStart_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
