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
	public partial class frmUser : Form
	{
		public frmUser()
		{
			InitializeComponent();
		}

		private void frmUser_Load(object sender, EventArgs e)
		{
			dgvUser.DataSource = TaiKhoanBLL.LoadTK();
		}

		private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txtManv.Text;
				string tendn = txtTK.Text;
				string mk = txtMK.Text;
				string quyen = txtQuyen.Text;
				TaiKhoanBLL.insertTK(manv, tendn, mk, quyen);
				dgvUser.DataSource = TaiKhoanBLL.LoadTK();
				MessageBox.Show("tạo tài khoản thành công !");
			}
			catch
			{
				MessageBox.Show("tạo tài khoản thất bại !");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txtManv.Text;
				string tendn = txtTK.Text;
				string mk = txtMK.Text;
				string quyen = txtQuyen.Text;
				TaiKhoanBLL.updateTK(manv, tendn, mk, quyen);
				dgvUser.DataSource = TaiKhoanBLL.LoadTK();
				MessageBox.Show(" sửa tài khoản thành công !");
			}
			catch
			{
				MessageBox.Show("sửa tài khoản thất bại !");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txtManv.Text;
				TaiKhoanBLL.deleteTK(manv);
				dgvUser.DataSource = TaiKhoanBLL.LoadTK();
				MessageBox.Show("xóa tài khoản thành công !");
			}
			catch
			{
				MessageBox.Show("xóa tài khoản thất bại !");
			}
		}

		private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = this.dgvUser.Rows[e.RowIndex];
				txtManv.Text = r.Cells[0].Value.ToString();
				txtTK.Text = r.Cells[1].Value.ToString();
				txtMK.Text = r.Cells[2].Value.ToString();
				txtQuyen.Text = r.Cells[3].Value.ToString();
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
