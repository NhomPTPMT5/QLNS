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
	public partial class frmNhanVien : Form
	{
		public frmNhanVien()
		{
			InitializeComponent();
		}

		Nhanvien nv = new Nhanvien();

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			dgvNhanVien.DataSource = nv.LoadData();
		}
	}
}
