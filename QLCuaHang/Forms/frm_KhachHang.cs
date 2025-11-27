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

namespace QLCuaHang
{
    public partial class frm_KhachHang : Form
    {
        private readonly KhachHangBus khachHangBus = new KhachHangBus();
        private List<KhachHang> dskh = new List<KhachHang>();
        private bool isEditing = false;
        private int originalMaKH = -1;
        private ContextMenuStrip contextMenu;

        public frm_KhachHang()
        {
            InitializeComponent();
            TaoContextMenu();

            dgv_DSKH.DataError += dgv_DSKH_DataError;
        }

        private void dgv_DSKH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void TaoContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem xoaItem = new ToolStripMenuItem("Xóa khách hàng");
            xoaItem.Click += XoaKhachHangContextMenu_Click;
            contextMenu.Items.Add(xoaItem);
        }

        private void XoaKhachHangContextMenu_Click(object sender, EventArgs e)
        {
            XoaKhachHangDuocChon();
        }

        private void XoaKhachHangDuocChon()
        {
            try
            {
                if (dgv_DSKH.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow currentRow = dgv_DSKH.CurrentRow;


                int maKH;
                if (!int.TryParse(currentRow.Cells[0].Value.ToString(), out maKH))
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tenKH = currentRow.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng '{tenKH}'?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgv_DSKH.ClearSelection();

                    khachHangBus.Xoa(maKH);
                    LamMoi();
                    HienThiDanhSach();
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSach()
        {
            try
            {
                dgv_DSKH.ClearSelection();

                var danhSachCopy = khachHangBus.LayTatCa();

                dgv_DSKH.DataSource = null;
                dgv_DSKH.Refresh();
                dgv_DSKH.DataSource = danhSachCopy;

                if (dgv_DSKH.Columns.Count >= 5)
                {
                    dgv_DSKH.Columns[0].HeaderText = "Mã KH";
                    dgv_DSKH.Columns[1].HeaderText = "Tên khách hàng";
                    dgv_DSKH.Columns[2].HeaderText = "Số điện thoại";
                    dgv_DSKH.Columns[3].HeaderText = "Loại Khách hàng";
                    dgv_DSKH.Columns[4].HeaderText = "Điểm tích lũy";

                    dgv_DSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv_DSKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv_DSKH.ContextMenuStrip = contextMenu;
                    dgv_DSKH.MultiSelect = false;
                    dgv_DSKH.AllowUserToAddRows = false;
                    dgv_DSKH.AllowUserToDeleteRows = false;
                    dgv_DSKH.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi hiển thị danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public KhachHang TimTheoMa(int maKH) => khachHangBus.LayTatCa().FirstOrDefault(kh => kh.MaKH == maKH);

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isEditing || originalMaKH == -1)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng từ danh sách để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_MaKH.Text) ||
                    string.IsNullOrWhiteSpace(txt_TenKH.Text) ||
                    string.IsNullOrWhiteSpace(txt_SDT.Text) ||
                    string.IsNullOrWhiteSpace(txt_Diem.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ma = int.Parse(txt_MaKH.Text);
                string ten = txt_TenKH.Text.Trim();
                string sdt = txt_SDT.Text.Replace("(", "").Replace(")", "").Replace(".", "").Trim();
                int diem = int.Parse(txt_Diem.Text);

                if (diem < 0)
                {
                    MessageBox.Show("Điểm tích lũy không được âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ma != originalMaKH && TimTheoMa(ma) != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KhachHang khachHang = new KhachHang(ma, ten, sdt, diem);

                if (khachHangBus.CapNhat(khachHang))
                {
                    MessageBox.Show("Lưu thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho mã khách hàng và điểm tích lũy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaKhachHangDuocChon();
        }



        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            HienThiDanhSach();
        }

        private void LamMoi()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_Diem.Text = "";
            txt_TimKiem.Text = "";

            isEditing = false;
            originalMaKH = -1;
            btn_Luu.Text = "Lưu";
            btn_Luu.BackColor = Color.Gray;
            btn_Luu.Enabled = false;

            txt_MaKH.Enabled = false;
            txt_TenKH.Enabled = false;
            txt_SDT.Enabled = false;
            txt_Diem.Enabled = false;

            txt_MaKH.BackColor = Color.LightGray;
            txt_TenKH.BackColor = Color.LightGray;
            txt_SDT.BackColor = Color.LightGray;
            txt_Diem.BackColor = Color.LightGray;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            List<KhachHang> ketQua;
            try
            {
                string tuKhoa = txt_TimKiem.Text.Trim();

                if (string.IsNullOrWhiteSpace(tuKhoa))
                {
                    HienThiDanhSach();
                    return;
                }

                if (rad_TimKiemLoai.Checked == true)
                    ketQua = khachHangBus.LayTatCa().Where(kh => kh.LoaiKH.ToLower().Contains(tuKhoa.ToLower())).ToList();

                if (rad_TimKiemTen.Checked == true)
                    ketQua = khachHangBus.LayTatCa().Where(kh => kh.SĐT.Contains(tuKhoa)).ToList();

                if (rad_TimKiemMa.Checked == true)
                    ketQua = khachHangBus.LayTatCa().Where(kh => kh.MaKH.ToString() == tuKhoa).ToList();

                else
                    ketQua = khachHangBus.LayTatCa().Where(kh =>
                        kh.TenKH.ToLower().Contains(tuKhoa.ToLower()) ||
                        kh.SĐT.Contains(tuKhoa) ||
                        kh.LoaiKH.ToLower().Contains(tuKhoa.ToLower())
                    ).ToList();

                dgv_DSKH.DataSource = null;
                dgv_DSKH.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Tìm thấy {ketQua.Count} khách hàng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_DSKH.Rows.Count)
                {
                    DataGridViewRow row = dgv_DSKH.Rows[e.RowIndex];

                    if (row.Cells.Count >= 4 && row.Cells[0].Value != null)
                    {
                        txt_MaKH.Text = row.Cells[0].Value?.ToString() ?? "";
                        txt_TenKH.Text = row.Cells[1].Value?.ToString() ?? "";
                        txt_SDT.Text = row.Cells[2].Value?.ToString() ?? "";
                        txt_Diem.Text = row.Cells[3].Value?.ToString() ?? "";

                        // Parse MaKH an toàn
                        if (int.TryParse(row.Cells[0].Value?.ToString(), out int maKH))
                        {
                            isEditing = true;
                            originalMaKH = maKH;
                            btn_Luu.Text = "Lưu";
                            btn_Luu.BackColor = Color.Green;
                            btn_Luu.Enabled = true;

                            txt_MaKH.Enabled = true;
                            txt_TenKH.Enabled = true;
                            txt_SDT.Enabled = true;
                            txt_Diem.Enabled = true;

                            txt_MaKH.BackColor = Color.White;
                            txt_TenKH.BackColor = Color.White;
                            txt_SDT.BackColor = Color.White;
                            txt_Diem.BackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi chọn dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            LamMoi();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {

        }
    }
}