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

namespace QLCuaHang.Forms
{
    public partial class frm_Bills : Form
    {
        private List<ChiTietHoaDon> _listCTHD;
        private KhachHang _khachHang;
        private double _discount;

        public frm_Bills(List<ChiTietHoaDon> listCTHD, KhachHang kh, double discount)
        {
            InitializeComponent();
            _listCTHD = listCTHD;
            _khachHang = kh;
            _discount = discount;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#F5ECDD");
        }

        private void frm_Bills_Load(object sender, EventArgs e)
        {
            dgv_Bill.DataSource = null;
            dgv_Bill.DataSource = _listCTHD;

            // Hiển thị thông tin khách hàng
            if (string.IsNullOrEmpty(_khachHang.TenKH))
                lbl_TenKH.Text = "Khách lẻ";
            else
                lbl_TenKH.Text = _khachHang.TenKH;

            if (string.IsNullOrEmpty(_khachHang.SĐT))
                lbl_SĐT.Text = "(Không có)";
            else
                lbl_SĐT.Text = _khachHang.SĐT;

            // Tính toán tổng tiền
            decimal tong = 0;
            foreach (var ct in _listCTHD)
                tong += ct.ThanhTien;

            lbl_TongTien.Text = tong.ToString("N0") + "₫";
            lbl_GiamGia.Text = _discount + "%";
            lbl_ThanhToan.Text = (tong - tong * (decimal)_discount / 100).ToString("N0") + "₫";
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBill_Thoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
