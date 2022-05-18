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
	}
}
