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
		private string tennv;
		private string mapb;
		//private string mahd;
		private string luongcb;

		private string gioitinh;
		//private string ngaysinh;
		//private string socm;
		private string ngaysinh;
		private string dienthoai;


		public string Manhanvien { get => manhanvien; set => manhanvien = value; }
		public string Tennv { get => tennv; set => tennv = value; }
		public string Mapb { get => mapb; set => mapb = value; }
		public string Luongcb { get => luongcb; set => luongcb = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
		public string Dienthoai { get => dienthoai; set => dienthoai = value; }

		public NhanVienDTO() { }
		//public NhanVienDTO(string manv1, string mapb1, string mahd1, int hesoluong1, string tennv1, string gioitinh1, string socm1, string dienthoai1)
		//{
		//	this.Manhanvien = manv1;
		//	this.Mapb = mapb1;
		//	this.Mahd = mahd1;
		//	this.Hesoluong = hesoluong1;
		//	this.Tennv = tennv1;
		//	this.Gioitinh = gioitinh1;
		//	this.Socm = socm1;
		//	this.Gioitinh = gioitinh1;
		//}
	}
}
