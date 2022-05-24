using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	
	public class NhanVienDAL
	{
		public static List<NhanVienDTO> LoadNV()
		{
			List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var nhanviens = from nv in qlns.NhanViens
								select nv;
				foreach (var row in nhanviens)					//gan du lieu vao de tra ve danh sach nhan vien
				{
					NhanVienDTO nvdto = new NhanVienDTO();
					nvdto.Manhanvien = row.MaNhanVien;
					nvdto.Tennv = row.TenNV;
					nvdto.Mapb = row.MaPB;
					nvdto.Hesoluong = row.HeSoLuong;
					
					nvdto.Gioitinh = row.GioiTinh;
					nvdto.Ngaysinh = row.NgaySinh;
					
					nvdto.Dienthoai = row.DienThoai;
					dsNhanVien.Add(nvdto);
				}

				return dsNhanVien;
			}
		}

		////public static void insertNV(string manv, string tennv, string mapb, string hesl, string gt, string ns, string dt)
		////{
		////	using (QLNSDataContext qlns = new QLNSDataContext())
		////	{
		////		NhanVien nv = new NhanVien();
		////		nv.MaNhanVien = manv;
		////		nv.TenNV = tennv;
		////		nv.MaPB = mapb;		
		////		nv.HeSoLuong = hesl;
		////		nv.GioiTinh = gt;
		////		nv.NgaySinh = ns;
		////		nv.DienThoai = dt;

		////		qlns.NhanViens.InsertOnSubmit(nv);
		////		qlns.SubmitChanges();

		////		//var nhanviens = from nv1 in qlns.NhanViens
		////		//				select nv1;

		////	}
		////}

		//public static void deleteNV(string manv)
		//{
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		var nhanviens = (from nv in qlns.NhanViens
		//						 where nv.MaNhanVien == manv
		//						 select nv).FirstOrDefault();

		//		qlns.NhanViens.DeleteOnSubmit(nhanviens);
		//		qlns.SubmitChanges();
		//	}
		//}

		//public static void updateNV(string manv, string tennv, string mapb, string hesl, string gt, string ns, string dt)
		//{
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		var nvs = (from nv1 in qlns.NhanViens
		//						 where nv1.MaNhanVien == manv
		//						 select nv1).FirstOrDefault();

		//		nvs.MaNhanVien = manv;
		//		nvs.TenNV = tennv;
		//		nvs.MaPB = mapb;
		//		nvs.HeSoLuong = hesl;
		//		nvs.GioiTinh = gt;
		//		nvs.NgaySinh = ns;
		//		nvs.DienThoai = dt;

		//		qlns.SubmitChanges();
		//	}
		//}
	}
}
