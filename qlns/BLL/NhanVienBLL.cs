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

		public static void insertNV(string manv, string tenpb, string mahd, string hesl, string tennv, string gt, string ns, string socm, string dt)
		{
			 DAL.NhanVienDAL.insertNV(manv,tenpb,mahd,hesl,tennv,gt,ns,socm,dt);
		}
	}

	
}
