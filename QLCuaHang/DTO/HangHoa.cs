using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang
{
    public class HangHoa
    {
        public int MaHH {  get; set; }
        public string TenHH {  get; set; }
        public int MaDanhMuc {  get; set; }
        public string DonViTinh {  get; set; }
        public decimal GiaNhap {  get; set; }
        public decimal GiaBan {  get; set; }
        public int SoLuongTon { get; set; }
        public string HinhAnh {get; set; }
        public string TenNCC { get; set; } // Thêm property TenNCC

        public HangHoa()
        {
            
        }
        public HangHoa(int maHH, string tenHH, int maDanhMuc, string donViTinh, decimal giaNhap, decimal giaBan, int soLuongTon, string hinhAnh)
        {
            MaHH = maHH;
            TenHH = tenHH;
            MaDanhMuc = maDanhMuc;
            DonViTinh = donViTinh;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            SoLuongTon = soLuongTon;
            HinhAnh = hinhAnh;
        }
        public HangHoa(DataRow row)
        {
            MaHH = Convert.ToInt32(row["MaSP"]);
            TenHH = row["TenSP"].ToString();
            MaDanhMuc = Convert.ToInt32(row["MaDanhMuc"]);
            DonViTinh = row["DonViTinh"].ToString();
            GiaNhap = Convert.ToDecimal(row["GiaNhap"]);
            GiaBan = Convert.ToDecimal(row["GiaBan"]);
            SoLuongTon = Convert.ToInt32(row["SoLuongTon"]);
            HinhAnh = row["HinhAnh"] == DBNull.Value ? "" : row["HinhAnh"].ToString();
            TenNCC = row.Table.Columns.Contains("TenNCC") ? row["TenNCC"].ToString() : "";
        }
        public string DuongDanHinhAnh
        {
            get
            {
                if (string.IsNullOrEmpty(HinhAnh))
                    return ""; 
                return QLCuaHang.Untils.DirectoryUtils.GetPathTo("data", "hanghoa", HinhAnh);
            }
        }

    }
}
