using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;


namespace BLL
{
	public class Nhanvien
	{
		QLNSDataContext qlns = new QLNSDataContext();

		public IQueryable<NhanVien> LoadNV()
		{
			var nhanviens = from nv in qlns.NhanViens
							select nv;
			return nhanviens;
		}
		
	}
}
