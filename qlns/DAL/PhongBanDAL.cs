using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public class PhongBanDAL
	{
		public static List<PhongBanDTO> loadcboPB()
		{
			List<PhongBanDTO> dsPhongBan = new List<PhongBanDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var phongbans = from pb in qlns.PhongBans
								select new
								{ pb.MaPB };
				foreach (var r in phongbans)
				{
					PhongBanDTO pbdto = new PhongBanDTO();
					pbdto.MaPB = r.MaPB;
					dsPhongBan.Add(pbdto);
				}
				return dsPhongBan;
			}
		}

		public static List<PhongBanDTO> loadPB()
		{
			List<PhongBanDTO> dsPhongBan = new List<PhongBanDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var phongbans = from pb in qlns.PhongBans
								select pb;
								
				foreach (var r in phongbans)
				{
					PhongBanDTO pbdto = new PhongBanDTO();
					pbdto.MaPB = r.MaPB;
					pbdto.TenPB = r.TenPB;
					dsPhongBan.Add(pbdto);
				}
				return dsPhongBan;
			}
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
