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
	public partial class frmUser : Form
	{
		public frmUser()
		{
			InitializeComponent();
		}

		private void frmUser_Load(object sender, EventArgs e)
		{
			//List<TaiKhoanDTO> dstk = BLL.TaiKhoanBLL.LayQ();
			//dgvUser.DataSource = dstk;
		}

		private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
