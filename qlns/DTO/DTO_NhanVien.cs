using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_NhanVien
	{
		private string maNhanVien;

		public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
		public string MaPB { get => maPB; set => maPB = value; }

		private string maPB;

		public DTO_NhanVien() { }

		public DTO_NhanVien(string manv, string mapb)
		{
			this.MaNhanVien = manv;
			this.MaPB = mapb;
		}
	}
}
