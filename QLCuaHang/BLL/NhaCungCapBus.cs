using System.Collections.Generic;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
	public class NhaCungCapBus
	{
		public List<NhaCungCap> LayTatCa()
		{
			return NhaCungCapDAO.Instance.GetAllNhaCungCap();
		}

		public bool ThemNhaCungCap(string ten, string sdt, string diaChi)
		{
			return NhaCungCapDAO.Instance.InsertNhaCungCap(ten, sdt, diaChi);
		}
	}
}


