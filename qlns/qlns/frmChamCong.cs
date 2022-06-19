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

using System.Windows;

namespace qlns
{
	public partial class frmChamCong : Form
	{
		public frmChamCong(string type, string username)
		{
			InitializeComponent();
			this._type = type;
			this._user = username;
			
		}
		private string _type;
		private string _user;
		private List<ChamCongDTO> list;

		void LoadCheck(string _type)
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

				if (_type.Equals("admin"))
				{
					ck.Enabled = true;
					//if (i ==) dtpCC.Value.Day
					//{
					//	ck.Checked = true;
					//}
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
						//txtLuong.Text = string.Format("{0}", dem * 500000);
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
					//txtLuong.Text = string.Format("{0}", dem * 300000);
				}
				
			}
			lbsnl.Text = string.Format("Số ngày đi làm :{0}", dem);
			
		}

		private void frmChamCong_Load(object sender, EventArgs e)
		{
			list = ChamCongBLL.loadcc(_user);  //load danh sach diem danh theo tendn

			LoadCheck(_type);
			if (_type.Equals("admin"))
				dgvChamCong.DataSource = NhanVienBLL.LoadNV();
			else
				dgvChamCong.Visible = false;
			dgvChamCong.SelectionChanged += DgvChamCong_SelectionChanged;
		}

		private void DgvChamCong_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				string idnhanvien = dgvChamCong.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
				string tendangnhap = TaiKhoanBLL.GetUserNameByMaNV(idnhanvien);
				list = ChamCongBLL.loadcc(tendangnhap);
				LoadCheck(_type);
			}
			catch
			{

			}
		}

		private void dtpCC_ValueChanged(object sender, EventArgs e)
		{
			LoadCheck(_type);
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

		

		

		private void btnSave_Click(object sender, EventArgs e)
		{
			CheckBox ck = new CheckBox();
			try
			{
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
				list = ChamCongBLL.loadcc(_user);
				System.Windows.MessageBox.Show("thành công !");
			}
			catch
			{
				System.Windows.MessageBox.Show(" điểm danh rồi !");
			}
		}

		
	}
}
