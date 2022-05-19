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
					nvdto.Mahd = row.MaHD;
					nvdto.Hesoluong = row.HeSoLuong;
					nvdto.Tennv = row.TenNV;
					nvdto.Gioitinh = row.GioiTinh;
					nvdto.Ngaysinh = row.NgaySinh;
					nvdto.Socm = row.SoCM;
					nvdto.Dienthoai = row.DienThoai;
					dsNhanVien.Add(nvdto);
				}

				return dsNhanVien;
			}
		}

		public static void insertNV(string manv, string tenpb, string mahd, string hesl, string tennv, string gt, string ns, string socm, string dt)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				NhanVien nv = new NhanVien();
				nv.MaNhanVien = manv;
				nv.TenPB = tenpb;
				nv.MaHD = mahd;
				nv.HeSoLuong = hesl;
				nv.TenNV = tennv;
				nv.GioiTinh = gt;
				nv.NgaySinh = ns;
				nv.SoCM = socm;
				nv.DienThoai = dt;

				qlns.NhanViens.InsertOnSubmit(nv);
				qlns.SubmitChanges();
			}
		}
	}
}
