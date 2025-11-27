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
            CapNhatTongTien();
        }

        public void AddSoLuong(int soLuong)
        {
            nm_SoLuong.Value += soLuong;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
