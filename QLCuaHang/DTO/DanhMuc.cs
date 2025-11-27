using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class DanhMuc
    {
        public int MaDanhMuc {  get; set; }
        public string TenDanhMuc { get; set; }

        public DanhMuc()
        {
            
        }

        public DanhMuc(int maDanhMuc, string tenDanhMuc)
        {
            this.MaDanhMuc = maDanhMuc;
            this.TenDanhMuc = tenDanhMuc;
        }

        public DanhMuc(DataRow row)
        {
            MaDanhMuc = Convert.ToInt32(row["MaDanhMuc"].ToString());
            TenDanhMuc = row["TenDanhMuc"].ToString();
        }
    }
}
