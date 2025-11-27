using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang
{
    public partial class frm_DoanhThu : Form
    {
        private List<HoaDon> danhSachHoaDonHienThi;
        public frm_DoanhThu()
        {
            InitializeComponent();
            LoadDefaultControls();
        }

        void LoadDefaultControls()
        {
            cbo_ChartMode.Items.Add("Theo ngày");
            cbo_ChartMode.Items.Add("Theo tháng");
            cbo_ChartMode.Items.Add("Theo năm");
            cbo_ChartMode.SelectedIndex = 0;
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay;
                DateTime denNgay;

                if (rad_TheoThang.Checked)
                {
                    if (cbo_Thang.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int nam;
                    if (!int.TryParse(txt_Nam.Text, out nam) || nam <= 0)
                    {
                        MessageBox.Show("Năm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string selected = cbo_Thang.SelectedItem.ToString();
                    int thang = 1; 
                    if (selected.Contains("Tháng"))
                    {
                        string soThang = selected.Replace("Tháng", "").Trim();
                        int.TryParse(soThang, out thang);
                    }

                    tuNgay = new DateTime(nam, thang, 1);
                    denNgay = tuNgay.AddMonths(1).AddTicks(-1);
                }
                else if (rad_TheoNam.Checked)
                {
                    int nam;
                    if (!int.TryParse(txt_NamOnly.Text, out nam) || nam <= 0)
                    {
                        MessageBox.Show("Năm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    tuNgay = new DateTime(nam, 1, 1);
                    denNgay = new DateTime(nam, 12, 31, 23, 59, 59);
                }
                else if (rad_TheoNgay.Checked)
                {
                    tuNgay = dtp_Ngay.Value.Date;
                    denNgay = tuNgay.AddDays(1).AddTicks(-1);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chế độ xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- Tải dữ liệu và tính toán ---
                this.danhSachHoaDonHienThi = HoaDonDAO.Instance.GetHoaDonByDate(tuNgay, denNgay);
                dgv_HoaDon.DataSource = this.danhSachHoaDonHienThi;
                dgv_HoaDon.Columns["GiamGia"].Visible = false;
                dgv_HoaDon.Columns["TongTien"].Visible = false;

                if (danhSachHoaDonHienThi == null || !danhSachHoaDonHienThi.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TongDoanhThu.Text = "0 VNĐ";
                    txt_BanNhieuNhat.Text = "N/A";
                    txt_BanItNhat.Text = "N/A";
                    UpdateChart();
                    return;
                }

                decimal tongDoanhThu = this.danhSachHoaDonHienThi.Sum(hd => hd.ThanhToan);
                txt_TongDoanhThu.Text = tongDoanhThu.ToString("N0") + " VNĐ";

                var sanPhamBanRa = new Dictionary<int, int>();
                foreach (var hd in this.danhSachHoaDonHienThi)
                {
                    var dsChiTiet = ChiTietHoaDonDAO.Instance.GetChiTietHoaDonByMaHD(hd.MaHD);
                    foreach (var ct in dsChiTiet)
                    {
                        if (sanPhamBanRa.ContainsKey(ct.MaSP))
                            sanPhamBanRa[ct.MaSP] += ct.SoLuong;
                        else
                            sanPhamBanRa.Add(ct.MaSP, ct.SoLuong);
                    }
                }

                if (sanPhamBanRa.Any())
                {
                    var sortedList = sanPhamBanRa.OrderByDescending(p => p.Value).ToList();
                    txt_BanNhieuNhat.Text = $"Mã SP: {sortedList.First().Key} (SL: {sortedList.First().Value})";
                    txt_BanItNhat.Text = $"Mã SP: {sortedList.Last().Key} (SL: {sortedList.Last().Value})";
                }
                else
                {
                    txt_BanNhieuNhat.Text = "N/A";
                    txt_BanItNhat.Text = "N/A";
                }

                UpdateChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống xảy ra! Vui lòng thử lại.\nChi tiết: " + ex.Message,
                                "Lỗi Không Mong Muốn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void UpdateChart()
        {
            chart_DoanhThu.Series[0].Points.Clear();
            chart_DoanhThu.Titles.Clear();

            if (danhSachHoaDonHienThi == null || !danhSachHoaDonHienThi.Any())
            {
                return;
            }

            string selectedMode = cbo_ChartMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "Theo ngày":
                    chart_DoanhThu.Titles.Add("Biểu đồ doanh thu theo từng ngày");
                    var dataNgay = danhSachHoaDonHienThi
                        .GroupBy(hd => hd.NgayLap.Date)
                        .Select(g => new { ThoiGian = g.Key, Tong = g.Sum(hd => hd.ThanhToan) })
                        .OrderBy(item => item.ThoiGian);
                    foreach (var item in dataNgay)
                    {
                        chart_DoanhThu.Series[0].Points.AddXY(item.ThoiGian.ToString("dd/MM"), item.Tong);
                    }
                    break;
                case "Theo tháng":
                    chart_DoanhThu.Titles.Add("Biểu đồ doanh thu theo từng tháng");
                    var dataThang = danhSachHoaDonHienThi
                        .GroupBy(hd => new { hd.NgayLap.Year, hd.NgayLap.Month })
                        .Select(g => new { ThoiGian = new DateTime(g.Key.Year, g.Key.Month, 1), Tong = g.Sum(hd => hd.ThanhToan) })
                        .OrderBy(item => item.ThoiGian);
                    foreach (var item in dataThang)
                    {
                        chart_DoanhThu.Series[0].Points.AddXY(item.ThoiGian.ToString("MM/yyyy"), item.Tong);
                    }
                    break;
                case "Theo năm":
                    chart_DoanhThu.Titles.Add("Biểu đồ doanh thu theo từng năm");
                    var dataNam = danhSachHoaDonHienThi
                        .GroupBy(hd => hd.NgayLap.Year)
                        .Select(g => new { ThoiGian = g.Key, Tong = g.Sum(hd => hd.ThanhToan) })
                        .OrderBy(item => item.ThoiGian);
                    foreach (var item in dataNam)
                    {
                        chart_DoanhThu.Series[0].Points.AddXY(item.ThoiGian, item.Tong);
                    }
                    break;
            }
        }

        private void cbo_ChartMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }
}
