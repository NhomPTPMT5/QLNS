using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlns
{
	public partial class frmMain : Form
	{
		public Form currentChildForm;
		public frmMain()
		{
			InitializeComponent();
		}

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
			OpenChildForm(new frmThem());
			label1.Text = ibtnThem.Text;
		}

		private void ibtnXoa_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmXoa());
			label1.Text = ibtnXoa.Text;
		}

		private void ibtnCapNhat_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmCapNhat());
			label1.Text = ibtnCapNhat.Text;
		}

		private void ibtnLuu_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmLuu());
			label1.Text = ibtnLuu.Text;
		}

		private void ibtnChamCong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmChamCong());
			label1.Text = ibtnChamCong.Text;
		}

		private void ibtnKhenThuong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmKhenThuong());
			label1.Text = ibtnKhenThuong.Text;
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
	}
}
