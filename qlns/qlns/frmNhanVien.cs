using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BLL;
using DTO;

namespace qlns
{
	public partial class frmNhanVien : Form
	{
		
		public frmNhanVien()
		{
			InitializeComponent();
			//tkdto.Quyen = this.Quyen;
			//this.Quyen = _quyen;
		}
		private string quyen;
		NhanVienBLL nvbll = new NhanVienBLL();
		TaiKhoanBLL tk = new TaiKhoanBLL();
		//TaiKhoanDTO tkdto = new TaiKhoanDTO();

		public string Quyen { get => quyen; set => quyen = value; }

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			txtMaNV.Focus();
			List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
			dgvNhanVien.DataSource = dsNhanVien;


			List<PhongBanDTO> dsPhongBan = BLL.PhongBanBLL.LoadcboPB();
			cboPhongBan.DisplayMember = "MaPB";
			cboPhongBan.DataSource = dsPhongBan;

			//btnThem.Enabled = false;
			//btnXoa.Enabled = false;
			//btnSua.Enabled = false;
			//List<TaiKhoanDTO> quyen = BLL.TaiKhoanBLL.LayQ();
			//if (TaiKhoanBLL.Quyen() == false)
			//{
			//	btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
			//}
			//switch (Quyen)
			//{
			//	case "admin":
			//		btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
			//		break;
			//	default:
			//		btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
			//		break;
			//}
			//else if (TaiKhoanBLL.LayQ().Equals("user"))
			//	btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
			//switch (Quyen)
			//{
			//	case "admin":
			//		btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
			//		break;
			//	default:
			//		btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
			//}
		}



		private void btnThem_Click(object sender, EventArgs e)
		{
			try  {
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
				NhanVienBLL.insertNV(manv, tennv, mapb, hesl, gt, ns, dt);
				//BLL.NhanVienBLL.insertNV(manv, tennv, mapb, hesl, gt, ns, dt);
				//List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
				dgvNhanVien.DataSource = NhanVienBLL.LoadNV();/*dsNhanVien*/;
				MessageBox.Show("thêm thành công");
			}
			catch
			{
				MessageBox.Show("không thành công");
			}
			
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try {
				string manv = txtMaNV.Text;
				BLL.NhanVienBLL.deleteNV(manv);
				//List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
				//dgvNhanVien.DataSource = dsNhanVien;
				dgvNhanVien.DataSource = BLL.NhanVienBLL.LoadNV();
				MessageBox.Show("đã xóa");
			}
			catch
			{
				MessageBox.Show("không thành công");
			}
			
			

		}
		
		private void btnSua_Click(object sender, EventArgs e)
		{

			try {
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
				//List<NhanVienDTO> dsNhanVien = BLL.NhanVienBLL.LoadNV();
				//dgvNhanVien.DataSource = dsNhanVien;
				dgvNhanVien.DataSource = BLL.NhanVienBLL.LoadNV();
				MessageBox.Show("đã sửa");
			} catch
			{
				MessageBox.Show("không thành công");
			}
			
		}

		private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e) //load data tu dgv sang txt
		{
			string gt;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = this.dgvNhanVien.Rows[e.RowIndex];
				txtMaNV.Text = r.Cells[0].Value.ToString();
				txtTenNV.Text = r.Cells[1].Value.ToString();
				cboPhongBan.Text = r.Cells[2].Value.ToString();
				txtHeSL.Text = r.Cells[3].Value.ToString();
				gt =  r.Cells[4].Value.ToString();
				if (gt == "Nam")
					rdNam.Checked = true;
				if (gt == "Nữ")
					rdNu.Checked = true;
				//DateTime dt = DateTime.ParseExact(dgvNhanVien.CurrentCell.Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
				//txtNS.Value = dt;
				txtSDT.Text = r.Cells[6].Value.ToString();
			}
		}

		private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
		{
			//truyen data dgv vao datetimepicker
			DateTime dt = DateTime.ParseExact(dgvNhanVien.CurrentRow.Cells[5].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
			txtNS.Value = dt;
		}

		
	}
}
