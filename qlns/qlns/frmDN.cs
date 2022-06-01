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

		

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string tendn = txtTK.Text;
			string mk = txtMK.Text;
			if (TaiKhoanBLL.KTTK(tendn, mk) == true)
			{
				frmMain f = new frmMain();
				f.Show();
				MessageBox.Show("Đăng nhập thành công");
				this.Hide();
			}
			else
				MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");

			
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

		private void frmDN_Load(object sender, EventArgs e)
		{
			txtTK.Focus();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult h = MessageBox.Show
				("Bạn có chắc muốn thoát không?", "Thông báo !", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}

		private void chkHienMK_CheckedChanged(object sender, EventArgs e)
		{
			if (chkHienMK.Checked == true)
			{
				txtMK.Show();
			}
		}

		private void chkHienMK_Click(object sender, EventArgs e)
		{
			//if()
			//if (txtMK.PasswordChar == '*')
			//{
			//	txtMK.PasswordChar = '\0';
			//}
		}
	}
}
