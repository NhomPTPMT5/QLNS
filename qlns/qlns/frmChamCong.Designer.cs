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
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnLuu = new System.Windows.Forms.Button();
			this.dtpCC = new System.Windows.Forms.DateTimePicker();
			this.dgvChamCong = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Controls.Add(this.btnLuu);
			this.flowLayoutPanel.Location = new System.Drawing.Point(548, 35);
			this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(374, 353);
			this.flowLayoutPanel.TabIndex = 3;
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(3, 3);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 0;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			// 
			// dtpCC
			// 
			this.dtpCC.CustomFormat = "";
			this.dtpCC.Location = new System.Drawing.Point(738, 11);
			this.dtpCC.Margin = new System.Windows.Forms.Padding(2);
			this.dtpCC.Name = "dtpCC";
			this.dtpCC.Size = new System.Drawing.Size(184, 20);
			this.dtpCC.TabIndex = 2;
			this.dtpCC.ValueChanged += new System.EventHandler(this.dtpCC_ValueChanged);
			// 
			// dgvChamCong
			// 
			this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgvChamCong.Location = new System.Drawing.Point(12, 35);
			this.dgvChamCong.Name = "dgvChamCong";
			this.dgvChamCong.RowHeadersVisible = false;
			this.dgvChamCong.Size = new System.Drawing.Size(531, 247);
			this.dgvChamCong.TabIndex = 4;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "MaChamCong";
			this.Column2.FillWeight = 60F;
			this.Column2.HeaderText = "Mã CC";
			this.Column2.Name = "Column2";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Tendn";
			this.Column1.FillWeight = 89.54314F;
			this.Column1.HeaderText = "Tài khoản";
			this.Column1.Name = "Column1";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Ngay";
			this.Column3.FillWeight = 70F;
			this.Column3.HeaderText = "Ngày";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Thang";
			this.Column4.FillWeight = 70F;
			this.Column4.HeaderText = "Tháng ";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Nam";
			this.Column5.FillWeight = 70F;
			this.Column5.HeaderText = "Nam";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "Check";
			this.Column6.FillWeight = 50F;
			this.Column6.HeaderText = "Điểm danh";
			this.Column6.Name = "Column6";
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column6.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(12, 288);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(531, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lương";
			// 
			// frmChamCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 397);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvChamCong);
			this.Controls.Add(this.flowLayoutPanel);
			this.Controls.Add(this.dtpCC);
			this.Name = "frmChamCong";
			this.Text = "frmChamCong";
			this.Load += new System.EventHandler(this.frmChamCong_Load);
			this.flowLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.DateTimePicker dtpCC;
		private System.Windows.Forms.DataGridView dgvChamCong;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
		private System.Windows.Forms.Button btnLuu;
	}
}