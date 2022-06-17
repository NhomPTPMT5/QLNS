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
		public frmChamCong(string type)
		{			
			InitializeComponent();
			this._user = type;	
		}
		
		private string _user;


		void LoadData(string _user)
		{
			flowLayoutPanel.Controls.Clear();
			var d = new DateTime();
			int day = d.GetLastDayOfMonth(dtpCC.Value).Day;
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
				}
			}
		}

		private void frmChamCong_Load(object sender, EventArgs e)
		{
			LoadData(_user);
		}

		private void dtpCC_ValueChanged(object sender, EventArgs e)
		{
			LoadData(_user);
		}
	}
}
