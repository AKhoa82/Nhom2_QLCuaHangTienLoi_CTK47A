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
    public partial class frm_NhaphangMoi : Form
    {
        private List<HangHoa> _hangHoas;
        private Account _currentUser;
        private Timer _validationTimer;
        private Account _validatedAccount;
        
        
        public static Account GlobalCurrentUser { get; set; }

        public int? CreatedMaPN { get; private set; }

        public frm_NhaphangMoi(List<HangHoa> hangHoas, Account currentUser)
        {
            InitializeComponent();
            _hangHoas = hangHoas ?? new List<HangHoa>();
            _currentUser = currentUser ?? GlobalCurrentUser;
            
            _validationTimer = new Timer();
            _validationTimer.Interval = 500; // 500ms delay
            _validationTimer.Tick += ValidationTimer_Tick;
            
            Load += Frm_Nhaphang_Load;
            btnXacNhan.Click += BtnXacNhan_Click;
            btnHuy.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            txtNhanVien.TextChanged += TxtNhanVien_TextChanged;
        }

        private void Frm_Nhaphang_Load(object sender, EventArgs e)
        {
            try
            {
                var nccBus = new NhaCungCapBus();
                var dsNcc = nccBus.LayTatCa();
                
                if (dsNcc != null && dsNcc.Count > 0)
                {
                    cboNCC.DataSource = dsNcc;
                    cboNCC.DisplayMember = "TenNCC";
                    cboNCC.ValueMember = "MaNCC";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (_currentUser != null)
                {
                    txtNhanVien.Text = _currentUser.AccountName;
                }

                foreach (var hh in _hangHoas)
                {
                    int idx = dgvHangHoa.Rows.Add();
                    var row = dgvHangHoa.Rows[idx];
                    row.Cells["colChon"].Value = false;
                    row.Cells["colMaSP"].Value = hh.MaHH;
                    row.Cells["colTenSP"].Value = hh.TenHH;
                    row.Cells["colSoLuong"].Value = 0;
                    row.Cells["colDonGia"].Value = hh.GiaNhap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNhanVien_TextChanged(object sender, EventArgs e)
        {
            _validationTimer.Stop();
            
            _validatedAccount = null;
            
            string accountName = txtNhanVien.Text.Trim();
            if (!string.IsNullOrEmpty(accountName))
            {
                _validationTimer.Start();
            }
        }

        private void ValidationTimer_Tick(object sender, EventArgs e)
        {
            _validationTimer.Stop();
            
            ValidateEmployeeCode();
        }

        private void ValidateEmployeeCode()
        {
            try
            {
                string accountName = txtNhanVien.Text.Trim();
                if (string.IsNullOrEmpty(accountName))
                {
                    return;
                }

                var accountBus = new AccountBus();
                var account = accountBus.LayTheoAccountName(accountName);
                
                if (account != null)
                {
                    _validatedAccount = account;
                    txtNhanVien.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    _validatedAccount = null;
                    txtNhanVien.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                _validatedAccount = null;
                txtNhanVien.BackColor = System.Drawing.Color.LightPink;
                System.Diagnostics.Debug.WriteLine($"Lỗi kiểm tra mã nhân viên: {ex.Message}");
            }
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboNCC.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.");
                return;
            }
            string accountName = txtNhanVien.Text.Trim();
            if (string.IsNullOrEmpty(accountName))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
                return;
            }

            if (_validatedAccount == null)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
                return;
            }

            int maNcc = (int)cboNCC.SelectedValue;

            var details = new List<(int MaSP, int SoLuong, decimal DonGia)>();
            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                bool isChecked = row.Cells["colChon"].Value is bool b && b;
                if (!isChecked) continue;

                if (!int.TryParse(Convert.ToString(row.Cells["colMaSP"].Value), out int maSp)) continue;
                if (!int.TryParse(Convert.ToString(row.Cells["colSoLuong"].Value), out int soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải > 0 cho các hàng đã chọn.");
                    return;
                }
                if (!decimal.TryParse(Convert.ToString(row.Cells["colDonGia"].Value), out decimal donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }
                details.Add((maSp, soLuong, donGia));
            }

            if (details.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng hóa và nhập số lượng.");
                return;
            }

            try
            {
                var pnBus = new PhieuNhapBus();
                int maPN = pnBus.TaoPhieuNhap(DateTime.Now, accountName, maNcc);
                if (maPN <= 0)
                {
                    MessageBox.Show("Không tạo được phiếu nhập.");
                    return;
                }

                foreach (var d in details)
                {
                    pnBus.TaoChiTiet(maPN, d.MaSP, d.SoLuong, d.DonGia);
                }

                CreatedMaPN = maPN;
                MessageBox.Show($"Tạo phiếu nhập thành công!\nMã phiếu nhập: {maPN}\nNhân viên: {_validatedAccount.FullName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu phiếu nhập: {ex.Message}");
            }
        }

       
    }
}
