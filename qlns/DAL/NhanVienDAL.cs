using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	//private string manhanvien;
	//private string mapb;
	//private string mahd;
	//private string hesoluong;
	//private string tennv;
	//private string gioitinh;
	//private string ngaysinh;
	//private string socm;
	//private string dienthoai;
	public class NhanVienDAL
	{
		public static List<NhanVienDTO> LoadNV()
		{
			List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var nhanviens = from nv in qlns.NhanViens
								select nv;
				foreach (var row in nhanviens)
				{
					NhanVienDTO nvdto = new NhanVienDTO();
					nvdto.Manhanvien = row.MaNhanVien;
					nvdto.Tenpb = row.TenPB;
					nvdto.Hesoluong = row.HeSoLuong;
					nvdto.Tennv = row.TenNV;
					nvdto.Gioitinh = row.GioiTinh;
					nvdto.Ngaysinh = row.NgaySinh;
					
					nvdto.Dienthoai = row.DienThoai;
					dsNhanVien.Add(nvdto);
				}

				return dsNhanVien;
			}
		}

		public static void insertNV(string manv, string tennv, string tenpb, string hesl, string gt, string ns, string dt)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				NhanVien nv = new NhanVien();
				nv.MaNhanVien = manv;
				nv.TenPB = tenpb;		
				nv.HeSoLuong = hesl;
				nv.TenNV = tennv;
				nv.GioiTinh = gt;
				nv.NgaySinh = ns;
				nv.DienThoai = dt;

				qlns.NhanViens.InsertOnSubmit(nv);
				qlns.SubmitChanges();

				var nhanviens = from nv1 in qlns.NhanViens
								select nv1;

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

		public static void updateNV(string manv, string tennv, string tenpb, string hesl, string gt, string ns, string dt)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var nvs = (from nv1 in qlns.NhanViens
								 where nv1.MaNhanVien == manv
								 select nv1).FirstOrDefault();

				nvs.MaNhanVien = manv;
				nvs.TenNV = tennv;
				nvs.TenPB = tenpb;
				nvs.HeSoLuong = hesl;
				nvs.GioiTinh = gt;
				nvs.NgaySinh = ns;
				nvs.DienThoai = dt;

				qlns.SubmitChanges();
			}
		}
	}
}
