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
    public partial class frm_XoaDanhMuc : Form
    {
        DanhMucBus danhMucBus = new DanhMucBus();
        List<DanhMuc> dsDanhMuc = new List<DanhMuc>();

        public frm_XoaDanhMuc()
        {
            InitializeComponent();
        }

        private void frm_XoaDanhMuc_Load(object sender, EventArgs e)
        {
            TaiDanhSachDanhMuc();
        }

        void TaiDanhSachDanhMuc()
        {
            try
            {
                dsDanhMuc = danhMucBus.LayTatCa();
                
                cbo_DanhMuc.DataSource = new List<DanhMuc>(dsDanhMuc);
                cbo_DanhMuc.DisplayMember = "TenDanhMuc";
                cbo_DanhMuc.ValueMember = "MaDanhMuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách danh mục: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_DanhMuc.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DanhMuc selectedDanhMuc = cbo_DanhMuc.SelectedItem as DanhMuc;
                if (selectedDanhMuc == null) return;

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa danh mục '{selectedDanhMuc.TenDanhMuc}'?\n\n" +
                    "Lưu ý: Tất cả hàng hóa thuộc danh mục này cũng sẽ bị ảnh hưởng!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = danhMucBus.XoaDanhMuc(selectedDanhMuc.MaDanhMuc);

                    if (success)
                    {
                        MessageBox.Show("Xóa danh mục thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TaiDanhSachDanhMuc();

                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa danh mục thất bại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
