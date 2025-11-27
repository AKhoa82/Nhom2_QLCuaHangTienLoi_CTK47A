using System;
using System.Collections.Generic;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
	public class PhieuNhapBus
	{
		public List<PhieuNhap> LayTatCaKemTongHop()
		{
			return PhieuNhapDAO.Instance.GetAllPhieuNhapWithDetails();
		}

	public int TaoPhieuNhap(DateTime ngayNhap, string accountName, int maNCC)
	{
		return PhieuNhapDAO.Instance.InsertPhieuNhap(ngayNhap, accountName, maNCC);
	}

		public void TaoChiTiet(int maPN, int maSP, int soLuong, decimal donGia)
		{
			ChiTietPhieuNhapDAO.Instance.InsertChiTietPhieuNhap(maPN, maSP, soLuong, donGia);
		}

	public bool CapNhatPhieuNhap(int maPN, DateTime ngayNhap, string accountName, int maNCC)
	{
		return PhieuNhapDAO.Instance.UpdatePhieuNhap(maPN, ngayNhap, accountName, maNCC) > 0;
	}

		public bool XoaPhieuNhap(int maPN)
		{
			// Xóa chi tiết trước, sau đó xóa header
			ChiTietPhieuNhapDAO.Instance.DeleteAllDetailsOfPhieuNhap(maPN);
			return PhieuNhapDAO.Instance.DeletePhieuNhap(maPN) > 0;
		}

		public List<ChiTietPhieuNhapItem> LayChiTiet(int maPN)
		{
			return ChiTietPhieuNhapDAO.Instance.GetChiTietByMaPN(maPN);
		}
	}
}


