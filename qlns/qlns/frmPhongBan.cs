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
	public partial class frmPhongBan : Form
	{
		public frmPhongBan()
		{
			InitializeComponent();
		}

		private void frmPhongBan_Load(object sender, EventArgs e)
		{
			List<PhongBanDTO> dsPhongBan = BLL.PhongBanBLL.LoadPB();
			dgvPhongBan.DataSource = dsPhongBan;

			List<PhongBanDTO> dscboPhongBan = BLL.PhongBanBLL.LoadcboPB();
			cboPhongBan.DisplayMember = "MaPB";
			cboPhongBan.DataSource = dscboPhongBan;

			//TaiKhoanBLL tkdto = new TaiKhoanBLL();
			//if (tkdto. == "true")
			//{
			//	btnThem.Enabled = true;
			//	btnXoa.Enabled = true;
			//	btnSua.Enabled = true;
			//}
			//if(tkdto.Quyen == "false")
			//{
			//	btnThem.Enabled = false;
			//	btnXoa.Enabled = false;
			//	btnSua.Enabled = false;
				
			//}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try {
				string mapb = cboPhongBan.Text;
				string tenpb = txtTenPB.Text;
				PhongBanBLL.insertPB(mapb, tenpb);
				dgvPhongBan.DataSource = PhongBanBLL.LoadPB();
				MessageBox.Show("them thanh cong");
			}
			catch
			{
				MessageBox.Show("that bai");
			}
			
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				string mapb = cboPhongBan.Text;
				PhongBanBLL.deletePB(mapb);
				dgvPhongBan.DataSource = PhongBanBLL.LoadPB();
				MessageBox.Show(" thanh cong");
			}
			catch
			{
				MessageBox.Show("that bai");
			}
			
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				string mapb = cboPhongBan.Text;
				string tenpb = txtTenPB.Text;
				PhongBanBLL.updatePB(mapb, tenpb);
				dgvPhongBan.DataSource = PhongBanBLL.LoadPB();
				MessageBox.Show(" thanh cong");
			}
			catch
			{
				MessageBox.Show("that bai");
			}
		}

		private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow r = this.dgvPhongBan.Rows[e.RowIndex];
			cboPhongBan.Text = r.Cells[0].Value.ToString();
			txtTenPB.Text = r.Cells[1].Value.ToString();
		}

		private void gbNhanVien_Enter(object sender, EventArgs e)
		{

		}
	}
}
