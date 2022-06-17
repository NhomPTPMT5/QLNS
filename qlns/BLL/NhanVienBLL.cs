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


		public static void insertNV(string manv, string tennv, string mapb, string gt, string ns, string dt)
		{
			NhanVienDAL.insertNV(manv, tennv, mapb, gt, ns, dt);
		}

		public static void deleteNV(string manv)
		{
			NhanVienDAL.deleteNV(manv);
		}

		public static void updateNV(string manv, string tennv, string mapb, string gt, string ns, string dt)
		{
			NhanVienDAL.updateNV(manv, tennv, mapb, gt, ns, dt);
		}

		public static List<NhanVienDTO> loadcboMNV()
		{
			return NhanVienDAL.loadcboMNV();
		}
	}


}
