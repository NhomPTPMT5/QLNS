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
	//private int hesoluong;
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
					nvdto.Mapb = row.MaPB;
					nvdto.Mahd = row.MaHD;
					nvdto.Hesoluong = row.HeSoLuong;
					nvdto.Tennv = row.TenNV;
					nvdto.Gioitinh = row.GioiTinh;
					//nvdto.Ngaysinh = row.NgaySinh;
					nvdto.Socm = row.SoCM;
					nvdto.Dienthoai = row.DienThoai;
					dsNhanVien.Add(nvdto);
				}

				return dsNhanVien;
			}
		}
	}
}
