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


		public static bool CheckLogin(string _username, string _pass)
		{
			bool result = false;
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				//string s;
				var kq = from acc in qlns.Taikhoans
						 where acc.TenDangNhap == _username && acc.MatKhau == _pass
						 select acc;
				if (kq.Count() > 0)
					result = true;
			}
			return result;
		}
		public static string TypeUser(string _username, string _pass)
		{
			string result = "";
			using (QLNSDataContext qlns = new QLNSDataContext())
			{

				var kq = from acc in qlns.Taikhoans
						 where acc.TenDangNhap == _username && acc.MatKhau == _pass
						 select acc;
				if (kq.Count() > 0)
					kq.ToList().ForEach(o => { result = o.TenQuyenHan; });

			}
			return result;
		}

		//public static List<TaiKhoanDTO> layQ()
		//{

		//	List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		var taikhoans = from tk in qlns.Taikhoans
		//						where tk.TenQuyenHan == "admin"
		//						select new { tk.TenQuyenHan };
		//		foreach (var row in taikhoans)
		//		{
		//			TaiKhoanDTO tkdto = new TaiKhoanDTO();
		//			tkdto.Quyen = row.TenQuyenHan;
		//			dsTaiKhoan.Add(tkdto);
		//		}
		//		return dsTaiKhoan;
		//	}
		//}


		//public static bool Quyen()
		//{
		//	bool q = false;
		//	QLNSDataContext qlns = new QLNSDataContext();
		//	var taikhoans = from tk in qlns.Taikhoans
		//					select new { tk.TenQuyenHan };
		//	foreach (var row in taikhoans)
		//	{
		//		if (row.TenQuyenHan == "admin")
		//			q = true;
		//	}
		//	return q;
		//	//foreach (var row in taikhoans)
		//	//{
		//	//	if (row.TenQuyenHan == "admin")
		//	//		q = true;				
		//	//}
		//	//return q;
		//	//TaiKhoanDTO tkdto = new TaiKhoanDTO();
		//	//tkdto.Quyen = 

		//}
	}
}
