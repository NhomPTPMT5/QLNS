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
		public static bool CheckLogin(string _username, string _pass)
		{
			return TKDAL.CheckLogin(_username, _pass);
		}
		public static string TypeUser (string _username, string _pass)
		{
			return TKDAL.TypeUser(_username, _pass);
		}
		public static List<TaiKhoanDTO> LoadTK()
		{
			return DAL.TKDAL.LoadTK();
		}

		//public static List<TaiKhoanDTO> LayQ()
		//{
		//	return DAL.TKDAL.layQ();
		//}
		//public static bool Quyen()
		//{
		//	return TKDAL.Quyen();
		//}

		//}

		//public static bool Quyen()
		//{
		//  return DAL.TKDAL.Quyen();
		//}

		//public static int Quyen()
		//{		
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		int q = 0;
		//		var taikhoans = from tk in qlns.Taikhoans
		//						//where tk.QuyenHan == 1
		//						select new { tk.QuyenHan};
		//		foreach (var t in taikhoans)
		//		{
		//			if (t.QuyenHan == 1)
		//				return q = 1;
		//		}
		//		return q;
		//	}

		//}

		//public static bool Quyen()
		//{
		//  return DAL.TKDAL.Quyen();
		//}
		//public static string quyen;

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

		//public static bool KTQ()
		//{
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		bool q = false;
		//		var taikhoans = from tk1 in qlns.Taikhoans
		//						select new { tk1.TenQuyenHan };
		//		if (taikhoans.Equals("admin"))
		//			q = true;
		//		return q;

		//	}
		//}

		//public static bool KTTK(string tendn, string mk, string q)
		//{
		//	bool result = false;
		//	using (QLNSDataContext qlns = new QLNSDataContext())
		//	{
		//		string s;
		//		var taikhoans = from tk in qlns.Taikhoans
		//						where tk.TenDangNhap == tendn && tk.MatKhau == mk && tk.TenQuyenHan == q
		//						select tk;// kiểm tra id và mk đúng thì trả về quyền hạn
		//		taikhoans.ToList().ForEach(o =>
		//		{
		//			s = o.TenQuyenHan;
		//			if (s.Equals("admin"))
		//				result = true;
		//		});
		//	}
		//	return result;
		//}
	}
}
