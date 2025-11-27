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
    public partial class frm_ThemDanhMuc : Form
    {
        public frm_ThemDanhMuc()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txt_TenDanhMuc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenDanhMuc.Focus();
                    return;
                }

                
                var dsDanhMuc = DanhMucDAO.Instance.GetAll_DanhMuc();
                if (dsDanhMuc.Any(dm => dm.TenDanhMuc.ToLower() == txt_TenDanhMuc.Text.ToLower()))
                {
                    MessageBox.Show("Danh mục này đã tồn tại!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenDanhMuc.Focus();
                    return;
                }

                // Thêm danh mục mới vào database
                bool result = DanhMucDAO.Instance.Insert_DanhMuc(txt_TenDanhMuc.Text.Trim());
                
                if (result)
                {
                    MessageBox.Show("Thêm danh mục thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Đóng form và trả về DialogResult.OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm danh mục!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txt_TenDanhMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép Enter để thêm danh mục
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Them_Click(sender, e);
            }
            // Cho phép Escape để hủy
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btn_Huy_Click(sender, e);
            }
        }
    }
}
