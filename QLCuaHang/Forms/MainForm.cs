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
using QLCuaHang.DAO;
using QLCuaHang.DTO;
using QLCuaHang.Forms;

namespace QLCuaHang
{
    public partial class MainForm : Form
    {
        private Account currentUser;
        private bool isPlaceholderActive = true;

        private readonly HangHoaBus hangHoaBUS = new HangHoaBus();
        private readonly DanhMucBus danhMucBUS = new DanhMucBus();
        private readonly KhachHangBus khachHangBus = new KhachHangBus();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Account user) : this()
        {
            currentUser = user;
            this.Text = "Xin chào " + user.FullName;

            ApplyPermission();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadHangHoa();
            isPlaceholderActive = true;
        }

        private string CleanPhone(string sdt)
        {
            if (string.IsNullOrEmpty(sdt)) return "";

            // Loại bỏ ký tự không phải số
            string cleaned = new string(sdt.Where(char.IsDigit).ToArray());
            return cleaned;
        }

        private void ApplyPermission()
        {
            if (currentUser == null) return;

            bool isAdmin = currentUser.Roles.Contains("admin");

            btnNhanVien.Enabled = isAdmin;
            btnDoanhThu.Enabled = isAdmin;
        }

        void LoadDanhMuc()
        {
            List<DanhMuc> dsDanhMuc = danhMucBUS.LayTatCa();
            dsDanhMuc.Insert(0, new DanhMuc() { MaDanhMuc = 0, TenDanhMuc = "Tất cả" });
            cbo_DanhMuc.DataSource = dsDanhMuc;
            cbo_DanhMuc.DisplayMember = "TenDanhMuc";
            cbo_DanhMuc.ValueMember = "MaDanhMuc";
        }

        void LoadHangHoa()
        {
            List<HangHoa> dsHangHoa = hangHoaBUS.LayTatCa();
            List<HangHoa> dsHangHoaConHang = dsHangHoa.Where(hh => hh.SoLuongTon > 0).ToList();
            RenderDanhSachHangHoa(dsHangHoaConHang);
        }

        void RenderDanhSachHangHoa(List<HangHoa> dsHangHoa)
        {
            flpn_DanhSachHangHoa.Controls.Clear();
            foreach(HangHoa hh in dsHangHoa)
            {
                uc_HangHoaBox box = new uc_HangHoaBox(hh.TenHH, hh.GiaBan, hh.HinhAnh);
                box.Tag = hh;
                box.Click += HangHoaItem_click;
                flpn_DanhSachHangHoa.Controls.Add(box);
            }    
        }
        private void HangHoaItem_click(object sender, EventArgs e)
        {
            uc_HangHoaBox frm = sender as uc_HangHoaBox;
            HangHoa clickedHangHoa = frm.Tag as HangHoa;

            AddHangHoaDuocChon(clickedHangHoa);
        }

        void AddHangHoaDuocChon(HangHoa hangHoa)
        {
            if (hangHoa.SoLuongTon <= 0)
            {
                MessageBox.Show($"Cảnh báo\nSản phẩm {hangHoa.TenHH} đã hết hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (uc_HangHoaItem item in flpn_SanPhamDaChon.Controls)
            {
                if (item.HangHoaID == hangHoa.MaHH)
                {
                    item.AddSoLuong(1);
                    CapNhatTongTien();
                    return;
                }
            }

            uc_HangHoaItem newItem = new uc_HangHoaItem(hangHoa);
            newItem.Width = flpn_SanPhamDaChon.Width - 30;

            newItem.Disposed += (s, e) => CapNhatTongTien();
            newItem.SoLuongChanged += (s, e) => CapNhatTongTien();
            newItem.GiaBanChanged += (s, e) => CapNhatTongTien();
            flpn_SanPhamDaChon.Controls.Add(newItem);

            CapNhatTongTien();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#F5ECDD");
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HangHoa hangHoafrm = new frm_HangHoa();
            hangHoafrm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadHangHoa();
            };
            hangHoafrm.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DoanhThu doanhThufrm = new frm_DoanhThu();
            doanhThufrm.FormClosed += (s, args) => this.Show();
            doanhThufrm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Account frm = new frm_Account();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_KhachHang frm = new frm_KhachHang();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void cbo_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhMuc selectedItem = cbo_DanhMuc.SelectedItem as DanhMuc;
            if (selectedItem == null) return;

            List<HangHoa> dsHangHoa;
            if (selectedItem.MaDanhMuc == 0)
            {
                dsHangHoa = hangHoaBUS.LayTatCa();
            }
            else
            {
                dsHangHoa = HangHoaDAO.Instance.GetAllHangHoaByDanhMuc(selectedItem.MaDanhMuc);
            }
            List<HangHoa> dsHangHoaConHang = dsHangHoa.Where(hh => hh.SoLuongTon > 0).ToList();
            RenderDanhSachHangHoa(dsHangHoaConHang);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
                return;

            string keyword = txt_TimKiem.Text;

            var dsHangHoa = HangHoaDAO.Instance.SearchHangHoaByTenHangHoa(keyword);
            List<HangHoa> dsHangHoaConHang = dsHangHoa.Where(hh => hh.SoLuongTon > 0).ToList();
            RenderDanhSachHangHoa(dsHangHoaConHang);
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập để tìm kiếm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                txt_TimKiem.Text = "Nhập để tìm kiếm...";
                txt_TimKiem.ForeColor = Color.Gray;
                isPlaceholderActive = true;
            }
        }

        public void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (Control control in flpn_SanPhamDaChon.Controls)
            {
                if (control is uc_HangHoaItem item)
                {
                    tongTien += item.GiaBan * item.SoLuong;
                }
            }

            decimal giamGia = nm_GiamGia.Value;
            decimal thanhToan = tongTien - (tongTien * giamGia / 100);

            lbl_TongTien.Text = tongTien.ToString("N0") + "₫";
            lbl_ThanhToan.Text = thanhToan.ToString("N0") + "đ";
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDon frm = new frm_HoaDon();
            frm.FormClosed += (s, args) => this.Show();
            frm.ShowDialog();
        }
        private string XacDinhLoaiKH(int diem)
        {
            if (diem < 100)
                return "Thường";
            else if (diem < 500)
                return "Thân thiết";
            else
                return "VIP";
        }

        private void mtxt_SĐT_Leave(object sender, EventArgs e)
        {
            string sdt = mtxt_SĐT.Text.Trim();

            if (string.IsNullOrEmpty(sdt)) 
                return;

            var ds = khachHangBus.LayTatCa();
            var kh = ds.FirstOrDefault(x => x.SĐT == sdt);

            if (kh != null)
            {
                txt_TenKH.Text = kh.TenKH;
                txt_Diem.Text = kh.DiemTichLuy.ToString();

                string loai = XacDinhLoaiKH(kh.DiemTichLuy);
                cbo_Loai.Text = loai;

                if (loai == "Thường")
                    nm_GiamGia.Value = 0;
                else if (loai == "Thân thiết")
                    nm_GiamGia.Value = 5;
                else if (loai == "VIP")
                    nm_GiamGia.Value = 10;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này!");
                txt_TenKH.Text = "";
                cbo_Loai.Text = "";
                txt_Diem.Text = "";
                nm_GiamGia.Value = 0;
            }

            CapNhatTongTien();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy giỏ hàng và đặt lại?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                flpn_SanPhamDaChon.Controls.Clear();
                lbl_TongTien.Text = "0₫";
                lbl_ThanhToan.Text = "0₫";
                txt_TenKH.Text = "";
                mtxt_SĐT.Text = "";
                cbo_Loai.Text = "";
                txt_Diem.Text = "";
                nm_GiamGia.Value = 0;
            }
        }

        private void btn_InBill_Click(object sender, EventArgs e)
        {
            if (flpn_SanPhamDaChon.Controls.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi in bill");
                return;
            }

            // Tạo danh sách chi tiết tạm
            List<ChiTietHoaDon> listChiTiet = new List<ChiTietHoaDon>();
            foreach (uc_HangHoaItem item in flpn_SanPhamDaChon.Controls)
            {
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.MaSP = item.HangHoaID;
                ct.SoLuong = item.SoLuong;
                ct.DonGia = item.GiaBan;
                ct.ThanhTien = item.GiaBan * item.SoLuong;
                listChiTiet.Add(ct);
            }

            // Lấy thông tin khách hàng
            string tenKH = txt_TenKH.Text.Trim();
            string sdt = CleanPhone(mtxt_SĐT.Text.Trim());

            if (string.IsNullOrEmpty(tenKH) && string.IsNullOrEmpty(sdt)) 
            {
                tenKH = "Khách lẻ";
                sdt = "";
            }
            string loaiKH = tenKH == "Khách lẻ" ? "Khách lẻ" : "Thường";
            KhachHang kh = new KhachHang(0, tenKH, sdt, loaiKH, 0);

            // Lấy discount
            double discount = (double)nm_GiamGia.Value;

            // Mở frm_Bills
            frm_Bills frm = new frm_Bills(listChiTiet, kh, discount);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lưu hóa đơn & chi tiết
                LuuHoaDon(kh, listChiTiet, discount);
                MessageBox.Show("Thanh toán thành công!");
                Reset();
                LoadHangHoa();
            }
        }

        private void LuuHoaDon(KhachHang kh, List<ChiTietHoaDon> listCTHD, double discount)
        {
            kh.SĐT = CleanPhone(kh.SĐT);
            try
            {
                // 1. Tính tổng tiền
                decimal tongTien = 0;
                foreach (var ct in listCTHD)
                    tongTien += ct.ThanhTien;

                decimal thanhToan = tongTien - tongTien * (decimal)discount / 100;

                int? maKH = null;

                // ✅ Nếu khách có SĐT hoặc là "Khách lẻ" => vẫn lưu vào DB
                if (!string.IsNullOrEmpty(kh.SĐT) || kh.TenKH == "Khách lẻ")
                {
                    maKH = khachHangBus.GetMaKHBySDT(kh.SĐT);

                    // Nếu chưa tồn tại trong DB thì thêm mới
                    if (maKH == -1 || maKH == null)
                    {
                        khachHangBus.Them(kh);
                        maKH = khachHangBus.GetMaKHBySDT(kh.SĐT);
                    }
                }

                // 2. Lưu hóa đơn
                HoaDon hd = new HoaDon();
                hd.NgayLap = DateTime.Now;
                hd.AccountName = currentUser.AccountName;
                hd.MaKH = maKH;
                hd.TongTien = tongTien;
                hd.GiamGia = (int)discount;
                hd.ThanhToan = thanhToan;

                HoaDonBus hdBus = new HoaDonBus();
                hdBus.TaoHoaDon(hd);

                // 3. Lưu chi tiết hóa đơn
                List<HoaDon> ds = hdBus.LayTatCa();
                HoaDon hoaDonMoi = ds.OrderByDescending(h => h.MaHD).FirstOrDefault();
                if (hoaDonMoi == null)
                    return;

                ChiTietHoaDonBus ctBus = new ChiTietHoaDonBus();
                foreach (var ct in listCTHD)
                {
                    ct.MaHD = hoaDonMoi.MaHD;
                    ctBus.ThemChiTiet(ct);
                    HangHoaDAO.Instance.GiamSoLuongTon(ct.MaSP, ct.SoLuong);
                }

                // 4. Cộng điểm (nếu KH không phải Khách lẻ)
                if (maKH.HasValue && kh.LoaiKH != "Khách lẻ")
                {
                    int diemCong = (int)(thanhToan / 100000);
                    if (diemCong > 0)
                        khachHangBus.CongDiem(maKH.Value, diemCong);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
            }
        }

        private void Reset()
        {
            flpn_SanPhamDaChon.Controls.Clear();

            lbl_TongTien.Text = "0đ";
            lbl_ThanhToan.Text = "0đ";

            txt_TenKH.Text = "";
            mtxt_SĐT.Text = "";
            cbo_Loai.Text = "";
            txt_Diem.Text = "";
            nm_GiamGia.Value = 0;
        }
    }
}