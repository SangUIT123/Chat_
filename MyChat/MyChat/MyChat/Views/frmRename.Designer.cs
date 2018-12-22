namespace MyChat
{
    partial class frmRename
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
            this.btnChange = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnChange.Location = new System.Drawing.Point(200, 70);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 40);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "THAY ĐỔI";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txtMessage);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(15, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 40);
            this.panel4.TabIndex = 9;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(5, 10);
            this.txtMessage.MaxLength = 500;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(180, 18);
            this.txtMessage.TabIndex = 0;
            // 
            // btnChonMau
            // 
            this.btnChonMau.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChonMau.FlatAppearance.BorderSize = 0;
            this.btnChonMau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonMau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonMau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnChonMau.Location = new System.Drawing.Point(15, 15);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(320, 40);
            this.btnChonMau.TabIndex = 10;
            this.btnChonMau.Text = "CHỌN MÀU";
            this.btnChonMau.UseVisualStyleBackColor = false;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // frmRename
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 125);
            this.Controls.Add(this.btnChonMau);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnChange);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRename";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi tên";
            this.Load += new System.EventHandler(this.frmRename_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRename_MouseUp);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChonMau;
    }
}