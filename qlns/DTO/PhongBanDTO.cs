using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhongBanDTO
	{
		private string maPB;
		private string tenPB;

		public string MaPB { get => maPB; set => maPB = value; }
		public string TenPB { get => tenPB; set => tenPB = value; }

		public PhongBanDTO()
		{ }
	}
}
