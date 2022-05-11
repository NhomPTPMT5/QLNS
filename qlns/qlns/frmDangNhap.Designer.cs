namespace qlns
{
	partial class frmDangNhap
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
			this.txtDangNhap = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.ckNhoMatKhau = new System.Windows.Forms.CheckBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDangNhap
			// 
			this.txtDangNhap.Location = new System.Drawing.Point(330, 104);
			this.txtDangNhap.Name = "txtDangNhap";
			this.txtDangNhap.Size = new System.Drawing.Size(137, 20);
			this.txtDangNhap.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(298, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Đăng nhập";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Location = new System.Drawing.Point(330, 279);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(91, 29);
			this.btnDangNhap.TabIndex = 2;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			// 
			// ckNhoMatKhau
			// 
			this.ckNhoMatKhau.AutoSize = true;
			this.ckNhoMatKhau.Location = new System.Drawing.Point(330, 222);
			this.ckNhoMatKhau.Name = "ckNhoMatKhau";
			this.ckNhoMatKhau.Size = new System.Drawing.Size(91, 17);
			this.ckNhoMatKhau.TabIndex = 3;
			this.ckNhoMatKhau.Text = "nhớ mật khẩu";
			this.ckNhoMatKhau.UseVisualStyleBackColor = true;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(330, 169);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(137, 20);
			this.txtMatKhau.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(233, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tài khoản";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(237, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "mật khẩu";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(600, 328);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(64, 23);
			this.btnThoat.TabIndex = 7;
			this.btnThoat.Text = "thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 363);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.ckNhoMatKhau);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDangNhap);
			this.Name = "frmDangNhap";
			this.Text = "frmDangNhap";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDangNhap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.CheckBox ckNhoMatKhau;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnThoat;
	}
}