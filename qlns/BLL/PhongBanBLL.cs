using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
	public class PhongBanBLL
	{
		public static List<PhongBanDTO> LoadcboPB()
		{
			return DAL.PhongBanDAL.loadcboPB();
		}

		public static List<PhongBanDTO> LoadPB()
		{
			return DAL.PhongBanDAL.loadPB();
		}


		public static void insertPB(string mapb, string tenpb)
		{
			PhongBanDAL.insertPB(mapb, tenpb);
		}

		public static void deletePB(string mapb)
		{
			PhongBanDAL.deletePB(mapb);
		}

		public static void updatePB(string mapb, string tenpb)
		{
			PhongBanDAL.updatePB(mapb,tenpb);
		}


	}
}
