namespace MyChat
{
    partial class frmOpenFile
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
            this.btnExplore = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.Gold;
            this.btnExplore.FlatAppearance.BorderSize = 0;
            this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExplore.Location = new System.Drawing.Point(168, 65);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(225, 40);
            this.btnExplore.TabIndex = 7;
            this.btnExplore.Text = "MỞ THƯ MỤC CHỨA FILE";
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 50);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseUp);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnOpen.Location = new System.Drawing.Point(15, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(135, 40);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "MỞ FILE";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(11, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(338, 22);
            this.lblName.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(355, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOpenFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(405, 120);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnExplore);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpenFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn";
            this.Load += new System.EventHandler(this.frmRename_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
    }
}