using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.DTO;
using QLCuaHang.BLL;

namespace QLCuaHang
{
    public partial class frm_Login : Form
    {
        private Account LoggedInUser;
        private AccountBus accountBus = new AccountBus();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            string password = txt_MatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Test connection trước
                var dataProvider = QLCuaHang.DAO.DataProvider.Instance;
                dataProvider.TestConnection();

                Account user = accountBus.DangNhap(username, password);

                if (user != null)
                {
                    LoggedInUser = user;
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + user.FullName, "Thông báo");

                    this.Hide();
                    MainForm frm = new MainForm(user);
                    frm.FormClosed += (s, args) => this.Show();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
