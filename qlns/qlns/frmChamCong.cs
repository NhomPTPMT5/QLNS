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
	public partial class frmChamCong : Form
	{
		public frmChamCong(string username)
		{
			InitializeComponent();
			this._user = username;
		}

		private string _user;
		private List<ChamCongDTO> list;

		void LoadCheck(string _user)
		{
			flowLayoutPanel.Controls.Clear();
			var d = new DateTime();
			dtpCC.Format = DateTimePickerFormat.Custom;
			dtpCC.CustomFormat = "dd-MM-yyyy";
			int day = d.GetLastDayOfMonth(dtpCC.Value).Day;
			int dem = 0;
			for (int i = 1; i <= day; i++)
			{
				
				CheckBox ck = new CheckBox();
				ck.Name = $"Day{i}";
				ck.Text = $"Ngày {i}";
				flowLayoutPanel.Controls.Add(ck);

				if (_user.Equals("admin"))
				{
					ck.Enabled = true;
					if (i == dtpCC.Value.Day)
					{
						ck.Checked = true;
					}
					foreach (ChamCongDTO item in list)
					{
						if (dtpCC.Value.Year == item.Nam)
						{
							if (dtpCC.Value.Month == item.Thang)
							{
								if (i == item.Ngay)
									ck.Checked = item.Check = true;
							}
						}		
					}
					if (ck.Checked)
					{
						dem += 1;
						//dtpCC.MaxDate = DateTime.Now;
					}
				}
				else
				{
					dtpCC.Enabled = false;
					ck.Enabled = false;
					if (i == dtpCC.Value.Day) ck.Checked = true;
					foreach (ChamCongDTO item in list)
					{
						if (dtpCC.Value.Year == item.Nam)
						{
							if (dtpCC.Value.Month == item.Thang)
							{
								if (i == item.Ngay)
									ck.Checked = item.Check = true;
							}
						}
					}		
					if (ck.Checked) dem += 1;	
					
				}
			}
			lbsnl.Text = string.Format("So ngay di lam :{0}", dem);
		}

		private void frmChamCong_Load(object sender, EventArgs e)
		{
			//int ngay = dtpCC.Value.Day;
			//int thang = dtpCC.Value.Month;
			//int nam = dtpCC.Value.Year;
			list = ChamCongBLL.loadcc(_user);

			LoadCheck(_user);
			if (_user.Equals("admin"))
				dgvChamCong.DataSource = NhanVienBLL.LoadNV();
			else
				dgvChamCong.Visible = false;
		}

		private void dtpCC_ValueChanged(object sender, EventArgs e)
		{
			LoadCheck(_user);
		}

		public bool chked = false;
		//private void btnLuu_Click(object sender, EventArgs e)
		//{
		//	CheckBox ck = new CheckBox();
			
		//	string tendn = _user;
		//	int ngay = dtpCC.Value.Day;
		//	int thang = dtpCC.Value.Month;
		//	int nam = dtpCC.Value.Year;
		//	if (ck.Checked == true)
		//	{
		//		chked = false;
		//	}
		//	if (ck.Checked == false)
		//	{
		//		chked = true;
		//	}
		//	ChamCongBLL.luu(tendn, ngay, thang, nam, chked);
		//	list = ChamCongBLL.loadChamCong(_user);
		//	MessageBox.Show("thành công !");
		//}

		private void dgvChamCong_Click(object sender, EventArgs e)
		{
			var s = dgvChamCong.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
		}

		private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			CheckBox ck = new CheckBox();

			string tendn = _user;
			int ngay = dtpCC.Value.Day;
			int thang = dtpCC.Value.Month;
			int nam = dtpCC.Value.Year;
			if (ck.Checked == true)
			{
				chked = false;
			}
			if (ck.Checked == false)
			{
				chked = true;
			}
			ChamCongBLL.luu(tendn, ngay, thang, nam, chked);
			list = ChamCongBLL.loadChamCong(_user);
			MessageBox.Show("thành công !");
		}
	}
}
