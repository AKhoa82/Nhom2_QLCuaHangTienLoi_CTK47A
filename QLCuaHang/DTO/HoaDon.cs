using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class HoaDon
    {
        public int MaHD {  get; set; }
        public DateTime NgayLap {  get; set; }
        public string AccountName { get; set; }
        public int? MaKH {  get; set; }
        public decimal TongTien {  get; set; }
        public int GiamGia {  get; set; }
        public decimal ThanhToan {  get; set; }

        public HoaDon()
        {
            
        }

        public HoaDon(int maHD, DateTime ngayLap, string accountName, int maKH, decimal tongTien, int giamGia, decimal thanhToan)
        {
            this.MaHD = maHD;
            this.NgayLap = ngayLap;
            this.AccountName = accountName;
            this.MaKH = maKH;
            this.TongTien = tongTien;
            this.GiamGia = giamGia;
            this.ThanhToan = thanhToan;
        }

        public HoaDon(DataRow row)
        {
            MaHD = Convert.ToInt32(row["MaHD"]);
            NgayLap = Convert.ToDateTime(row["NgayLap"]);
            AccountName = row["AccountName"].ToString();
            MaKH = row["MaKH"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["MaKH"]);
            TongTien = Convert.ToDecimal(row["TongTien"]);
            GiamGia = Convert.ToInt32(row["GiamGia"]);
            ThanhToan = Convert.ToDecimal(row["ThanhToan"]);
        }
    }
}
