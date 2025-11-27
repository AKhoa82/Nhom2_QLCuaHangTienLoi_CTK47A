using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class HoaDonBus
    {
        public List<HoaDon> LayTatCa()
        {
            return HoaDonDAO.Instance.GetAllHoaDon();
        }

        public List<HoaDon> LayTheoKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            return HoaDonDAO.Instance.GetHoaDonByDate(tuNgay, denNgay);
        }

        public int TaoHoaDon(HoaDon hd)
        {
            int? maKH = null;
            if (hd.MaKH != 0)
            {
                maKH = hd.MaKH;
            }

            return HoaDonDAO.Instance.InsertHoaDon(
                hd.NgayLap,
                maKH,
                hd.TongTien,
                hd.GiamGia,
                hd.AccountName
            );

        }

        public HoaDon LayHoaDonMoiNhat()
        {
            var ds = LayTatCa();
            return ds.OrderByDescending(h => h.MaHD).FirstOrDefault();
        }
    }
}
