using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.DAO;

namespace QLCuaHang.BLL
{
    public class KhachHangBus
    {
        public List<KhachHang> LayTatCa()
        {
            return KhachHangDAO.Instance.GetAllKhachHang();
        }

        public List<KhachHang> TimTheoTen(string keyword)
        {
            return KhachHangDAO.Instance.SearchKhachHangByName(keyword);
        }

        public bool Them(KhachHang kh)
        {
            return KhachHangDAO.Instance.InsertKhachHang(kh);
        }

        public bool CapNhat(KhachHang kh)
        {
           return  KhachHangDAO.Instance.UpdateKhachHang(kh);
        }

        public void Xoa(int maKH)
        {
            KhachHangDAO.Instance.DeleteKhachHang(maKH);
        }

        public int GetMaKHBySDT(string sdt)
        {
            return KhachHangDAO.Instance.GetMaKHBySDT(sdt);
        }

        public void CongDiem(int maKH, int soDiemCongThem)
        {
            KhachHangDAO.Instance.UpdateDiemTichLuy(maKH, soDiemCongThem);
        }
    }
}
