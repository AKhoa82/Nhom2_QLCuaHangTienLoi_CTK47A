using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class NhaCungCap
    {
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public NhaCungCap()
        {
            
        }
        public NhaCungCap(int maNCC, string tenNCC, string sdt, string diaChi)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.SDT = sdt;
            this.DiaChi = diaChi;
        }

        public NhaCungCap(DataRow row)
        {
            this.MaNCC = (int)row["MaNCC"];
            this.TenNCC = row["TenNCC"].ToString();
            this.SDT = row["SĐT"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }
    }
}
