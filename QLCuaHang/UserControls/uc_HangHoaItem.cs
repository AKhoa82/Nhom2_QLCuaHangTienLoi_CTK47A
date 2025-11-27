using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.Untils;

namespace QLCuaHang
{
    public partial class uc_HangHoaItem : UserControl
    {
        private readonly HangHoa hh;

        public int HangHoaID => hh.MaHH;

        public decimal GiaBan
        {
            get => nm_GiaBan.Value;
            set => nm_GiaBan.Value = value;
        }

        public int SoLuong
        {
            get => (int)nm_SoLuong.Value;
            set => nm_SoLuong.Value = value;
        }

        public event EventHandler SoLuongChanged;
        public event EventHandler GiaBanChanged;

        public string TongTienStr { get => (nm_SoLuong.Value * nm_GiaBan.Value).ToString(); }
        public uc_HangHoaItem(HangHoa hangHoa)
        {
            InitializeComponent();

            this.hh = hangHoa;

            txt_TieuDe.Text = hangHoa.TenHH;

            nm_GiaBan.Minimum = 0;
            nm_GiaBan.Maximum = 1000000;
            nm_GiaBan.Value = hangHoa.GiaBan;

            nm_SoLuong.Value = 1;

            CapNhatTongTien();

            nm_SoLuong.ValueChanged += Nm_ValueChanged;
            nm_GiaBan.ValueChanged += Nm_ValueChanged;

            var imagePath = DirectoryUtils.GetPathTo("data", "hanghoa", hh.HinhAnh);
            pb_HinhMinhHoa.ImageLocation = imagePath;
        }

        private void CapNhatTongTien()
        {
            txtTongTien.Text = (nm_SoLuong.Value * nm_GiaBan.Value).ToString("N0");
        }

        private void Nm_ValueChanged(object sender, EventArgs e)
        {
            if (sender == nm_SoLuong)
            {
                if (nm_SoLuong.Value > hh.SoLuongTon)
                {
                    MessageBox.Show($"Số lượng vượt quá tồn kho!\nTồn kho: {hh.SoLuongTon}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nm_SoLuong.Value = hh.SoLuongTon;
                    return;
                }
                SoLuongChanged?.Invoke(this, EventArgs.Empty);
            }

            if (sender == nm_GiaBan)
                GiaBanChanged?.Invoke(this, EventArgs.Empty);
            CapNhatTongTien();
        }

        public void AddSoLuong(int soLuong)
        {
            nm_SoLuong.Value += soLuong;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as MainForm;
            this.Parent.Controls.Remove(this);

            parentForm?.BeginInvoke(new Action(() =>
            {
                parentForm.CapNhatTongTien();
            }));
        }
    }
}
