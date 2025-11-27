using QLCuaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO _instance;

        public static PhieuNhapDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhieuNhapDAO();
                return _instance;
            }
        }

        private PhieuNhapDAO() { }

        
        public List<PhieuNhap> GetAllPhieuNhapWithDetails()
        {
            try
            {
                
                string procName = "PhieuNhap_GetAllWithDetails";
                DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
                List<PhieuNhap> dsPhieuNhap = new List<PhieuNhap>();

                foreach (DataRow row in data.Rows)
                {
                    dsPhieuNhap.Add(new PhieuNhap(row));
                }
                return dsPhieuNhap;
            }
            catch
            {
                
                return GetAllPhieuNhapWithDetailsByQuery();
            }
        }

        
        public List<PhieuNhap> GetAllPhieuNhapWithDetailsByQuery()
        {
            string query = @"
                SELECT 
                    pn.MaPN,
                    pn.NgayNhap,
                    pn.AccountName,/
                    pn.MaNCC,
                    a.FullName as TenNhanVien,
                    ncc.TenNCC as TenNhaCungCap,
                    ncc.SĐT as SDT_NCC,
                    ncc.DiaChi as DiaChi_NCC,
                    ISNULL(SUM(ctpn.SoLuong), 0) as TongSoLuong,
                    ISNULL(SUM(ctpn.ThanhTien), 0) as TongTien
                FROM PhieuNhap pn
                LEFT JOIN Account a ON pn.AccountName = a.AccountName
                LEFT JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
                LEFT JOIN ChiTietPhieuNhap ctpn ON pn.MaPN = ctpn.MaPN
                GROUP BY pn.MaPN, pn.NgayNhap, pn.AccountName, pn.MaNCC, a.FullName, ncc.TenNCC, ncc.SĐT, ncc.DiaChi
                ORDER BY pn.NgayNhap DESC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<PhieuNhap> dsPhieuNhap = new List<PhieuNhap>();

            foreach (DataRow row in data.Rows)
            {
                dsPhieuNhap.Add(new PhieuNhap(row));
            }
            return dsPhieuNhap;
        }

        
        public List<PhieuNhap> GetAllPhieuNhap()
        {
            string procName = "PhieuNhap_GetAll";
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
            List<PhieuNhap> dsPhieuNhap = new List<PhieuNhap>();

            foreach (DataRow row in data.Rows)
            {
                dsPhieuNhap.Add(new PhieuNhap(row));
            }
            return dsPhieuNhap;
        }

        
        public PhieuNhap GetPhieuNhapByID(int maPN)
        {
            string procName = "PhieuNhap_GetByID";
            SqlParameter param = new SqlParameter("@MaPN", maPN);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);

            if (data.Rows.Count > 0)
            {
                return new PhieuNhap(data.Rows[0]);
            }

            return null;
        }

        
        public int InsertPhieuNhap(DateTime ngayNhap, string accountName, int maNCC)
        {
            string procName = "PhieuNhap_Insert";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NgayNhap", ngayNhap),
                new SqlParameter("@AccountName", accountName),
                new SqlParameter("@MaNCC", maNCC)
            };

            
            int affected = DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters);
            if (affected <= 0)
                return -1;

            string getNewQuery = @"select top 1 MaPN from PhieuNhap where AccountName=@AccountName and MaNCC=@MaNCC order by MaPN desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(getNewQuery,
                new SqlParameter("@AccountName", accountName),
                new SqlParameter("@MaNCC", maNCC));
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return -1;
        }

       
        public int UpdatePhieuNhap(int maPN, DateTime ngayNhap, string accountName, int maNCC)
        {
            string procName = "PhieuNhap_Update";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPN", maPN),
                new SqlParameter("@NgayNhap", ngayNhap),
                new SqlParameter("@AccountName", accountName),
                new SqlParameter("@MaNCC", maNCC)
            };

            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters);
        }

        
        public int DeletePhieuNhap(int maPN)
        {
            string procName = "PhieuNhap_Delete";
            SqlParameter param = new SqlParameter("@MaPN", maPN);

            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, param);
        }

        
        public List<PhieuNhap> GetPhieuNhapByNhaCungCap(int maNCC)
        {
            string query = @"
                SELECT pn.*, a.FullName as TenNhanVien, ncc.TenNCC as TenNhaCungCap,
                       ncc.SĐT as SDT_NCC, ncc.DiaChi as DiaChi_NCC,
                       ISNULL(SUM(ctpn.SoLuong), 0) as TongSoLuong,
                       ISNULL(SUM(ctpn.ThanhTien), 0) as TongTien
                FROM PhieuNhap pn
                LEFT JOIN Account a ON pn.AccountName = a.AccountName
                LEFT JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
                LEFT JOIN ChiTietPhieuNhap ctpn ON pn.MaPN = ctpn.MaPN
                WHERE pn.MaNCC = @MaNCC
                GROUP BY pn.MaPN, pn.NgayNhap, pn.AccountName, pn.MaNCC, a.FullName, ncc.TenNCC, ncc.SĐT, ncc.DiaChi
                ORDER BY pn.NgayNhap DESC";

            SqlParameter param = new SqlParameter("@MaNCC", maNCC);
            DataTable data = DataProvider.Instance.ExecuteQuery(query, param);
            List<PhieuNhap> dsPhieuNhap = new List<PhieuNhap>();

            foreach (DataRow row in data.Rows)
            {
                dsPhieuNhap.Add(new PhieuNhap(row));
            }
            return dsPhieuNhap;
        }
    }
}
