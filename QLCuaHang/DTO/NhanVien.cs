using System;

namespace QLCuaHang.DTO
{
    // Class tạm thời để giải quyết lỗi compile
    // Sẽ được xóa sau khi hoàn thành migration
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public NhanVien(int maNV, string tenNV, string userName, string password, string role)
        {
            MaNV = maNV;
            TenNV = tenNV;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}

