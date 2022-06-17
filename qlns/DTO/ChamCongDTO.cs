using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChamCongDTO
	{
		private string machamcong;
		private string tendn;
		private int ngay;
		private int thang;
		private int nam;
		private bool check;

		public string Machamcong { get => machamcong; set => machamcong = value; }
		public string Tendn { get => tendn; set => tendn = value; }
	
		public bool Check { get => check; set => check = value; }
		public int Ngay { get => ngay; set => ngay = value; }
		public int Thang { get => thang; set => thang = value; }
		public int Nam { get => nam; set => nam = value; }
	}
}
