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
	public partial class frmDN : Form
	{
		public frmDN()
		{
			InitializeComponent();
		}

		//string quyen;
		TaiKhoanBLL tk = new TaiKhoanBLL();
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string tendn = txtTK.Text;
			string mk = txtMK.Text;

			if (TaiKhoanBLL.KTTK(tendn, mk) == true)
			{
				MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmMain f = new frmMain();
				//frmNhanVien f = new frmNhanVien();
				f.Show();
				this.Hide();
				//if (TaiKhoanBLL.Quyen() == true)
				//{
				//	MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//	frmMain f = new frmMain();
				//	//frmNhanVien f = new frmNhanVien();
				//	f.Show();
				//	this.Hide();
				//}
				//if (TaiKhoanBLL.Quyen() == false)
				////else
				//{
				//	MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//	frmMain f = new frmMain();
				//	//frmNhanVien f = new frmNhanVien();
				//	f.Show();
				//	this.Hide();
				//}				
			}
			else if (TaiKhoanBLL.KTTK(tendn, mk) == false)
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
			}
		}

		private void txtTK_Enter(object sender, EventArgs e)
		{
			if (txtTK.Text == "Tên tài khoản")
			{
				txtTK.Text = "";							
			}
			
		}

		private void txtMK_Enter(object sender, EventArgs e)
		{
			if (txtMK.Text == "Mật khẩu")
			{
				txtMK.Text = "";			
			}
		}

		//private void frmDN_Load(object sender, EventArgs e)
		//{
		//	txtTK.Focus();
		//}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult h = MessageBox.Show
				("Bạn có chắc muốn thoát không?", "Thông báo !", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}

		private void chkHienMK_CheckedChanged(object sender, EventArgs e)
		{
			if (chkHienMK.Checked)
			{
				txtMK.PasswordChar = (char)0;
			}
			else
			{
				txtMK.PasswordChar = '*';
			}
		}	
	}
}
