using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TaiKhoanDTO
	{
		private string tenDN;
		private string mK;

		public string TenDN { get => tenDN; set => tenDN = value; }
		public string MK { get => mK; set => mK = value; }

		public TaiKhoanDTO() { }
	}
}
