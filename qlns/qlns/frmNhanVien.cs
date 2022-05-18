using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace qlns
{
	public partial class frmNhanVien : Form
	{
		public frmNhanVien()
		{
			InitializeComponent();
		}

		//NhanVienBLL nvbll = new NhanVienBLL();

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			//dgvNhanVien.DataSource = nvbll.LoadNV();
			List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
			dgvNhanVien.DataSource = dsNhanVien;
		}
	}
}
