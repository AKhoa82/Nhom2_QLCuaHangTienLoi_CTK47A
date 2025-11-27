using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHang.DAO;

namespace QLCuaHang.BLL
{
    public class HangHoaBus
    {
        public List<HangHoa> LayTatCa()
        {
            return HangHoaDAO.Instance.GetAllHangHoa();
        }

        public List<HangHoa> LayTheoDanhMuc(int maDanhMuc)
        {
            return HangHoaDAO.Instance.GetAllHangHoaByDanhMuc(maDanhMuc);
        }

        public List<HangHoa> TimKiemTheoTen(string keyword)
        {
            return HangHoaDAO.Instance.SearchHangHoaByTenHangHoa(keyword);
        }

        public bool CapNhatHangHoa(int maHH, string tenHH, int maDanhMuc, string tenNCC, string donViTinh, decimal giaNhap, decimal giaBan, int soLuongTon, string hinhAnh)
        {
            return HangHoaDAO.Instance.UpdateHangHoa(maHH, tenHH, maDanhMuc, tenNCC, donViTinh, giaNhap, giaBan, soLuongTon, hinhAnh);
        }

        public bool XoaHangHoa(int maHH)
        {
            return HangHoaDAO.Instance.DeleteHangHoa(maHH);
        }
        public bool ThemHangHoa(string tenHangHoa, int maDanhMuc, int maNCC, string donViTinh, decimal giaNhap, int soLuongTon, string hinhAnh)
        {
            return HangHoaDAO.Instance.InsertHangHoa(tenHangHoa, maDanhMuc, maNCC, donViTinh, giaNhap, soLuongTon, hinhAnh);
        }
    }
}
