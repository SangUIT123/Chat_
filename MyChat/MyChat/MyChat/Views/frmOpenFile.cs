using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyChat
{
    public partial class frmOpenFile : Form
    {
        /// <summary>
        /// Di chuyển form
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;

        string Address = "";
        Uri url;

        public frmOpenFile(string address)
        {
            InitializeComponent();
            Address = address.Replace("(~*)", ":");
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

        private void frmRename_Load(object sender, EventArgs e)
        {
            url = new UriBuilder() { Scheme = Uri.UriSchemeFile, Host = "", Path = Address }.Uri;
            lblName.Text = Path.GetFileName(url.LocalPath);
            Address = url.LocalPath;
        }

        private void frmRename_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void frmRename_MouseMove(object sender, MouseEventArgs e)
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

        private void btnExplore_Click(object sender, EventArgs e)
        {
            if (File.Exists(Address))
                try
                {
                    Process.Start("explorer.exe", " /select, " + Address);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể mở file");
                }
            else
                MessageBox.Show("Tập tin không tồn tại");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists(Address))
                try
                {
                    Process.Start(Address);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể mở file");
                }
            else
                MessageBox.Show("Tập tin không tồn tại");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRename_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
