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

		public static void insertNV(string manv, string tenpb, string hesl, string tennv, string gt, string ns, string dt)
		{
			 DAL.NhanVienDAL.insertNV(manv,tenpb,hesl,tennv,gt,ns,dt);
		}
	}

	
}
