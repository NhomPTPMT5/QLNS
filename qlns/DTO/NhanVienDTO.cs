using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class NhanVienDTO
	{
		private string manhanvien;
		private string mapb;
		private string mahd;
		private int hesoluong;
		private string tennv;
		private string gioitinh;
		//private string ngaysinh;
		private string socm;
		private string dienthoai;

		public string Manhanvien { get => manhanvien; set => manhanvien = value; }
		public string Mapb { get => mapb; set => mapb = value; }
		public string Mahd { get => mahd; set => mahd = value; }
		public int Hesoluong { get => hesoluong; set => hesoluong = value; }
		public string Tennv { get => tennv; set => tennv = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		//public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
		public string Socm { get => socm; set => socm = value; }
		public string Dienthoai { get => dienthoai; set => dienthoai = value; }
	}
}
