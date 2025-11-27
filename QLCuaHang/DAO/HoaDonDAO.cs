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
    public class HoaDonDAO
    {
        private static HoaDonDAO _instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonDAO();
                return _instance;
            }
        }

        private HoaDonDAO() { }

        public List<HoaDon> GetAllHoaDon()
        {
            string procName = "HoaDon_GetAll";
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
            List<HoaDon> ds = new List<HoaDon>();
            foreach (DataRow row in data.Rows)
                ds.Add(new HoaDon(row));
            return ds;
        }

        public List<HoaDon> GetHoaDonByDate(DateTime tuNgay, DateTime denNgay)
        {
            string procName = "HoaDon_GetByDate";
            SqlParameter[] param =
            {
                new SqlParameter("@TuNgay",tuNgay),
                new SqlParameter("@DenNgay",denNgay)
            };
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);
            List<HoaDon> ds = new List<HoaDon>();
            foreach (DataRow row in data.Rows)
                ds.Add(new HoaDon(row));
            return ds;
        }

        public int InsertHoaDon(DateTime ngayLap, int? maKH, decimal tongTien, int giamGia, string accountName)
        {
            string procName = "HoaDon_Insert";
            SqlParameter[] prms =
            {
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@MaKH", maKH.HasValue ? (object)maKH.Value : DBNull.Value),
                new SqlParameter("@TongTien", tongTien),
                new SqlParameter("@GiamGia", giamGia),
                new SqlParameter("@AccountName", accountName)
            };
            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, prms);
        }
    }
}
