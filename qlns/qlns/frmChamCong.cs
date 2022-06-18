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
					ck.Enabled = true;
				else
				{
					dtpCC.Enabled = false;
					ck.Enabled = false;
					if (i == dtpCC.Value.Day) ck.Enabled = true;
					foreach (ChamCongDTO item in list)
					{
						if (dtpCC.Value.Month == item.Thang)
						{
							if (i == item.Ngay)
								ck.Checked = item.Check;
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
			list = ChamCongBLL.loadChamCong(_user);

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

		private void btnLuu_Click(object sender, EventArgs e)
		{


		}

		private void dgvChamCong_Click(object sender, EventArgs e)
		{
			//var s = dgvChamCong.SelectedRows[0].Cells["Tendn"].Value.ToString();
		}
	}
}
