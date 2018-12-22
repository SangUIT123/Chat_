namespace MyChat
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnServer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyChat.Properties.Resources._1459234947_message_01;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "by NVNhan";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MYCHAT";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(350, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.btnServer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 115);
            this.panel2.TabIndex = 1;
            // 
            // btnServer
            // 
            this.btnServer.AutoEllipsis = true;
            this.btnServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Location = new System.Drawing.Point(0, 0);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(400, 115);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "KHỞI CHẠY NHƯ SERVER";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.txtServer);
            this.panel3.Controls.Add(this.btnClient);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 115);
            this.panel3.TabIndex = 2;
            // 
            // txtServer
            // 
            this.txtServer.AccessibleDescription = "sdcds";
            this.txtServer.AccessibleName = "df";
            this.txtServer.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtServer.Location = new System.Drawing.Point(135, 7);
            this.txtServer.MaxLength = 15;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(130, 22);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "127.0.0.1";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClient
            // 
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(0, 0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(400, 115);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "KHỞI CHẠY NHƯ CLIENT";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MYCHAT";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmStart_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}