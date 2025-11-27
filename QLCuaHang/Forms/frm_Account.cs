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
    public partial class frm_Account : Form
    {
        private readonly AccountBus accountBus = new AccountBus();
        private bool isNew = true;
        private List<Account> danhSachAccount = new List<Account>();

        public frm_Account()
        {
            InitializeComponent();
        }

        private void frm_Account_Load(object sender, EventArgs e)
        {
            LoadDanhSachAccount();

            cbo_Role.DataSource = accountBus.LayTatCaRoleNames();

            cbo_Actived.Items.Add("True");
            cbo_Actived.Items.Add("False");
            cbo_Actived.SelectedIndex = 0;
        }

        private void LoadDanhSachAccount()
        {
            danhSachAccount = accountBus.LayTatCa();
            dgv_NhanVien.DataSource = null;
            dgv_NhanVien.DataSource = danhSachAccount;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AccountName.Text))
            {
                MessageBox.Show("AccountName không được để trống!");
                return;
            }

            Account acc = new Account
            {
                AccountName = txt_AccountName.Text,
                Password = txt_MatKhau.Text,
                FullName = txt_HoTen.Text,
                Email = txt_Email.Text,
                Tell = mtxt_SDT.Text,
            };

            string selectedRoleName = cbo_Role.SelectedItem?.ToString();
            bool isActived = cbo_Actived.SelectedItem?.ToString() == "True";

            if (string.IsNullOrEmpty(selectedRoleName))
            {
                MessageBox.Show("Vui lòng chọn Role cho tài khoản!");
                return;
            }

            try
            {
                if (isNew)
                {
                    accountBus.ThemMoi(acc);
                    MessageBox.Show("Thêm tài khoản thành công!");
                }
                else
                {
                    accountBus.CapNhat(acc);
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                }
                accountBus.CapNhatRoleChoAccount(acc.AccountName, selectedRoleName, isActived);

                LoadDanhSachAccount();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txt_AccountName.Text = "";
            txt_HoTen.Text = "";
            txt_Email.Text = "";
            mtxt_SDT.Text = "";
            txt_MatKhau.Text = "";

            isNew = true;
            txt_AccountName.Enabled = true;
            txt_AccountName.Focus();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachAccount();
            }
            else
            {
                var ketQua = accountBus.TimKiem(keyword);
                dgv_NhanVien.DataSource = null;
                dgv_NhanVien.DataSource = ketQua;
            }
        }

        private void dgv_NhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_NhanVien.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
                e.Value = new string('*', e.Value.ToString().Length);         
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                string accName = dgv_NhanVien.SelectedRows[0].Cells["AccountName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                        "Bạn có chắc muốn VÔ HIỆU HÓA nhân viên này? (Chuyển trạng thái sang False)",
                        "Xác nhận vô hiệu hóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    accountBus.VoHieuHoa(accName);
                    MessageBox.Show($"Đã vô hiệu hóa tài khoản {accName}.");
                    LoadDanhSachAccount();
                    ClearForm();
                }
            }
        }

        private void dgv_NhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgv_NhanVien.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dgv_NhanVien.ClearSelection();
                    dgv_NhanVien.Rows[hit.RowIndex].Selected = true;
                }    
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên nhân viên cần tìm...")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                txt_TimKiem.Text = "Nhập tên nhân viên cần tìm...";
                txt_TimKiem.ForeColor = Color.Gray;
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;

            Account acc = danhSachAccount[e.RowIndex];
            txt_AccountName.Text = acc.AccountName;
            txt_HoTen.Text = acc.FullName;
            txt_Email.Text = acc.Email;
            mtxt_SDT.Text = acc.Tell;
            txt_MatKhau.Text = acc.Password;

            if (!string.IsNullOrEmpty(acc.RoleName))
                cbo_Role.SelectedItem = acc.RoleName;
            cbo_Actived.SelectedItem = acc.Actived ? "True" : "False";

            txt_AccountName.Enabled = false;
            isNew = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
