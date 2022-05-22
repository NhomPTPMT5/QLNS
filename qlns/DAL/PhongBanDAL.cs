﻿using System;
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



	}
}
