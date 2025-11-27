using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Globalization;
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
    public partial class frm_HangHoa : Form
    {
        BindingSource dsHangHoaBinding = new BindingSource();
        List<HangHoa> dsHangHoa = new List<HangHoa>();
        private bool isPlaceholderActive = true;

        HangHoaBus hangHoaBUS = new HangHoaBus();
        DanhMucBus danhMucBus = new DanhMucBus();
        public frm_HangHoa()
        {
            InitializeComponent();
        }



        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            //Hàng hóa
            dgv_HangHoa.DataSource = dsHangHoaBinding;
            // Thiết lập menu chuột phải cho danh sách hàng hóa
            KhoiTaoContextMenuHangHoa();
            TaiTatCaHangHoa();
            TaiDanhMuc();
            GanDuLieuHangHoa();
            CapNhatSoLuongHangHoa();
            dgv_DSHangHoa.DataSource = dsHangHoaBinding;

            //Phiếu nhập
            TaiDanhSachPhieuNhap();
            GanDuLieuPhieuNhap();
        }

        void TaiTatCaHangHoa()
        {
            dsHangHoa = hangHoaBUS.LayTatCa();
            dsHangHoaBinding.DataSource = dsHangHoa;

            if (dgv_HangHoa.Columns["MaDanhMuc"] != null)
                dgv_HangHoa.Columns["MaDanhMuc"].Visible = false;
        }

        void TimKiemHangHoa(string tuKhoa)
        {
            dsHangHoa = hangHoaBUS.TimKiemTheoTen(tuKhoa);
            dsHangHoaBinding.DataSource = dsHangHoa;
            CapNhatSoLuongHangHoa();
        }

        void TaiDanhMuc()
        {
            var dsDanhMuc = danhMucBus.LayTatCa();
            dsDanhMuc.Insert(0, new DanhMuc { MaDanhMuc = 0, TenDanhMuc = "Tất cả" });

            cbo_LocDanhMuc.DataSource = new List<DanhMuc>(dsDanhMuc);
            cbo_LocDanhMuc.DisplayMember = "TenDanhMuc";
            cbo_LocDanhMuc.ValueMember = "MaDanhMuc";

            cbo_DanhMuc.DataSource = new List<DanhMuc>(dsDanhMuc.Skip(1));
            cbo_DanhMuc.DisplayMember = "TenDanhMuc";
            cbo_DanhMuc.ValueMember = "MaDanhMuc";
        }

        void RefreshDanhMuc()
        {
            TaiDanhMuc();
        }

        void GanDuLieuHangHoa()
        {
            // Xóa các ràng buộc dữ liệu hiện có
            txt_MaHang.DataBindings.Clear();
            txt_TenHang.DataBindings.Clear();
            cbo_DanhMuc.DataBindings.Clear();
            txt_DVT.DataBindings.Clear();
            txt_GiaBan.DataBindings.Clear();
            txt_GiaNhap.DataBindings.Clear();
            txt_NhaCC.DataBindings.Clear();
            nm_SoLuongTon.DataBindings.Clear();
            pb_Hinh.DataBindings.Clear();

            txt_MaHang.DataBindings.Add(new Binding("Text", dgv_HangHoa.DataSource, "MaHH", true, DataSourceUpdateMode.Never));
            txt_TenHang.DataBindings.Add(new Binding("Text", dgv_HangHoa.DataSource, "TenHH", true, DataSourceUpdateMode.Never));
            cbo_DanhMuc.DataBindings.Add(new Binding("SelectedValue", dgv_HangHoa.DataSource, "MaDanhMuc", true, DataSourceUpdateMode.Never));
            txt_DVT.DataBindings.Add(new Binding("Text", dgv_HangHoa.DataSource, "DonViTinh", true, DataSourceUpdateMode.Never));
            txt_GiaBan.DataBindings.Add(new Binding("Text", dgv_HangHoa.DataSource, "GiaBan", true, DataSourceUpdateMode.Never, null, "N0"));
            txt_GiaNhap.DataBindings.Add(new Binding("Text", dgv_HangHoa.DataSource, "GiaNhap", true, DataSourceUpdateMode.Never, null, "N0"));
            txt_NhaCC.DataBindings.Add(new Binding("Text", dgv_HangHoa.DataSource, "TenNCC", true, DataSourceUpdateMode.Never));
            nm_SoLuongTon.DataBindings.Add(new Binding("Value", dgv_HangHoa.DataSource, "SoLuongTon", true, DataSourceUpdateMode.Never));
            pb_Hinh.DataBindings.Add(new Binding("ImageLocation", dgv_HangHoa.DataSource, "DuongDanHinhAnh", true, DataSourceUpdateMode.Never));
        }

        private void dgv_HangHoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].DataBoundItem is HangHoa item)
            {
                if (item.SoLuongTon <= 10)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_SapXep.SelectedItem == null) return;
            
            string selected = cbo_SapXep.SelectedItem.ToString();
            List<HangHoa> sortedList = new List<HangHoa>();

            switch (selected)
            {
                case "Theo số lượng tăng dần":
                    sortedList = dsHangHoa.OrderBy(hh => hh.SoLuongTon).ToList();
                    break;

                case "Theo số lượng giảm dần":
                    sortedList = dsHangHoa.OrderByDescending(hh => hh.SoLuongTon).ToList();
                    break;

                case "Theo tên A-Z":
                    sortedList = dsHangHoa.OrderBy(hh => hh.TenHH).ToList();
                    break;

                case "Theo tên Z-A":
                    sortedList = dsHangHoa.OrderByDescending(hh => hh.TenHH).ToList();
                    break;

                case "Theo giá bán tăng dần":
                    sortedList = dsHangHoa.OrderBy(hh => hh.GiaBan).ToList();
                    break;

                case "Theo giá bán giảm dần":
                    sortedList = dsHangHoa.OrderByDescending(hh => hh.GiaBan).ToList();
                    break;

                default:
                    sortedList = dsHangHoa;
                    break;
            }

            dsHangHoaBinding.DataSource = sortedList;
            CapNhatSoLuongHangHoa();
        }

        private void cbo_LocDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LocDanhMuc.SelectedIndex < 0) return;

            DanhMuc selectedCategory = cbo_LocDanhMuc.SelectedItem as DanhMuc;
            if (selectedCategory == null) return;

            if (selectedCategory.TenDanhMuc.Equals("Tất cả"))
            {
                dsHangHoaBinding.DataSource = dsHangHoa;
                CapNhatSoLuongHangHoa();
                return;
            }
            try
            {
                dsHangHoaBinding.DataSource = dsHangHoa.Where(item => item.MaDanhMuc == selectedCategory.MaDanhMuc).ToList();
            }
            catch
            {
                dsHangHoaBinding.DataSource = new List<HangHoa>();
            }
            CapNhatSoLuongHangHoa();
        }

        private void CapNhatSoLuongHangHoa()
        {
            int count = dsHangHoaBinding.Count;
            toolStripStatusLabel1.Text = $"Số lượng hàng hóa: {count}";
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (isPlaceholderActive) return;
            
            string keyword = txt_TimKiem.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                TaiTatCaHangHoa();
                CapNhatSoLuongHangHoa();
            }
            else
            {
                TimKiemHangHoa(keyword);
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
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
                txt_TimKiem.Text = "Nhập hàng cần tìm kiếm...";
                txt_TimKiem.ForeColor = Color.Gray;
                isPlaceholderActive = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txt_MaHang.Clear();
            txt_TenHang.Clear();
            txt_DVT.Clear();
            txt_GiaBan.Clear();
            txt_GiaNhap.Clear();
            txt_NhaCC.Clear();
            nm_SoLuongTon.Value = 0;
            cbo_DanhMuc.SelectedIndex = -1;
            pb_Hinh.Image = null;
        }

        void TaiDanhSachPhieuNhap()
        {
            try
            {

                var phieuNhapBus = new PhieuNhapBus();
                List<PhieuNhap> dsPhieuNhap = phieuNhapBus.LayTatCaKemTongHop();

                dgv_DSDonNhap.DataSource = dsPhieuNhap;

                CauHinhHienThiPhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu phiếu nhập: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void CauHinhHienThiPhieuNhap()
        {
            if (dgv_DSDonNhap.Columns.Count > 0)
            {

                if (dgv_DSDonNhap.Columns["MaNV"] != null)
                    dgv_DSDonNhap.Columns["MaNV"].Visible = false;
                if (dgv_DSDonNhap.Columns["MaNCC"] != null)
                    dgv_DSDonNhap.Columns["MaNCC"].Visible = false;
                if (dgv_DSDonNhap.Columns["SDT_NCC"] != null)
                    dgv_DSDonNhap.Columns["SDT_NCC"].Visible = false;
                if (dgv_DSDonNhap.Columns["DiaChi_NCC"] != null)
                    dgv_DSDonNhap.Columns["DiaChi_NCC"].Visible = false;


                if (dgv_DSDonNhap.Columns["NgayNhapFormatted"] != null)
                    dgv_DSDonNhap.Columns["NgayNhapFormatted"].Visible = false;
                if (dgv_DSDonNhap.Columns["TongTienFormatted"] != null)
                    dgv_DSDonNhap.Columns["TongTienFormatted"].Visible = false;

                if (dgv_DSDonNhap.Columns["MaPN"] != null)
                    dgv_DSDonNhap.Columns["MaPN"].HeaderText = "Mã PN";
                if (dgv_DSDonNhap.Columns["NgayNhap"] != null)
                    dgv_DSDonNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                if (dgv_DSDonNhap.Columns["TenNhanVien"] != null)
                    dgv_DSDonNhap.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                if (dgv_DSDonNhap.Columns["TenNhaCungCap"] != null)
                    dgv_DSDonNhap.Columns["TenNhaCungCap"].HeaderText = "Nhà cung cấp";
                if (dgv_DSDonNhap.Columns["TongSoLuong"] != null)
                    dgv_DSDonNhap.Columns["TongSoLuong"].HeaderText = "Tổng SL";
                if (dgv_DSDonNhap.Columns["TongTien"] != null)
                    dgv_DSDonNhap.Columns["TongTien"].HeaderText = "Tổng tiền";


                if (dgv_DSDonNhap.Columns["NgayNhap"] != null)
                {
                    dgv_DSDonNhap.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }


                if (dgv_DSDonNhap.Columns["TongTien"] != null)
                {
                    dgv_DSDonNhap.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                }


                dgv_DSDonNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public void GanDuLieuPhieuNhap()
        {
            // Xóa các ràng buộc dữ liệu hiện có để tránh duplicate binding
            txt_MaNhapHang.DataBindings.Clear();
            txt_NgayNhap.DataBindings.Clear();
            txt_NhanVien.DataBindings.Clear();
            txt_TenNCC.DataBindings.Clear();
            txt_NCC.DataBindings.Clear();

            // Chỉ đăng ký sự kiện một lần để tránh duplicate event handlers
            dgv_DSDonNhap.SelectionChanged -= dgv_DSDonNhap_SelectionChanged;
            dgv_DSDonNhap.SelectionChanged += dgv_DSDonNhap_SelectionChanged;
        }

        private void dgv_DSDonNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSDonNhap.CurrentRow == null) return;
            var current = dgv_DSDonNhap.CurrentRow.DataBoundItem as PhieuNhap;
            if (current == null) return;

            // Cập nhật các textbox với dữ liệu từ dòng được chọn
            txt_MaNhapHang.Text = current.MaPN.ToString();
            txt_NgayNhap.Text = current.NgayNhap.ToString("dd/MM/yyyy");
            txt_NhanVien.Text = current.TenNhanVien;
            txt_TenNCC.Text = current.TenNhaCungCap;
            txt_NCC.Text = current.MaNCC.ToString();

            try
            {
                var bus = new PhieuNhapBus();
                var details = bus.LayChiTiet(current.MaPN);

                lv_ThongTin.BeginUpdate();
                lv_ThongTin.Items.Clear();
                int stt = 1;
                decimal tongGiaNhap = 0; // Biến để tính tổng giá nhập
                int tongSoLuong = 0; // Biến để tính tổng số lượng
                
                foreach (var d in details)
                {
                    var item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(current.MaPN.ToString());
                    item.SubItems.Add(d.TenSP);
                    item.SubItems.Add(d.MaSP.ToString());
                    item.SubItems.Add(d.SoLuong.ToString());
                    item.SubItems.Add(d.DonGia.ToString("N0")); // Hiển thị giá nhập với định dạng số
                    
                    // Tính tổng giá nhập cho từng sản phẩm
                    decimal thanhTien = d.SoLuong * d.DonGia;
                    item.SubItems.Add(thanhTien.ToString("N0"));
                    
                    // Cộng vào tổng
                    tongGiaNhap += thanhTien;
                    tongSoLuong += d.SoLuong;
                    lv_ThongTin.Items.Add(item);
                    stt++;
                }
                
                // Thêm dòng tổng cộng với công thức rõ ràng
                if (details.Count > 0)
                {
                    var tongItem = new ListViewItem("");
                    tongItem.SubItems.Add("");
                    tongItem.SubItems.Add($"TỔNG CỘNG ({details.Count} sản phẩm):");
                    tongItem.SubItems.Add("");
                    tongItem.SubItems.Add(tongSoLuong.ToString("N0"));
                    tongItem.SubItems.Add("");
                    tongItem.SubItems.Add(tongGiaNhap.ToString("N0") + " VNĐ");
                    tongItem.Font = new Font(tongItem.Font, FontStyle.Bold);
                    tongItem.BackColor = Color.LightBlue;
                    tongItem.ForeColor = Color.DarkBlue;
                    lv_ThongTin.Items.Add(tongItem);
                    
                    // Thêm dòng hiển thị công thức tính chi tiết
                    var congThucItem = new ListViewItem("");
                    congThucItem.SubItems.Add("");
                    congThucItem.SubItems.Add("Công thức tính:");
                    congThucItem.SubItems.Add("");
                    congThucItem.SubItems.Add("");
                    congThucItem.SubItems.Add("");
                    congThucItem.SubItems.Add($"Σ(SL × Giá) = {tongGiaNhap:N0}");
                    congThucItem.Font = new Font(congThucItem.Font, FontStyle.Italic);
                    congThucItem.BackColor = Color.LightYellow;
                    congThucItem.ForeColor = Color.DarkGreen;
                    lv_ThongTin.Items.Add(congThucItem);
                    
                    // Thêm dòng hiển thị chi tiết từng sản phẩm
                    foreach (var d in details)
                    {
                        var chiTietItem = new ListViewItem("");
                        chiTietItem.SubItems.Add("");
                        chiTietItem.SubItems.Add($"  • {d.TenSP}:");
                        chiTietItem.SubItems.Add("");
                        chiTietItem.SubItems.Add($"{d.SoLuong} × {d.DonGia:N0}");
                        chiTietItem.SubItems.Add("");
                        chiTietItem.SubItems.Add($"= {d.SoLuong * d.DonGia:N0}");
                        chiTietItem.Font = new Font(chiTietItem.Font, FontStyle.Regular);
                        chiTietItem.BackColor = Color.WhiteSmoke;
                        chiTietItem.ForeColor = Color.DarkSlateGray;
                        lv_ThongTin.Items.Add(chiTietItem);
                    }
                }
                
                lv_ThongTin.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải chi tiết phiếu nhập: {ex.Message}");
            }
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = dsHangHoaBinding.Cast<HangHoa>().ToList();
                Account currentUser = null;
                using (var form = new QLCuaHang.Forms.frm_NhaphangMoi(ds, currentUser))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        TaiDanhSachPhieuNhap();
                        MessageBox.Show("Đã lưu phiếu nhập thành công.", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo hóa đơn nhập: {ex.Message}");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                int maPN;
                if (!int.TryParse(txt_MaNhapHang.Text, out maPN) || maPN <= 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu nhập cần cập nhật trong danh sách.");
                    return;
                }

                DateTime ngayNhap;
                if (!DateTime.TryParse(txt_NgayNhap.Text, out ngayNhap))
                {
                    // Nếu txt_NgayNhap là readonly bind theo cột DateTime, có thể dùng CurrentRow
                    ngayNhap = DateTime.Now;
                }

                // Ở đây demo: giữ nguyên MaNV cũ (không có control nhập), hoặc mặc định "admin"
                string accountName = "admin";
                int maNCC;
                if (!int.TryParse(txt_NCC.Text, out maNCC))
                {
                    MessageBox.Show("Mã nhà cung cấp không hợp lệ.");
                    return;
                }

                var bus = new PhieuNhapBus();
                bool ok = bus.CapNhatPhieuNhap(maPN, ngayNhap, accountName, maNCC);
                if (ok)
                {
                    TaiDanhSachPhieuNhap();
                    MessageBox.Show("Cập nhật phiếu nhập thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu nhập thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật: {ex.Message}");
            }
        }

        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int maPN;
                if (!int.TryParse(txt_MaNhapHang.Text, out maPN) || maPN <= 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa trong danh sách.");
                    return;
                }

                var confirm = MessageBox.Show("Xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                var bus = new PhieuNhapBus();
                if (bus.XoaPhieuNhap(maPN))
                {
                    TaiDanhSachPhieuNhap();
                    MessageBox.Show("Đã xóa phiếu nhập.");
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa phiếu nhập: {ex.Message}");
            }
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            try
            {

                var frmThemDanhMuc = new frm_ThemDanhMuc();

                if (frmThemDanhMuc.ShowDialog() == DialogResult.OK)
                {

                    RefreshDanhMuc();


                    if (cbo_DanhMuc.Items.Count > 0)
                    {
                        cbo_DanhMuc.SelectedIndex = cbo_DanhMuc.Items.Count - 1;
                    }

                    MessageBox.Show("Danh mục mới đã được thêm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm danh mục: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BotLoai_Click(object sender, EventArgs e)
        {
            try
            {
                var frmXoaDanhMuc = new frm_XoaDanhMuc();

                if (frmXoaDanhMuc.ShowDialog() == DialogResult.OK)
                {
                    RefreshDanhMuc();
                    TaiTatCaHangHoa();

                    MessageBox.Show("Danh mục đã được xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        pb_Hinh.ImageLocation = selectedFilePath;



                        MessageBox.Show($"Đã chọn hình ảnh: {System.IO.Path.GetFileName(selectedFilePath)}",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn hình ảnh: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HangHoa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hàng hóa cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HangHoa selectedHangHoa = dgv_HangHoa.SelectedRows[0].DataBoundItem as HangHoa;
                if (selectedHangHoa == null) return;

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa hàng hóa '{selectedHangHoa.TenHH}'?\n\n" +
                    "Hành động này không thể hoàn tác!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = hangHoaBUS.XoaHangHoa(selectedHangHoa.MaHH);

                    if (success)
                    {
                        MessageBox.Show("Xóa hàng hóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TaiTatCaHangHoa();
                        CapNhatSoLuongHangHoa();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hàng hóa thất bại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hàng hóa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhoiTaoContextMenuHangHoa()
        {
            var contextMenu = new ContextMenuStrip();
            var itemCapNhat = new ToolStripMenuItem("Cập nhật");
            var itemXoa = new ToolStripMenuItem("Xóa");

            itemCapNhat.Click += (s, e) =>
            {
                btnCapNhat.PerformClick();
            };

            itemXoa.Click += (s, e) =>
            {
                
                btn_XoaHangHoa_Click(s, e);
            };

            contextMenu.Items.Add(itemCapNhat);
            contextMenu.Items.Add(itemXoa);

            dgv_HangHoa.ContextMenuStrip = contextMenu;

            
            dgv_HangHoa.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hit = dgv_HangHoa.HitTest(e.X, e.Y);
                    if (hit.RowIndex >= 0)
                    {
                        dgv_HangHoa.ClearSelection();
                        dgv_HangHoa.Rows[hit.RowIndex].Selected = true;
                        dgv_HangHoa.CurrentCell = dgv_HangHoa.Rows[hit.RowIndex].Cells[hit.ColumnIndex >= 0 ? hit.ColumnIndex : 0];
                    }
                }
            };
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HangHoa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hàng hóa cần cập nhật!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedHangHoa = dgv_HangHoa.SelectedRows[0].DataBoundItem as HangHoa;
                if (selectedHangHoa == null) return;

                // Lấy dữ liệu từ các control để cập nhật
                int maHH;
                if (!int.TryParse(txt_MaHang.Text, out maHH))
                {
                    MessageBox.Show("Mã hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tenHang = txt_TenHang.Text?.Trim();
                if (string.IsNullOrWhiteSpace(tenHang))
                {
                    MessageBox.Show("Tên hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maDanhMuc = cbo_DanhMuc.SelectedValue is int v ? v : selectedHangHoa.MaDanhMuc;
                int? maNCC = null; 
                string tenNCC = txt_NhaCC.Text?.Trim();
                string donViTinh = txt_DVT.Text?.Trim();

                decimal giaNhap;
                if (!decimal.TryParse(txt_GiaNhap.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out giaNhap))
                {
                    MessageBox.Show("Giá nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal giaBan;
                if (!decimal.TryParse(txt_GiaBan.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out giaBan))
                {
                    MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuongTon = (int)nm_SoLuongTon.Value;

                string hinhAnhFileName = null;
                if (!string.IsNullOrWhiteSpace(pb_Hinh.ImageLocation))
                {
                    hinhAnhFileName = Path.GetFileName(pb_Hinh.ImageLocation);
                }
                else
                {
                    hinhAnhFileName = selectedHangHoa.HinhAnh;
                }

                bool success = hangHoaBUS.CapNhatHangHoa(
                    maHH,
                    tenHang,
                    maDanhMuc,
                    tenNCC,
                    donViTinh,
                    giaNhap,
                    giaBan,
                    soLuongTon,
                    hinhAnhFileName
                );

                if (success)
                {
                    MessageBox.Show("Cập nhật hàng hóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiTatCaHangHoa();
                    CapNhatSoLuongHangHoa();
                }
                else
                {
                    MessageBox.Show("Cập nhật hàng hóa thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hàng hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            
            txt_MaNhapHang.Clear();
            txt_NgayNhap.Clear();   
            txt_NhanVien.Clear();
            txt_TenNCC.Clear();
            txt_NCC.Clear();

            
            lv_ThongTin.Items.Clear();
            
            dgv_DSDonNhap.ClearSelection();
        }

        private void btn_ThemHang_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new QLCuaHang.Forms.frm_ThemHangHoa())
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        TaiTatCaHangHoa();
                        CapNhatSoLuongHangHoa();
                        MessageBox.Show("Đã thêm hàng hóa mới.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm hàng: {ex.Message}");
            }
        }
    }
}
