using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
	public class NhanVienBLL
	{


		public static List<NhanVienDTO> LoadNV()
		{
			return DAL.NhanVienDAL.LoadNV();
		}

		//public static void insertNV(string manv, string tennv, string mapb, string hesl, string gt, string ns, string dt)
		//{
		//	DAL.NhanVienDAL.insertNV(manv, tennv, mapb, hesl, gt, ns, dt);
		//}

		//public static void deleteNV(string manv)
		//{
		//	DAL.NhanVienDAL.deleteNV(manv);
		//}

		//public static void updateNV(string manv, string tennv, string mapb, string hesl, string gt, string ns, string dt)
		//{
		//	DAL.NhanVienDAL.updateNV(manv, tennv, mapb, hesl, gt, ns, dt);
		//}


		public static void insertNV(string manv, string tennv, string mapb, string hesl, string gt, string ns, string dt)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				
				
					NhanVien nv = new NhanVien();
					nv.MaNhanVien = manv;
					nv.TenNV = tennv;
					nv.MaPB = mapb;
					nv.HeSoLuong = hesl;
					nv.GioiTinh = gt;
					nv.NgaySinh = ns;
					nv.DienThoai = dt;

					qlns.NhanViens.InsertOnSubmit(nv);
					qlns.SubmitChanges();
					
				
				

				//var nhanviens = from nv1 in qlns.NhanViens
				//				select nv1;

			}
		}

		public static void deleteNV(string manv)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var nhanviens = (from nv in qlns.NhanViens
								 where nv.MaNhanVien == manv
								 select nv).FirstOrDefault();

				qlns.NhanViens.DeleteOnSubmit(nhanviens);
				qlns.SubmitChanges();
			}
		}

		public static void updateNV(string manv, string tennv, string mapb, string hesl, string gt, string ns, string dt)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var nvs = (from nv1 in qlns.NhanViens
						   where nv1.MaNhanVien == manv
						   select nv1).FirstOrDefault();

				nvs.MaNhanVien = manv;
				nvs.TenNV = tennv;
				nvs.MaPB = mapb;
				nvs.HeSoLuong = hesl;
				nvs.GioiTinh = gt;
				nvs.NgaySinh = ns;
				nvs.DienThoai = dt;

				qlns.SubmitChanges();
			}
		}


	}

	
}
