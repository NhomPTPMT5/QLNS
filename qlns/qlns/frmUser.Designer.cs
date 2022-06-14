namespace qlns
{
	partial class frmUser
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.txtQuyen = new System.Windows.Forms.TextBox();
			this.txtMK = new System.Windows.Forms.TextBox();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtManv = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.txtQuyen);
			this.groupBox2.Controls.Add(this.txtMK);
			this.groupBox2.Controls.Add(this.txtTK);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtManv);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(668, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 373);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tài khoản";
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(91, 329);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(89, 28);
			this.btnXoa.TabIndex = 10;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(158, 284);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(89, 28);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// txtQuyen
			// 
			this.txtQuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQuyen.Location = new System.Drawing.Point(111, 223);
			this.txtQuyen.Name = "txtQuyen";
			this.txtQuyen.Size = new System.Drawing.Size(136, 22);
			this.txtQuyen.TabIndex = 8;
			// 
			// txtMK
			// 
			this.txtMK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtMK.Location = new System.Drawing.Point(111, 175);
			this.txtMK.Name = "txtMK";
			this.txtMK.Size = new System.Drawing.Size(136, 22);
			this.txtMK.TabIndex = 7;
			// 
			// txtTK
			// 
			this.txtTK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTK.Location = new System.Drawing.Point(111, 130);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(136, 22);
			this.txtTK.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Quyền hạn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mật khẩu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tài khoản:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã nhân viên:";
			// 
			// txtManv
			// 
			this.txtManv.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtManv.Location = new System.Drawing.Point(111, 81);
			this.txtManv.Name = "txtManv";
			this.txtManv.Size = new System.Drawing.Size(136, 22);
			this.txtManv.TabIndex = 1;
			// 
			// btnThem
			// 
			this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(18, 284);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(89, 28);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Tạo tài khoản";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvUser);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(650, 373);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách tài khoản";
			// 
			// dgvUser
			// 
			this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUser.BackgroundColor = System.Drawing.Color.White;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgvUser.Location = new System.Drawing.Point(6, 37);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.RowHeadersVisible = false;
			this.dgvUser.Size = new System.Drawing.Size(638, 330);
			this.dgvUser.TabIndex = 2;
			this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
			this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaNV";
			this.Column1.HeaderText = "Mã nhân viên";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenDN";
			this.Column2.HeaderText = "Tên tài khoản";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "MK";
			this.Column3.HeaderText = "Mật khẩu";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Quyen";
			this.Column4.HeaderText = "Quyền hạn";
			this.Column4.Name = "Column4";
			// 
			// frmUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 397);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmUser";
			this.Text = "A";
			this.Load += new System.EventHandler(this.frmUser_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.TextBox txtQuyen;
		private System.Windows.Forms.TextBox txtMK;
		private System.Windows.Forms.TextBox txtTK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtManv;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}