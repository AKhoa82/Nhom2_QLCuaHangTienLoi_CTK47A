using System;
using System.Data;

namespace QLCuaHang.DTO
{
	public class ChiTietPhieuNhapItem
	{
		public int MaPN { get; set; }
		public int MaSP { get; set; }
		public string TenSP { get; set; }
		public int SoLuong { get; set; }
		public decimal DonGia { get; set; }

		public ChiTietPhieuNhapItem() { }

		public ChiTietPhieuNhapItem(DataRow row)
		{
			MaPN = Convert.ToInt32(row["MaPN"]);
			MaSP = Convert.ToInt32(row["MaSP"]);
			TenSP = row.Table.Columns.Contains("TenSP") ? Convert.ToString(row["TenSP"]) : string.Empty;
			SoLuong = row.Table.Columns.Contains("SoLuong") ? Convert.ToInt32(row["SoLuong"]) : 0;
			DonGia = row.Table.Columns.Contains("DonGia") ? Convert.ToDecimal(row["DonGia"]) : 0m;
		}
	}
}


