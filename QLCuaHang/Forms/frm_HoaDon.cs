using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace QLCuaHang
{
    public partial class frm_HoaDon : Form
    {
        private HoaDonBus hoaDonBus = new HoaDonBus();
        private ChiTietHoaDonBus chiTietBus = new ChiTietHoaDonBus();

        private BindingSource hoaDonBS = new BindingSource();
        private BindingSource chiTietBS = new BindingSource();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = hoaDonBS;
            dgv_ChiTiet.DataSource = chiTietBS;

            HienThiHoaDon(hoaDonBus.LayTatCa());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtp_From.Value.Date;
            DateTime denNgay = dtp_To.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ds = hoaDonBus.LayTheoKhoangNgay(tuNgay, denNgay);
            HienThiHoaDon(ds);
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiHoaDon(hoaDonBus.LayTatCa());
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HoaDon hd = (HoaDon)dgv_HoaDon.Rows[e.RowIndex].DataBoundItem;
                if (hd == null)
                    return;

                var chiTiet = chiTietBus.LayTheoMaHD(hd.MaHD);
                chiTietBS.DataSource = chiTiet;

                decimal tongTien = 0;
                foreach (var ct in chiTiet)
                    tongTien += ct.ThanhTien;

                decimal giamGiaTien = tongTien * hd.GiamGia / 100;

                decimal thucThu = hd.ThanhToan;

                lbl_TongTien.Text = tongTien.ToString("N0") + " đ";
                lbl_GiamGia.Text = giamGiaTien.ToString("N0") + " đ";
                lbl_ThucThu.Text = thucThu.ToString("N0") + " đ";
            }
        }
        
        private void HienThiHoaDon(List<HoaDon> ds)
        {
            hoaDonBS.DataSource = ds;
            chiTietBS.DataSource = null;

            lbl_TongTien.Text = "0 đ";
            lbl_GiamGia.Text = "0 đ";
            lbl_ThucThu.Text = "0 đ";
        }
    }
}
