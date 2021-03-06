using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
	public static class ChamCongBLL
	{

		public static List<TaiKhoanDTO> LoadTK(string username)
		{
			return ChamCongDAL.LoadTK(username);
		}

		public static List<ChamCongDTO> loadcc(string _user)
		{
			return ChamCongDAL.loadcc(_user);
		}

		public static void luu( string tendn, int ngay, int thang, int nam, bool check)
		{
			ChamCongDAL.luu( tendn, ngay, thang, nam, check);
		}

		/// <summary>
		/// Lấy ra ngày cuối cùng trong tháng có chứa 
		/// 1 ngày bất kỳ được truyền vào
		/// </summary>
		/// <param name="dtInput">Ngày nhập vào</param>
		/// <returns>Ngày cuối cùng trong tháng</returns>
		public static DateTime GetLastDayOfMonth(this DateTime d, DateTime dtInput)
		{
			DateTime dtResult = dtInput;
			dtResult = dtResult.AddMonths(1);
			dtResult = dtResult.AddDays(-(dtResult.Day));
			return dtResult;

		}
		/// <summary>
		/// Lấy ra ngày cuối cùng trong tháng được truyền vào
		/// là 1 số nguyên từ 1 đến 12
		/// </summary>
		/// <param name="iMonth"></param>
		/// <returns></returns>
		public static DateTime GetLastDayOfMonth(this DateTime d, int iMonth)
		{
			DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
			dtResult = dtResult.AddMonths(1);
			dtResult = dtResult.AddDays(-(dtResult.Day));
			return dtResult;
		}
		/// <summary>
		/// Lấy ra ngày đầu tiên trong tháng có chứa 
		/// 1 ngày bất kỳ được truyền vào
		/// </summary>
		/// <param name="dtDate">Ngày nhập vào</param>
		/// <returns>Ngày đầu tiên trong tháng</returns>
		public static DateTime GetFirstDayOfMonth(this DateTime d, DateTime dtInput)
		{
			d = dtInput;
			d = d.AddDays((-d.Day) + 1);
			return d;
		}
		/// <summary>
		/// Lấy ra ngày đầu tiên trong tháng được truyền vào 
		/// là 1 số nguyên từ 1 đến 12
		/// </summary>
		/// <param name="iMonth">Thứ tự của tháng trong năm</param>
		/// <returns>Ngày đầu tiên trong tháng</returns>
		public static DateTime GetFirstDayOfMonth(this DateTime d, int iMonth)
		{
			d = new DateTime(DateTime.Now.Year, iMonth, 1);
			d = d.AddDays((-d.Day) + 1);
			return d;
		}
	}
}
