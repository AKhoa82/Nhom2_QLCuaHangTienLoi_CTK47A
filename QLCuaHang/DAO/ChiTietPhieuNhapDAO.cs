using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLCuaHang.DTO;

namespace QLCuaHang.DAO
{
	public class ChiTietPhieuNhapDAO
	{
		private static ChiTietPhieuNhapDAO _instance;

		public static ChiTietPhieuNhapDAO Instance
		{
			get
			{
				if (_instance == null)
					_instance = new ChiTietPhieuNhapDAO();
				return _instance;
			}
		}

		private ChiTietPhieuNhapDAO() { }

		public int InsertChiTietPhieuNhap(int maPN, int maSP, int soLuong, decimal donGia)
		{
			string procName = "ChiTietPhieuNhap_Insert";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaPN", maPN),
				new SqlParameter("@MaSP", maSP),
				new SqlParameter("@SoLuong", soLuong),
				new SqlParameter("@DonGia", donGia)
			};

			return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters);
		}

		public void DeleteAllDetailsOfPhieuNhap(int maPN)
		{
			string selectQuery = "select MaSP from ChiTietPhieuNhap where MaPN=@MaPN";
			DataTable data = DataProvider.Instance.ExecuteQuery(selectQuery, new SqlParameter("@MaPN", maPN));
			foreach (DataRow row in data.Rows)
			{
				int maSP = Convert.ToInt32(row["MaSP"]);
				DataProvider.Instance.ExecuteNonQueryStoredProcedure(
					"ChiTietPhieuNhap_Delete",
					new SqlParameter("@MaPN", maPN),
					new SqlParameter("@MaSP", maSP)
				);
			}
		}

		public List<ChiTietPhieuNhapItem> GetChiTietByMaPN(int maPN)
		{
			// Lấy chi tiết kèm tên sản phẩm để hiển thị
			string query = @"select ctpn.MaPN, ctpn.MaSP, sp.TenSP, ctpn.SoLuong, ctpn.DonGia
						 from ChiTietPhieuNhap ctpn
						 left join SanPham sp on ctpn.MaSP = sp.MaSP
						 where ctpn.MaPN = @MaPN";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new SqlParameter("@MaPN", maPN));
			var result = new List<ChiTietPhieuNhapItem>();
			foreach (DataRow row in data.Rows)
				result.Add(new ChiTietPhieuNhapItem(row));
			return result;
		}
	}
}


