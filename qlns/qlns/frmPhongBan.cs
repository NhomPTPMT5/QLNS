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
	public partial class frmPhongBan : Form
	{
		public frmPhongBan()
		{
			InitializeComponent();
		}

		private void frmPhongBan_Load(object sender, EventArgs e)
		{
			List<PhongBanDTO> dsPhongBan = BLL.PhongBanBLL.LoadPB();
			dgvPhongBan.DataSource = dsPhongBan;

			List<PhongBanDTO> dscboPhongBan = BLL.PhongBanBLL.LoadcboPB();
			cboPhongBan.DisplayMember = "TenPB";
			cboPhongBan.DataSource = dscboPhongBan;
		}
	}
}
