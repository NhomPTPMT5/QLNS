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
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				PhongBan pb = new PhongBan();
				pb.MaPB = mapb;
				pb.TenPB = tenpb;
				qlns.PhongBans.InsertOnSubmit(pb);
				qlns.SubmitChanges();

							

			}
		}

		public static void deletePB(string mapb)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var phongbans = (from pb1 in qlns.PhongBans
								 where pb1.MaPB == mapb
								 select pb1).FirstOrDefault();

				qlns.PhongBans.DeleteOnSubmit(phongbans);
				qlns.SubmitChanges();
			}
		}

		public static void updatePB(string mapb, string tenpb)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var phongbans = (from pb1 in qlns.PhongBans
						   where pb1.MaPB == mapb
						   select pb1).FirstOrDefault();

				phongbans.MaPB = mapb;
				phongbans.TenPB = tenpb;

				qlns.SubmitChanges();
			}
		}


	}
}
