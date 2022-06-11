using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
namespace DTO
{
	public class TaiKhoanDTO
	{
		private string maNV;
		private string tenDN;
		private string mK;
		private string quyen;
		public string MaNV { get => maNV; set => maNV = value; }
		public string TenDN { get => tenDN; set => tenDN = value; }
		public string MK { get => mK; set => mK = value; }
		public string Quyen { get => quyen; set => quyen = value; }

		//public TaiKhoanDTO() { }


	}
}
