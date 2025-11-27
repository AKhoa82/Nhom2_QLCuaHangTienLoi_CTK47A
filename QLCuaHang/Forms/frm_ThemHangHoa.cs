using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace QLCuaHang.Forms
{
	public partial class frm_ThemHangHoa : Form
	{
		private readonly DanhMucBus _dmBus = new DanhMucBus();
		private readonly NhaCungCapBus _nccBus = new NhaCungCapBus();
		private readonly HangHoaBus _hhBus = new HangHoaBus();

		public frm_ThemHangHoa()
		{
			InitializeComponent();
			Load += Frm_ThemHangHoa_Load;
			btnThemNCC.Click += BtnThemNCC_Click;
			btnLuu.Click += btn_Luu_Click;
			btnHuy.Click += btn_Huy_Click;
		}

		private void Frm_ThemHangHoa_Load(object sender, EventArgs e)
		{
			var dsDM = _dmBus.LayTatCa();
			var suggest = new AutoCompleteStringCollection();
			suggest.AddRange(dsDM.ConvertAll(dm => dm.TenDanhMuc).ToArray());
			txtDanhMuc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtDanhMuc.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtDanhMuc.AutoCompleteCustomSource = suggest;

			ReloadNhaCungCap();
		}

		private void ReloadNhaCungCap()
		{
			try
			{
				var dsNCC = _nccBus.LayTatCa();
				if (dsNCC != null && dsNCC.Count > 0)
				{
					cboNhaCC.DataSource = dsNCC;
					cboNhaCC.DisplayMember = "TenNCC";
					cboNhaCC.ValueMember = "MaNCC";
				}
				else
				{
					MessageBox.Show("Không có dữ liệu nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi tải nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnThemNCC_Click(object sender, EventArgs e)
		{
			using (var f = new frm_ThemNhaCungCap())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					ReloadNhaCungCap();
				}
			}
		}

		private void btn_Luu_Click(object sender, EventArgs e)
		{
			string ten = txtTenSP.Text?.Trim();
			if (string.IsNullOrWhiteSpace(ten))
			{
				MessageBox.Show("Tên sản phẩm không được trống");
				return;
			}
			if (string.IsNullOrWhiteSpace(txtDanhMuc.Text) || cboNhaCC.SelectedValue == null)
			{
				MessageBox.Show("Vui lòng nhập danh mục và chọn nhà cung cấp");
				return;
			}
			if (!decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) || giaNhap < 0)
			{
				MessageBox.Show("Giá nhập không hợp lệ");
				return;
			}
			if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
			{
				MessageBox.Show("Số lượng không hợp lệ");
				return;
			}

			// Resolve category ID from entered name
			int maDM = -1;
			foreach (var dm in _dmBus.LayTatCa())
			{
				if (string.Equals(dm.TenDanhMuc?.Trim(), txtDanhMuc.Text.Trim(), StringComparison.OrdinalIgnoreCase))
				{
					maDM = dm.MaDanhMuc;
					break;
				}
			}
			if (maDM == -1)
			{
				MessageBox.Show("Danh mục không tồn tại. Vui lòng nhập đúng tên.");
				return;
			}
			int maNCC = (int)cboNhaCC.SelectedValue;

			bool ok = _hhBus.ThemHangHoa(ten, maDM, maNCC, "", giaNhap, soLuong, null);
			if (ok)
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Thêm hàng hóa thất bại");
			}
		}

		private void btn_Huy_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

        
    }
}
