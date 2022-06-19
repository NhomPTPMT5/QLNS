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
	public partial class frmMain : Form
	{
		public Form currentChildForm;

		private  string type;
		private  string username;

		public frmMain(string _type,string _username)
		{
			InitializeComponent();
			this.Type = _type;
			this.Username = _username;
		}

		public string Type { get => type; set => type = value; }
		public string Username { get => username; set => username = value; }

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
			OpenChildForm(new frmChamCong(type,username));
			label1.Text = btnChamCong.Text;
		}

		private void ibtnKhenThuong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmKhenThuong());
			label1.Text = btnKhenThuong.Text;
		}

		private void ibtnThoat_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmDN fm = new frmDN();
			fm.Show();
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
			switch (Type)
			{
				case "admin":
					btnNhanVien.Enabled = btnPhongBan.Enabled =btnUser.Enabled = true;
					break;
				default:
					btnNhanVien.Enabled = btnPhongBan.Enabled = btnUser.Enabled = false;
					break;
			}
		}

		private void pnTitle_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}




		//private void frmMain_Load(object sender, EventArgs e)
		//{
		//	TaiKhoanBLL.Quyen();



		//}
	}
}
