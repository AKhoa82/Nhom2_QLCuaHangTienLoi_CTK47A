using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.Untils;

namespace QLCuaHang
{
    public partial class uc_HangHoaBox : UserControl
    {
        public uc_HangHoaBox(string tenHH, decimal soTien, string hinh= "default")
        {
            InitializeComponent();
            txt_SoTien.Text = soTien.ToString("N0", new CultureInfo("vi-VN"));
            txt_TenHH.Text = tenHH;
            string imageRelativeFolder = "data";
            string imageFileName = string.IsNullOrEmpty(hinh) ? "default.png" : hinh;
            var imagePath = DirectoryUtils.GetPathTo(imageRelativeFolder, "hanghoa", imageFileName);
            pb_Hinh.ImageLocation = imagePath;
        }
    }
}
