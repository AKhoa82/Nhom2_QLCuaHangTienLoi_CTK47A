using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHang.DTO;

namespace QLCuaHang.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO _instance;
        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChiTietHoaDonDAO();
                return _instance;
            }
        }

        private ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> GetChiTietHoaDonByMaHD(int maHD)
        {
            string procName = "ChiTietHoaDon_GetByID";
            SqlParameter param = new SqlParameter("@MaHD", maHD);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);
            List<ChiTietHoaDon> ds = new List<ChiTietHoaDon>();
            foreach (DataRow row in data.Rows)
                ds.Add(new ChiTietHoaDon(row));
            return ds;
        }

        public int InsertChiTietHoaDon(int maHD, int maSP, int soLuong, decimal donGia)
        {
            string procName = "ChiTietHoaDon_Insert";
            SqlParameter[] prms =
            {
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@MaSP", maSP),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGiaBan", donGia)
            };
            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, prms);
        }
    }
}
