using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang
{
    public class KhachHang
    {
        public int MaKH {  get; set; }
        public string TenKH {  get; set; }
        public string SĐT {  get; set; }
        public string LoaiKH {  get; set; }
        public int DiemTichLuy {  get; set; }

        public KhachHang()
        {
            
        }

        public KhachHang(int maKH, string tenKH, string sdt, int diemTichLuy)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.SĐT = sdt;
            this.DiemTichLuy = diemTichLuy;
        }

        public KhachHang(int maKH, string tenKH, string sdt, string loaiKH, int diemTichLuy)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.SĐT = sdt;
            this.LoaiKH = loaiKH; 
            this.DiemTichLuy = diemTichLuy;
        }

        public KhachHang(DataRow row)
        {
            this.MaKH = Convert.ToInt32(row["MaKH"]);
            this.TenKH = row["TenKH"].ToString();
            this.SĐT = row["SĐT"].ToString();
            this.DiemTichLuy = Convert.ToInt32(row["DiemTichLuy"]);
        }
    }
}
