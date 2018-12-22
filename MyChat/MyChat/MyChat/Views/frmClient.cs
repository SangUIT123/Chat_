using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MyChat
{
    public partial class frmClient : Form
    {
        #region Khai Báo biến
        /// <summary>
        /// Di chuyển form
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;

        Conversation conversation = new Conversation();

        Sender sender;
        Thread t;

        bool _focus = true;

        List<string> lstFileName = new List<string>();

        private const int BufferSize = 1024;
        byte[] SendingBuffer;
        #endregion

        #region Hàm tự tạo
        /// <summary>
        /// Gửi tin nhắn thông thường
        /// </summary>
        /// <param name="content"></param>
        void SendMessage(string content, string path)
        {
            if (Setting.TcpServer.Connected)
            {
                Message mes = new Message();
                mes.Sender = Sender.Me;
                mes.Content = content;
                mes.Time = DateTime.Now;
                conversation.AddMessage(mes);
                RefreshWeb();
                // Gửi cho server
                try
                {
                    NetworkStream ns = Setting.TcpServer.GetStream();
                    StreamWriter sw = new StreamWriter(ns);
                    if (path == "")
                    {
                        sw.WriteLine(content);      // Gửi tin nhắn
                        sw.Flush();
                    }
                    else        // Gửi tập tin
                    {
                        DoSendFile(sw, path);
                    }
                    return;
                }
                catch { }
            }
            // Nếu ko ghi được
            while (!Setting.TcpServer.Connected)
            {
                // Thử kết nối lại
                if (MessageBox.Show("Mất kết nối tới server\nThử kết nối lại?", "Lỗi", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    try
                    {
                        Setting.TcpServer = new TcpClient(Setting.Server, Setting.Port);
                    }
                    catch { }
                else
                    break;
            }
        }
        /// <summary>
        /// Thực hiện gửi file tới server
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="path"></param>
        void DoSendFile(StreamWriter sw, string path)
        {
            pnlFile.Visible = true;
            Cursor = Cursors.WaitCursor;

            sw.WriteLine(Setting.MarkSendFile);
            sw.Flush();
            sw.WriteLine(Path.GetFileName(path));
            sw.Flush();

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            int numPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(file.Length) / Convert.ToDouble(BufferSize)));
            prgFile.Maximum = numPackets;
            prgFile.Value = 0;
            sw.WriteLine(numPackets);       // Gửi số packet
            sw.Flush();

            long TotalLength = file.Length;
            int CurrentPacketLength;
            // Gửi lần lượt từng packet
            for (int i = 0; i < numPackets; i++)
            {
                if (TotalLength > BufferSize)
                {
                    CurrentPacketLength = BufferSize;
                    TotalLength = TotalLength - CurrentPacketLength;
                }
                else
                    CurrentPacketLength = (int)TotalLength;
                SendingBuffer = new byte[CurrentPacketLength];
                // Đọc từ file
                file.Read(SendingBuffer, 0, CurrentPacketLength);
                sw.WriteLine(System.Convert.ToBase64String(SendingBuffer));
                sw.Flush();

                if (prgFile.Value >= prgFile.Maximum)
                    prgFile.Value = prgFile.Minimum;
                prgFile.PerformStep();
                lblFile.Text = "Đã gửi " + prgFile.Value + "/" + prgFile.Maximum;
            }
            file.Close();
            Cursor = Cursors.Default;
            pnlFile.Visible = false;
        }
        /// <summary>
        /// Gửi hình ảnh & tập tin đính kèm
        /// </summary>
        /// <param name="path"></param>
        void SendImage(string path)
        {
            Uri url = new Uri(path);
            string address = url.AbsoluteUri;
            string extension = Path.GetExtension(path).ToLower();
            string content = "<a href='" + url.PathAndQuery.Replace(":", "(~*)") + "'>" + ((extension == ".jpg" || extension == ".png") ? "<img src='" + address + "' style='max-width:300px'/><br/>" : "") + "<b>" + Path.GetFileName(path) + "</b></a> (" + FileSize.SizeSuffix(new FileInfo(path).Length) + ")";

            SendMessage(content, path);
        }
        /// <summary>
        /// Điều khiển nháy icon
        /// </summary>
        void Flash()
        {
            if (!_focus)
                FlashWindow.Start(this);
        }
        /// <summary>
        /// Lắng nghe từ server
        /// </summary>
        void Listening()
        {
            NetworkStream ns = Setting.TcpServer.GetStream();
            StreamReader sr = new StreamReader(ns);
            string s;
            while (Setting.TcpServer.Connected)
            {
                try
                {
                    s = sr.ReadLine();
                    if (s != null)
                    {
                        if (s == Setting.MarkSendFile)       // Nếu gửi file
                        {
                            s = DoReciveFile(sr);
                        }
                        this.Invoke(new Action(() =>
                        {
                            Flash();
                        }));
                        // Add number
                        conversation.AddMessage(new Message() { Content = s, Sender = sender, Time = DateTime.Now });
                        RefreshWeb();
                        continue;
                    }
                }
                catch { }
                // Nếu ko đọc được hoặc nội dung đọc về là null
                while (!Setting.TcpServer.Connected)
                {
                    // Thử kết nối lại
                    if (MessageBox.Show("Mất kết nối tới server\nThử kết nối lại?", "Lỗi", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        try
                        {
                            Setting.TcpServer = new TcpClient(Setting.Server, Setting.Port);
                        }
                        catch { }
                    else
                    {
                        Thread.CurrentThread.Abort();       // Ngắt kết nối
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Thực hiện nhận file
        /// </summary>
        /// <param name="sr"></param>
        /// <returns>FileName đã nhận</returns>
        string DoReciveFile(StreamReader sr)
        {
            string filename = sr.ReadLine();        // Tên file
            lstFileName.Add(filename);

            int numPacket = Convert.ToInt32(sr.ReadLine());

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    pnlFile.Visible = true;
                    Cursor = Cursors.WaitCursor;
                    prgFile.Maximum = numPacket;
                    prgFile.Value = 0;
                    FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    for (int i = 0; i < numPacket; i++)
                    {
                        string base64 = sr.ReadLine();      // Nội dung file
                        SendingBuffer = System.Convert.FromBase64String(base64);
                        file.Write(SendingBuffer, 0, SendingBuffer.Length);

                        if (prgFile.Value >= prgFile.Maximum)
                            prgFile.Value = prgFile.Minimum;
                        prgFile.PerformStep();
                        lblFile.Text = "Đã nhận " + prgFile.Value + "/" + prgFile.Maximum;
                    }
                    file.Close();
                    Cursor = Cursors.Default;
                    pnlFile.Visible = false;
                }));
            }

            string path = Directory.GetCurrentDirectory() + "/" + filename;
            Uri url = new Uri(path);
            string address = url.AbsoluteUri;
            string extension = Path.GetExtension(filename).ToLower();
            string s = "<a href='" + url.PathAndQuery.Replace(":", "(~*)") + "'>" + ((extension == ".jpg" || extension == ".png") ? "<img src='" + address + "' style='max-width:300px'/><br/>" : "") + "<b>" + filename + "</b></a> (" + FileSize.SizeSuffix(new FileInfo(filename).Length) + ")";

            return s;
        }
        /// <summary>
        /// Nạp lại nội dung tin nhắn
        /// </summary>
        void RefreshWeb()
        {
            // Chưa scroll xuống cuối được => có thể phải thêm nút js
            webMain.Invoke(new Action(() =>
            {
                webMain.Document.Write(conversation.GetHTML);
                webMain.Refresh();
              //  webMain.Document.Window.ScrollTo(0, webMain.Document.Body.ScrollRectangle.Height);
            }));
        }
        #endregion

        #region Forms
        public frmClient()
        {
            InitializeComponent();
            this.Padding = new Padding(1);

            sender = new Sender() { Address = Setting.Server, Port = Setting.Port, Tcp = Setting.TcpServer };

            t = new Thread(Listening);
            t.Start();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text = "KẾT NỐI VỚI " + Setting.Server;

            txtMessage.Focus();
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var f in lstFileName)
            {
                if (File.Exists(f))
                    File.Delete(f);
            }
            t.Abort();
            Setting.TcpServer.Close();
        }

        private void frmClient_Deactived(object sender, EventArgs e)
        {
            BackColor = Color.DimGray;
            _focus = false;
        }

        private void frmClient_Activated(object sender, EventArgs e)
        {
            BackColor = Color.DarkOrange;
            txtMessage.Focus();

            _focus = true;
            FlashWindow.Stop(this);
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
        #endregion

        #region Move form
        private void frmClient_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void frmClient_MouseMove(object sender, MouseEventArgs e)
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

        private void frmClient_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        #region Controls
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                SendMessage(txtMessage.Text, "");
                txtMessage.Text = "";
                txtMessage.Focus();
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnSend.PerformClick();

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void webMain_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            e.Cancel = true;
            if (e.Url.ToString() != "about:blank")
            {
                string url = e.Url.PathAndQuery;
                frmOpenFile frm = new frmOpenFile(url);
                frm.ShowDialog();
            }
        }

        private void webMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.RestoreDirectory = true;
            dia.Title = "Chọn tập tin đính kèm";
            if (dia.ShowDialog() == DialogResult.OK)
                SendImage(dia.FileName);
        }
        #endregion
    }
}
