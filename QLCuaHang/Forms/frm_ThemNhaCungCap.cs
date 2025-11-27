using System;
using System.Windows.Forms;
using QLCuaHang.BLL;

namespace QLCuaHang.Forms
{
	public partial class frm_ThemNhaCungCap : Form
	{
		public frm_ThemNhaCungCap()
		{
            InitializeComponent();
			btnLuu.Click += btn_Luu_Click;
			btnHuy.Click += btn_Huy_Click;
		}

		private void btn_Luu_Click(object sender, EventArgs e)
		{
			var ten = txtTen.Text?.Trim();
			if (string.IsNullOrWhiteSpace(ten))
			{
				MessageBox.Show("Tên NCC không được trống");
				return;
			}
			var bus = new NhaCungCapBus();
			if (bus.ThemNhaCungCap(ten, txtSDT.Text?.Trim(), txtDiaChi.Text?.Trim()))
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Thêm NCC thất bại");
			}
		}

		private void btn_Huy_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
