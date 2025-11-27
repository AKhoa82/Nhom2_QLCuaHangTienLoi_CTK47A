using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class ChiTietHoaDonBus
    {
        public List<ChiTietHoaDon> LayTheoMaHD(int maHD)
        {
            return ChiTietHoaDonDAO.Instance.GetChiTietHoaDonByMaHD(maHD);
        }

        public void ThemChiTiet(ChiTietHoaDon ct)
        {
            ChiTietHoaDonDAO.Instance.InsertChiTietHoaDon(ct.MaHD, ct.MaSP, ct.SoLuong, ct.DonGia);
        }
    }
}
