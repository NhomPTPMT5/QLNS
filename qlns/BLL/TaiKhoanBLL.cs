using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
	public class TaiKhoanBLL
	{
		//public static string quyen;
		public void DangNhap(string TenDN, string MK)
		{
		}
		//public static List<TaiKhoanDTO> LoadTK()
		//{
		//	List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		var taikhoans = from tk in qlns.Taikhoans
		//						select tk.TenQuyenHan;			
		//		return dsTaiKhoan;
		//	}
		//}
		public static bool Quyen()
		{
			QLNSDataContext qlns = new QLNSDataContext();
			var taikhoans = from tk in qlns.Taikhoans
							select tk.TenQuyenHan;
			if (taikhoans.Equals("true"))
				return true;
			else
				return false;
		}
		//public TaiKhoanBLL(string tendn, string mk, string quyen)
		//{
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		TaiKhoanDTO tkdto = new TaiKhoanDTO();
		//		tkdto.TenDN = tendn;
		//		tkdto.MK = mk;
		//		tkdto.Quyen = quyen;
		//	}
		//}


		public static bool KTTK(string tendn, string mk)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var taikhoans = from tk in qlns.Taikhoans
								where tk.TenDangNhap == tendn && tk.MatKhau == mk
								select tk;
				if (taikhoans.Any())		
					return true;				
				else
					return false;
			}
		}

		public static List<TaiKhoanDTO> LoadTK(string manv, string tendn, string mk, string quyen)
		{
			return DAL.TKDAL.LoadTK();
		}
	}
}
