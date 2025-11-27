using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class PhieuNhap
    {
        public int MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string AccountName { get; set; }
        public int MaNCC { get; set; }
        
        
        public string TenNhanVien { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SDT_NCC { get; set; }
        public string DiaChi_NCC { get; set; }
        public int TongSoLuong { get; set; }
        public decimal TongTien { get; set; }

        public PhieuNhap()
        {
            
        }

        public PhieuNhap(int maPN, DateTime ngayNhap, string accountName, int maNCC)
        {
            this.MaPN = maPN;
            this.NgayNhap = ngayNhap;
            this.AccountName = accountName;
            this.MaNCC = maNCC;
        }

        public PhieuNhap(DataRow row)
        {
            this.MaPN = (int)row["MaPN"];
            this.NgayNhap = Convert.ToDateTime(row["NgayNhap"]);
            this.AccountName = row["AccountName"] == DBNull.Value ? "" : row["AccountName"].ToString();
            this.MaNCC = (int)row["MaNCC"];
            
            // Thông tin bổ sung (có thể null)
            this.TenNhanVien = this.AccountName; // Sử dụng AccountName thay vì TenNhanVien
            this.TenNhaCungCap = row["TenNhaCungCap"] == DBNull.Value ? "" : row["TenNhaCungCap"].ToString();
            this.SDT_NCC = row["SDT_NCC"] == DBNull.Value ? "" : row["SDT_NCC"].ToString();
            this.DiaChi_NCC = row["DiaChi_NCC"] == DBNull.Value ? "" : row["DiaChi_NCC"].ToString();
            this.TongSoLuong = row["TongSoLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row["TongSoLuong"]);
            this.TongTien = row["TongTien"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongTien"]);
        }

        public string NgayNhapFormatted
        {
            get
            {
                return NgayNhap.ToString("dd/MM/yyyy");
            }
        }

        
        public string TongTienFormatted
        {
            get
            {
                return TongTien.ToString("N0") + " VNĐ";
            }
        }
    }
}
