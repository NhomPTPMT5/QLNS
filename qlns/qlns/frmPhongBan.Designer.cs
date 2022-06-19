namespace qlns
{
	partial class frmPhongBan
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
			this.gbNhanVien = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboPhongBan = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenPB = new System.Windows.Forms.TextBox();
			this.dgvPhongBan = new System.Windows.Forms.DataGridView();
			this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbNhanVien.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
			this.SuspendLayout();
			// 
			// gbNhanVien
			// 
			this.gbNhanVien.Controls.Add(this.groupBox2);
			this.gbNhanVien.Controls.Add(this.dgvPhongBan);
			this.gbNhanVien.Location = new System.Drawing.Point(12, 6);
			this.gbNhanVien.Name = "gbNhanVien";
			this.gbNhanVien.Size = new System.Drawing.Size(909, 384);
			this.gbNhanVien.TabIndex = 11;
			this.gbNhanVien.TabStop = false;
			this.gbNhanVien.Enter += new System.EventHandler(this.gbNhanVien_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboPhongBan);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.iconPictureBox1);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnTimKiem);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtTenPB);
			this.groupBox2.Location = new System.Drawing.Point(671, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 354);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Phòng ban";
			// 
			// cboPhongBan
			// 
			this.cboPhongBan.FormattingEnabled = true;
			this.cboPhongBan.Location = new System.Drawing.Point(75, 139);
			this.cboPhongBan.Name = "cboPhongBan";
			this.cboPhongBan.Size = new System.Drawing.Size(131, 21);
			this.cboPhongBan.TabIndex = 32;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 191);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Phòng ban:";
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 65;
			this.iconPictureBox1.Location = new System.Drawing.Point(13, 19);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(74, 65);
			this.iconPictureBox1.TabIndex = 18;
			this.iconPictureBox1.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(28, 278);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 17;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(28, 325);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 16;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(131, 325);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 15;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(131, 278);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mã PB:";
			// 
			// txtTenPB
			// 
			this.txtTenPB.Location = new System.Drawing.Point(75, 188);
			this.txtTenPB.Name = "txtTenPB";
			this.txtTenPB.Size = new System.Drawing.Size(131, 20);
			this.txtTenPB.TabIndex = 6;
			// 
			// dgvPhongBan
			// 
			this.dgvPhongBan.AllowUserToAddRows = false;
			this.dgvPhongBan.AllowUserToDeleteRows = false;
			this.dgvPhongBan.AllowUserToOrderColumns = true;
			this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPhongBan.BackgroundColor = System.Drawing.Color.White;
			this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.Column1});
			this.dgvPhongBan.Location = new System.Drawing.Point(6, 25);
			this.dgvPhongBan.Name = "dgvPhongBan";
			this.dgvPhongBan.ReadOnly = true;
			this.dgvPhongBan.RowHeadersVisible = false;
			this.dgvPhongBan.Size = new System.Drawing.Size(659, 348);
			this.dgvPhongBan.TabIndex = 5;
			this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
			// 
			// MaPB
			// 
			this.MaPB.DataPropertyName = "MaPB";
			this.MaPB.FillWeight = 59.36768F;
			this.MaPB.HeaderText = "Mã phòng ban";
			this.MaPB.Name = "MaPB";
			this.MaPB.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "TenPB";
			this.Column1.HeaderText = "Phòng ban";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// frmPhongBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 397);
			this.Controls.Add(this.gbNhanVien);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "frmPhongBan";
			this.Text = "Phong ban";
			this.Load += new System.EventHandler(this.frmPhongBan_Load);
			this.gbNhanVien.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbNhanVien;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cboPhongBan;
		private System.Windows.Forms.Label label6;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenPB;
		private System.Windows.Forms.DataGridView dgvPhongBan;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}