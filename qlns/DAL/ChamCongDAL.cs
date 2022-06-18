using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public class ChamCongDAL
	{
		public static void saveCC(bool check)
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				ChamCong c = new ChamCong();
				

				qlns.ChamCongs.InsertOnSubmit(c);
				qlns.SubmitChanges();
			}
		}



		public static List<ChamCongDTO> loadChamCong(string _user)
		{
			List<ChamCongDTO> dschamcong = new List<ChamCongDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var chamcongs = from cc in qlns.ChamCongs
								join tk in qlns.Taikhoans
								on cc.TenDangNhap equals tk.TenDangNhap 
								where tk.TenQuyenHan == _user
								select new 
								{
									cc.MaChamCong,
									tk.TenDangNhap,
									cc.Ngay,
									cc.Thang,
									cc.Nam,
									cc.checks
								};
				foreach (var r in chamcongs)
				{
					ChamCongDTO c = new ChamCongDTO(r.MaChamCong, r.TenDangNhap, (int)r.Ngay, (int)r.Thang, (int)r.Nam, (bool)r.checks);
					dschamcong.Add(c);
				}
			}
			return dschamcong;
		}

		public static void luu(string tendn, int ngay, int thang, int nam, bool check )
		{
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				ChamCong cc = new ChamCong();
				cc.TenDangNhap = tendn;
				cc.Ngay = ngay;
				cc.Thang = thang;
				cc.Nam = nam;
				cc.checks = check;
				qlns.ChamCongs.InsertOnSubmit(cc);
				qlns.SubmitChanges();
			}
		}

		public static List<ChamCongDTO> loadcc(string _user)
		{
			List<ChamCongDTO> dschamcong = new List<ChamCongDTO>();
			using (QLNSDataContext qlns = new QLNSDataContext())
			{
				var chamcongs = from cc in qlns.ChamCongs
								join tk in qlns.Taikhoans
								on cc.TenDangNhap equals tk.TenDangNhap
								where tk.TenDangNhap == _user
								select new
								{
									cc.MaChamCong,
									tk.TenDangNhap,
									cc.Ngay,
									cc.Thang,
									cc.Nam,
									cc.checks
								};
				foreach (var r in chamcongs)
				{
					ChamCongDTO c = new ChamCongDTO();
					c.Machamcong = r.MaChamCong;
					c.Tendn = r.TenDangNhap;
					c.Ngay = (int)r.Ngay;
					c.Thang = (int)r.Thang;
					c.Nam = (int)r.Nam;
					c.Check = (bool)r.checks;
					dschamcong.Add(c);
				}
			}
			return dschamcong;
		}
	}
}
