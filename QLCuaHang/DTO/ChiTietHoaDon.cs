using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class ChiTietHoaDon
    {
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietHoaDon()
        {
            
        }

        public ChiTietHoaDon(int maHD, int maSP, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }
        
        public ChiTietHoaDon(DataRow row)
        {
            MaHD = Convert.ToInt32(row["MaHD"]);
            MaSP = Convert.ToInt32(row["MaSP"]);
            SoLuong = Convert.ToInt32(row["SoLuong"]);
            DonGia = Convert.ToDecimal(row["DonGiaBan"]);
            ThanhTien = Convert.ToDecimal(row["ThanhTien"]);
        }
    }
}
