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
	}
}
