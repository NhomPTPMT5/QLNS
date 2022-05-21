﻿using System;
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

		public static void insertNV(string manv, string tennv, string tenpb, string hesl, string gt, string ns, string dt)
		{
			 DAL.NhanVienDAL.insertNV(manv,tenpb,hesl,tennv,gt,ns,dt);
		}

		public static void deleteNV(string manv)
		{
			DAL.NhanVienDAL.deleteNV(manv);
		}

		public static void updateNV(string manv, string tennv, string tenpb, string hesl, string gt, string ns, string dt)
		{
			DAL.NhanVienDAL.updateNV(manv, tenpb, hesl, tennv, gt, ns, dt);
		}
	}

	
}
