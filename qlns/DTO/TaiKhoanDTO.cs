using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TaiKhoanDTO
	{
		private string maNV;
		private string tenDN;
		private string mK;
		private string quyen;
		public string TenDN { get => tenDN; set => tenDN = value; }
		public string MK { get => mK; set => mK = value; }
		public string Quyen { get => quyen; set => quyen = value; }
		public string MaNV { get => maNV; set => maNV = value; }

		public TaiKhoanDTO() { }

		
	}
}
