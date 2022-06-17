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
		
		public static List<TaiKhoanDTO> LoadTK()
		{
			return DAL.TKDAL.LoadTK();
		}
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


		public static bool CheckLogin(string _username, string _pass)
		{
			return TKDAL.CheckLogin(_username, _pass);
		}
		public static string TypeUser(string _username, string _pass)
		{
			return TKDAL.TypeUser(_username, _pass);
		}

		public static void insertTK(string manv, string tendn, string mk, string quyen)
		{
			TKDAL.insertTK(manv, tendn, mk, quyen);
		}

		public static void deleteTK(string manv)
		{
			TKDAL.deleteTK(manv);
		}

		public static void updateTK(string manv, string tendn, string mk, string quyen)
		{
			TKDAL.updateTK(manv, tendn, mk, quyen);
		}
	}
}
