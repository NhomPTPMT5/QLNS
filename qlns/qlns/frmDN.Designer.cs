namespace qlns
{
	partial class frmDN
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDN));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtMK = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblstatus = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.chkHienMK = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(179, 98);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(69, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 49;
			this.pictureBox1.TabStop = false;
			// 
			// txtMK
			// 
			this.txtMK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMK.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMK.ForeColor = System.Drawing.Color.White;
			this.txtMK.Location = new System.Drawing.Point(119, 274);
			this.txtMK.Name = "txtMK";
			this.txtMK.PasswordChar = '*';
			this.txtMK.Size = new System.Drawing.Size(214, 20);
			this.txtMK.TabIndex = 48;
			this.txtMK.Text = "Mật khẩu";
			this.txtMK.Enter += new System.EventHandler(this.txtMK_Enter);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(77, 244);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(254, 1);
			this.panel1.TabIndex = 42;
			// 
			// txtTK
			// 
			this.txtTK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTK.ForeColor = System.Drawing.Color.White;
			this.txtTK.Location = new System.Drawing.Point(117, 223);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(214, 22);
			this.txtTK.TabIndex = 47;
			this.txtTK.Text = "Tên tài khoản";
			this.txtTK.Enter += new System.EventHandler(this.txtTK_Enter);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(117, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 44);
			this.label1.TabIndex = 46;
			this.label1.Text = "Đăng Nhập";
			// 
			// lblstatus
			// 
			this.lblstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblstatus.AutoSize = true;
			this.lblstatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblstatus.ForeColor = System.Drawing.Color.Red;
			this.lblstatus.Location = new System.Drawing.Point(176, 309);
			this.lblstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblstatus.Name = "lblstatus";
			this.lblstatus.Size = new System.Drawing.Size(0, 16);
			this.lblstatus.TabIndex = 45;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnLogin.Location = new System.Drawing.Point(159, 357);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(114, 33);
			this.btnLogin.TabIndex = 44;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// chkHienMK
			// 
			this.chkHienMK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chkHienMK.AutoSize = true;
			this.chkHienMK.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.chkHienMK.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.chkHienMK.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.chkHienMK.Location = new System.Drawing.Point(78, 310);
			this.chkHienMK.Margin = new System.Windows.Forms.Padding(2);
			this.chkHienMK.Name = "chkHienMK";
			this.chkHienMK.Size = new System.Drawing.Size(94, 17);
			this.chkHienMK.TabIndex = 43;
			this.chkHienMK.Text = "Hiện mật khẩu";
			this.chkHienMK.UseVisualStyleBackColor = true;
			this.chkHienMK.CheckedChanged += new System.EventHandler(this.chkHienMK_CheckedChanged);
			this.chkHienMK.Click += new System.EventHandler(this.chkHienMK_Click);
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Location = new System.Drawing.Point(77, 298);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(254, 1);
			this.panel4.TabIndex = 41;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(79, 269);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(35, 30);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 40;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(77, 213);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(35, 30);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 39;
			this.pictureBox3.TabStop = false;
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(382, 414);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(58, 24);
			this.btnThoat.TabIndex = 38;
			this.btnThoat.Text = "Thoát ";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmDN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(452, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtMK);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtTK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblstatus);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.chkHienMK);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnThoat);
			this.Name = "frmDN";
			this.Text = "frmDN";
			this.Load += new System.EventHandler(this.frmDN_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtMK;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblstatus;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox chkHienMK;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnThoat;
	}
}