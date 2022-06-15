namespace qlns
{
	partial class frmChamCong
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
			this.cboManv = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvNhanVien = new System.Windows.Forms.DataGridView();
			this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cboManv);
			this.groupBox1.Controls.Add(this.dtpThoiGian);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(261, 232);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// dtpThoiGian
			// 
			this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpThoiGian.CustomFormat = "dd/MM/yyyy";
			this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpThoiGian.Location = new System.Drawing.Point(5, 75);
			this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpThoiGian.Name = "dtpThoiGian";
			this.dtpThoiGian.Size = new System.Drawing.Size(251, 20);
			this.dtpThoiGian.TabIndex = 4;
			this.dtpThoiGian.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
			// 
			// cboManv
			// 
			this.cboManv.FormattingEnabled = true;
			this.cboManv.Location = new System.Drawing.Point(5, 149);
			this.cboManv.Name = "cboManv";
			this.cboManv.Size = new System.Drawing.Size(133, 21);
			this.cboManv.TabIndex = 5;
			this.cboManv.SelectedIndexChanged += new System.EventHandler(this.cboManv_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Thời gian";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mã nhân viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(758, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(758, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "label4";
			// 
			// dgvNhanVien
			// 
			this.dgvNhanVien.AllowUserToAddRows = false;
			this.dgvNhanVien.AllowUserToDeleteRows = false;
			this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
			this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.Column4,
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column8});
			this.dgvNhanVien.Location = new System.Drawing.Point(279, 12);
			this.dgvNhanVien.Name = "dgvNhanVien";
			this.dgvNhanVien.ReadOnly = true;
			this.dgvNhanVien.RowHeadersVisible = false;
			this.dgvNhanVien.Size = new System.Drawing.Size(473, 232);
			this.dgvNhanVien.TabIndex = 9;
			// 
			// MaNhanVien
			// 
			this.MaNhanVien.DataPropertyName = "MaNhanVien";
			this.MaNhanVien.FillWeight = 59.36768F;
			this.MaNhanVien.HeaderText = "Mã nhân viên";
			this.MaNhanVien.Name = "MaNhanVien";
			this.MaNhanVien.ReadOnly = true;
			this.MaNhanVien.Visible = false;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "TenNV";
			this.Column4.FillWeight = 91.3865F;
			this.Column4.HeaderText = "Tên nhân viên";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaPB";
			this.Column1.FillWeight = 38.38234F;
			this.Column1.HeaderText = "Phòng ban";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "HeSoLuong";
			this.Column3.FillWeight = 59.36768F;
			this.Column3.HeaderText = "Hệ số lương";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Visible = false;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "GioiTinh";
			this.Column5.FillWeight = 38.38234F;
			this.Column5.HeaderText = "Giới tính";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "NgaySinh";
			this.Column6.FillWeight = 38.38234F;
			this.Column6.HeaderText = "Ngày sinh";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "DienThoai";
			this.Column8.FillWeight = 38.38234F;
			this.Column8.HeaderText = "SDT";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// frmChamCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 397);
			this.Controls.Add(this.dgvNhanVien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChamCong";
			this.Text = "frmChamCong";
			this.Load += new System.EventHandler(this.frmChamCong_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpThoiGian;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboManv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvNhanVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
	}
}