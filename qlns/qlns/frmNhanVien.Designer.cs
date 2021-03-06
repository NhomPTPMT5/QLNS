namespace qlns
{
	partial class frmNhanVien
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
			this.dgvNhanVien = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.gbNhanVien = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLuongCB = new System.Windows.Forms.TextBox();
			this.cboPhongBan = new System.Windows.Forms.ComboBox();
			this.dtpNS = new System.Windows.Forms.DateTimePicker();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
			this.gbNhanVien.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvNhanVien
			// 
			this.dgvNhanVien.AllowUserToAddRows = false;
			this.dgvNhanVien.AllowUserToDeleteRows = false;
			this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
			this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dgvNhanVien.Location = new System.Drawing.Point(6, 19);
			this.dgvNhanVien.Name = "dgvNhanVien";
			this.dgvNhanVien.ReadOnly = true;
			this.dgvNhanVien.RowHeadersVisible = false;
			this.dgvNhanVien.Size = new System.Drawing.Size(659, 354);
			this.dgvNhanVien.TabIndex = 5;
			this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
	
			this.dgvNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhanVien_CellMouseClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaNhanVien";
			this.Column1.HeaderText = "Mã nhân viên";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenNV";
			this.Column2.HeaderText = "Họ tên";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "MaPB";
			this.Column3.HeaderText = "Phòng ban";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "LuongCB";
			this.Column4.HeaderText = "Lương CB";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "GioiTinh";
			this.Column5.HeaderText = "Giới tính";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "NgaySinh";
			this.Column6.HeaderText = "Ngày sinh";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "DienThoai";
			this.Column7.HeaderText = "SDT";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(73, 102);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(71, 20);
			this.txtMaNV.TabIndex = 6;
			// 
			// gbNhanVien
			// 
			this.gbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbNhanVien.Controls.Add(this.groupBox2);
			this.gbNhanVien.Controls.Add(this.dgvNhanVien);
			this.gbNhanVien.Location = new System.Drawing.Point(12, 12);
			this.gbNhanVien.Name = "gbNhanVien";
			this.gbNhanVien.Size = new System.Drawing.Size(909, 384);
			this.gbNhanVien.TabIndex = 10;
			this.gbNhanVien.TabStop = false;
		
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtLuongCB);
			this.groupBox2.Controls.Add(this.cboPhongBan);
			this.groupBox2.Controls.Add(this.dtpNS);
			this.groupBox2.Controls.Add(this.rdNu);
			this.groupBox2.Controls.Add(this.rdNam);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtSDT);
			this.groupBox2.Controls.Add(this.txtTenNV);
			this.groupBox2.Controls.Add(this.iconPictureBox1);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnTimKiem);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtMaNV);
			this.groupBox2.Location = new System.Drawing.Point(671, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 354);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nhân viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Lương CB";
			// 
			// txtLuongCB
			// 
			this.txtLuongCB.Location = new System.Drawing.Point(73, 183);
			this.txtLuongCB.Name = "txtLuongCB";
			this.txtLuongCB.Size = new System.Drawing.Size(131, 20);
			this.txtLuongCB.TabIndex = 33;
			// 
			// cboPhongBan
			// 
			this.cboPhongBan.FormattingEnabled = true;
			this.cboPhongBan.Location = new System.Drawing.Point(74, 156);
			this.cboPhongBan.Name = "cboPhongBan";
			this.cboPhongBan.Size = new System.Drawing.Size(131, 21);
			this.cboPhongBan.TabIndex = 32;
			// 
			// dtpNS
			// 
			this.dtpNS.CustomFormat = "dd-MM-yyyy";
			this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNS.Location = new System.Drawing.Point(74, 232);
			this.dtpNS.Name = "dtpNS";
			this.dtpNS.Size = new System.Drawing.Size(132, 20);
			this.dtpNS.TabIndex = 31;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(167, 208);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(39, 17);
			this.rdNu.TabIndex = 28;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(75, 208);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(47, 17);
			this.rdNam.TabIndex = 27;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 265);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "SDT:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Phòng ban:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "Ngày sinh:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 212);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Giới tính:";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(74, 258);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(132, 20);
			this.txtSDT.TabIndex = 22;
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(73, 130);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(131, 20);
			this.txtTenNV.TabIndex = 20;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 65;
			this.iconPictureBox1.Location = new System.Drawing.Point(75, 19);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(74, 65);
			this.iconPictureBox1.TabIndex = 18;
			this.iconPictureBox1.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Aqua;
			this.btnThem.Location = new System.Drawing.Point(28, 296);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 17;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Aqua;
			this.btnSua.Location = new System.Drawing.Point(28, 325);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 16;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.Aqua;
			this.btnTimKiem.Location = new System.Drawing.Point(131, 325);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 15;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
		
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Aqua;
			this.btnXoa.Location = new System.Drawing.Point(131, 296);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tên NV:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mã NV:";
			// 
			// frmNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 397);
			this.Controls.Add(this.gbNhanVien);
			this.Name = "frmNhanVien";
			this.Text = "NhanVien";
			this.Load += new System.EventHandler(this.frmNhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
			this.gbNhanVien.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvNhanVien;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.GroupBox gbNhanVien;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.RadioButton rdNu;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ComboBox cboPhongBan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLuongCB;
		private System.Windows.Forms.DateTimePicker dtpNS;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}