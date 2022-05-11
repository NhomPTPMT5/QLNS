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
		public frmMain()
		{
			InitializeComponent();
		}

		private void iconButton6_Click(object sender, EventArgs e)
		{
			DialogResult h = MessageBox.Show
				("Bạn có chắc muốn thoát không?", "Thông báo !", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}
	}
}
