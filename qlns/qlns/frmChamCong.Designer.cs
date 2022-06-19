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
			this.dtpCC = new System.Windows.Forms.DateTimePicker();
			this.dgvChamCong = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbsnl = new System.Windows.Forms.Label();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Location = new System.Drawing.Point(519, 35);
			this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(403, 329);
			this.flowLayoutPanel.TabIndex = 3;
			// 
			// dtpCC
			// 
			this.dtpCC.CustomFormat = "";
			this.dtpCC.Location = new System.Drawing.Point(738, 11);
			this.dtpCC.Margin = new System.Windows.Forms.Padding(2);
			this.dtpCC.Name = "dtpCC";
			this.dtpCC.Size = new System.Drawing.Size(184, 20);
			this.dtpCC.TabIndex = 2;
			this.dtpCC.Value = new System.DateTime(2022, 6, 19, 12, 50, 0, 0);
			this.dtpCC.ValueChanged += new System.EventHandler(this.dtpCC_ValueChanged);
			// 
			// dgvChamCong
			// 
			this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvChamCong.BackgroundColor = System.Drawing.Color.White;
			this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChamCong.Location = new System.Drawing.Point(12, 35);
			this.dgvChamCong.Name = "dgvChamCong";
			this.dgvChamCong.ReadOnly = true;
			this.dgvChamCong.RowHeadersVisible = false;
			this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvChamCong.Size = new System.Drawing.Size(502, 247);
			this.dgvChamCong.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLuong);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbsnl);
			this.groupBox1.Location = new System.Drawing.Point(12, 288);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(502, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lương";
			// 
			// txtLuong
			// 
			this.txtLuong.Enabled = false;
			this.txtLuong.Location = new System.Drawing.Point(193, 60);
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(126, 20);
			this.txtLuong.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tổng lương:";
			// 
			// lbsnl
			// 
			this.lbsnl.AutoSize = true;
			this.lbsnl.Location = new System.Drawing.Point(99, 31);
			this.lbsnl.Name = "lbsnl";
			this.lbsnl.Size = new System.Drawing.Size(28, 13);
			this.lbsnl.TabIndex = 0;
			this.lbsnl.Text = "lbsnl";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.Black;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Fax;
			this.btnSave.IconColor = System.Drawing.Color.Black;
			this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.Location = new System.Drawing.Point(796, 369);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(126, 55);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Điểm danh";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmChamCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 408);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvChamCong);
			this.Controls.Add(this.flowLayoutPanel);
			this.Controls.Add(this.dtpCC);
			this.Name = "frmChamCong";
			this.Text = "frmChamCong";
			this.Load += new System.EventHandler(this.frmChamCong_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.DateTimePicker dtpCC;
		private System.Windows.Forms.DataGridView dgvChamCong;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbsnl;
		private FontAwesome.Sharp.IconButton btnSave;
		private System.Windows.Forms.TextBox txtLuong;
		private System.Windows.Forms.Label label1;
	}
}