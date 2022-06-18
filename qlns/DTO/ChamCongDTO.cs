using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChamCongDTO
	{
		private int machamcong;
		private string tendn;
		private int ngay;
		private int thang;
		private int nam;
		private bool check;

		public int Machamcong { get => machamcong; set => machamcong = value; }
		public string Tendn { get => tendn; set => tendn = value; }
	
		public bool Check { get => check; set => check = value; }
		public int Ngay { get => ngay; set => ngay = value; }
		public int Thang { get => thang; set => thang = value; }
		public int Nam { get => nam; set => nam = value; }
		public ChamCongDTO(int _id, string _tendn, int _ngay, int _thang, int _nam, bool _check)
		{
			this.Machamcong = _id;this.Tendn = _tendn;this.Ngay = _ngay;this.Thang = _thang; this.Nam = _nam; this.Check = _check;
		}
	}
}
