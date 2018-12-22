using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyChat
{
    public partial class frmRename : Form
    {
        /// <summary>
        /// Di chuyển form
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;

        public string NickName = "";
        public Color Color;
        public frmRename(string nick, Color col)
        {
            InitializeComponent();
            NickName = nick;
            Color = col;
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

        private void panel4_Click(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text != "")
            {
                NickName = txtMessage.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void frmRename_Load(object sender, EventArgs e)
        {
            txtMessage.Text = NickName;
            btnChonMau.BackColor = Color;
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color;
            if(colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color = colorDialog1.Color;
                btnChonMau.BackColor = Color;
            }
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

        private void frmRename_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
