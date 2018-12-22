namespace MyChat
{
    partial class frmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSender = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFile = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.prgFile = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(30)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(560, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "---";
            this.toolTip1.SetToolTip(this.btnMinimize, "Thu nhỏ chương trình");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyChat.Properties.Resources._1459234947_message_01;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(44, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MYCHAT";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(610, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.toolTip1.SetToolTip(this.btnExit, "Thoát chương trình");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnImage);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 70);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txtMessage);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 40);
            this.panel4.TabIndex = 6;
            this.toolTip1.SetToolTip(this.panel4, "Nhập tin nhắn...");
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(5, 11);
            this.txtMessage.MaxLength = 500;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(330, 18);
            this.txtMessage.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMessage, "Nhập tin nhắn...");
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.LimeGreen;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnImage.Image = global::MyChat.Properties.Resources._1459841495_Attach;
            this.btnImage.Location = new System.Drawing.Point(350, 15);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(40, 40);
            this.btnImage.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnImage, "Gửi tập tin đính kèm");
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSend.Image = global::MyChat.Properties.Resources._1459189602_send_01;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(390, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "     GỬI";
            this.toolTip1.SetToolTip(this.btnSend, "Gửi tin nhắn");
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // webMain
            // 
            this.webMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMain.IsWebBrowserContextMenuEnabled = false;
            this.webMain.Location = new System.Drawing.Point(0, 50);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(480, 460);
            this.webMain.TabIndex = 2;
            this.webMain.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webMain.WebBrowserShortcutsEnabled = false;
            this.webMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webMain_DocumentCompleted);
            this.webMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webMain_Navigating);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pnlSender);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(480, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 530);
            this.panel3.TabIndex = 3;
            // 
            // pnlSender
            // 
            this.pnlSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSender.Location = new System.Drawing.Point(0, 0);
            this.pnlSender.Name = "pnlSender";
            this.pnlSender.Size = new System.Drawing.Size(180, 530);
            this.pnlSender.TabIndex = 1;
            this.pnlSender.Visible = false;
            this.pnlSender.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSender_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đang chờ client\r\nkết nối tới...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFile
            // 
            this.pnlFile.BackColor = System.Drawing.Color.White;
            this.pnlFile.Controls.Add(this.lblFile);
            this.pnlFile.Controls.Add(this.prgFile);
            this.pnlFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFile.Location = new System.Drawing.Point(0, 430);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(480, 80);
            this.pnlFile.TabIndex = 4;
            this.pnlFile.Visible = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(11, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(122, 19);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Đang nhận dữ liệu";
            // 
            // prgFile
            // 
            this.prgFile.Location = new System.Drawing.Point(15, 39);
            this.prgFile.Name = "prgFile";
            this.prgFile.Size = new System.Drawing.Size(450, 25);
            this.prgFile.Step = 1;
            this.prgFile.TabIndex = 0;
            this.prgFile.Click += new System.EventHandler(this.prgFile_Click);
            // 
            // frmServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(660, 580);
            this.Controls.Add(this.pnlFile);
            this.Controls.Add(this.webMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.toolTip1.SetToolTip(this, "Danh sách các client đã kết nối");
            this.Activated += new System.EventHandler(this.frmServer_Activated);
            this.Deactivate += new System.EventHandler(this.frmServer_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmServer_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlSender;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ProgressBar prgFile;
    }
}