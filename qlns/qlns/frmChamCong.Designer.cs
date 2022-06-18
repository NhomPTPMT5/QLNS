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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbsnl = new System.Windows.Forms.Label();
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
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(602, 369);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 0;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
			this.dgvChamCong.BackgroundColor = System.Drawing.Color.White;
			this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChamCong.Location = new System.Drawing.Point(12, 35);
			this.dgvChamCong.Name = "dgvChamCong";
			this.dgvChamCong.ReadOnly = true;
			this.dgvChamCong.RowHeadersVisible = false;
			this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvChamCong.Size = new System.Drawing.Size(502, 247);
			this.dgvChamCong.TabIndex = 4;
			this.dgvChamCong.Click += new System.EventHandler(this.dgvChamCong_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbsnl);
			this.groupBox1.Location = new System.Drawing.Point(12, 288);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(502, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lương";
			// 
			// lbsnl
			// 
			this.lbsnl.AutoSize = true;
			this.lbsnl.Location = new System.Drawing.Point(6, 39);
			this.lbsnl.Name = "lbsnl";
			this.lbsnl.Size = new System.Drawing.Size(28, 13);
			this.lbsnl.TabIndex = 0;
			this.lbsnl.Text = "lbsnl";
			// 
			// frmChamCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(933, 397);
			this.Controls.Add(this.btnLuu);
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
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Label lbsnl;
	}
}