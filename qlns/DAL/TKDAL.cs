using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
	public class TKDAL
	{
		public static List<TaiKhoanDTO> LoadTK()
		{
			List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var taikhoans = from tk in qlns.Taikhoans
								select tk;
				foreach (var row in taikhoans)                 
				{
					TaiKhoanDTO tkdto = new TaiKhoanDTO();
					tkdto.MaNV = row.MaNhanVien;
					tkdto.TenDN = row.TenDangNhap;
					tkdto.MK = row.MatKhau;
					tkdto.Quyen = row.TenQuyenHan;
					dsTaiKhoan.Add(tkdto);
				}

				return dsTaiKhoan;
			}
		}
	}
}
