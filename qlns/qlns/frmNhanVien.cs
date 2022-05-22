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

		//public void loadcbo()
		//{
		//	List<ComboBox> lis
		//}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			//dgvNhanVien.DataSource = nvbll.LoadNV();

			List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
			dgvNhanVien.DataSource = dsNhanVien;


			List<PhongBanDTO> dsPhongBan = BLL.PhongBanBLL.LoadcboPB();
			cboPhongBan.DisplayMember = "MaPB";
			cboPhongBan.DataSource = dsPhongBan;
			
		}



		private void btnThem_Click(object sender, EventArgs e)
		{
			string manv = txtMaNV.Text;
			string tennv = txtTenNV.Text;
			string mapb = cboPhongBan.Text;
			string hesl = txtHeSL.Text;
			string gt = "";
			if (rdNam.Checked == true)
			{
				gt = "Nam";
			}
			if (rdNu.Checked == true)
			{
				gt = "Nữ";
			}
			string ns = txtNS.Text;
			string dt = txtSDT.Text;
			BLL.NhanVienBLL.insertNV(manv, tennv, mapb, hesl, gt, ns, dt);
			List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
			dgvNhanVien.DataSource = dsNhanVien;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string manv = txtMaNV.Text;
			BLL.NhanVienBLL.deleteNV(manv);
			List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
			dgvNhanVien.DataSource = dsNhanVien;

		}
		//string idNV;
		//int id;
		private void btnSua_Click(object sender, EventArgs e)
		{
			
		
			string manv = txtMaNV.Text;
			string tennv = txtTenNV.Text;
			string mapb = cboPhongBan.Text;
			string hesl = txtHeSL.Text;
			string gt = "";
			if (rdNam.Checked == true)
			{
				gt = "Nam";
			}
			if (rdNu.Checked == true)
			{
				gt = "Nữ";
			}
			string ns = txtNS.Text;
			string dt = txtSDT.Text;
			BLL.NhanVienBLL.updateNV(manv, tennv, mapb, hesl, gt, ns, dt);
			List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
			dgvNhanVien.DataSource = dsNhanVien;
		}
	}
}
