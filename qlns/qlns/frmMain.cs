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

namespace qlns
{
	public partial class frmMain : Form
	{
		public Form currentChildForm;
		public frmMain()
		{
			InitializeComponent();
		}

		NhanVienBLL nvbll = new NhanVienBLL();

		public void OpenChildForm(Form childFrom)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childFrom;
			childFrom.TopLevel = false;
			childFrom.Dock = DockStyle.Fill;
			childFrom.FormBorderStyle = FormBorderStyle.None;
			pnBody.Controls.Add(childFrom);
			pnBody.Tag = childFrom;
			childFrom.BringToFront();
			childFrom.Show();
		}

		//private void (object sender, EventArgs e)
		//{
		//	DialogResult h = MessageBox.Show
		//		("Bạn có chắc muốn thoát không?", "Thông báo !", MessageBoxButtons.OKCancel);
		//	if (h == DialogResult.OK)
		//		Application.Exit();
		//}


		private void ibtnThem_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmUser());
			label1.Text = btnUser.Text;
		}

		private void ibtnXoa_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmNhanVien());
			label1.Text = btnNhanVien.Text;
		}

		private void ibtnCapNhat_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmPhongBan());
			label1.Text = btnPhongBan.Text;
		}


		private void ibtnChamCong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmChamCong());
			label1.Text = btnChamCong.Text;
		}

		private void ibtnKhenThuong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmKhenThuong());
			label1.Text = btnKhenThuong.Text;
		}

		private void ibtnThoat_Click(object sender, EventArgs e)
		{
			DialogResult h = MessageBox.Show
				("Bạn có chắc muốn thoát không?", "Thông báo !", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
				label1.Text = "Home";
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
		
		}
	}
}
