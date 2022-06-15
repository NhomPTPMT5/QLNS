using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace qlns
{
	public partial class frmChamCong : Form
	{
		public frmChamCong()
		{
			InitializeComponent();
		}

		private void frmChamCong_Load(object sender, EventArgs e)
		{
			dtpThoiGian.Value = DateTime.Now;
			cboManv.DataSource = NhanVienBLL.loadcboMNV();
			cboManv.DisplayMember = "Manhanvien";
			dgvNhanVien.DataSource = NhanVienBLL.LoadNV();
		}

		private void cboManv_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboManv.SelectedIndex != -1)
			{

			}
		}
	}
}
