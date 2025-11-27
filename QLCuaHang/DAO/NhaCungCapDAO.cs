using QLCuaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO _instance;

        public static NhaCungCapDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhaCungCapDAO();
                return _instance;
            }
        }

        private NhaCungCapDAO() { }

        
        public List<NhaCungCap> GetAllNhaCungCap()
        {
            try
            {
                string procName = "NhaCungCap_GetAll"; 
                DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
                List<NhaCungCap> dsNhaCungCap = new List<NhaCungCap>();

                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dsNhaCungCap.Add(new NhaCungCap(row));
                    }
                }
                return dsNhaCungCap;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách nhà cung cấp: {ex.Message}", ex);
            }
        }

        
        public NhaCungCap GetNhaCungCapByID(int maNCC)
        {
            string procName = "NhaCungCap_GetByID";
            SqlParameter param = new SqlParameter("@MaNCC", maNCC);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);

            if (data.Rows.Count > 0)
            {
                return new NhaCungCap(data.Rows[0]);
            }

            return null; 
        }

        public bool InsertNhaCungCap(string tenNCC, string sdt, string diaChi)
        {
            string procName = "NhaCungCap_Insert";
            SqlParameter[] prms = new SqlParameter[]
            {
                new SqlParameter("@TenNCC", tenNCC),
                new SqlParameter("@SĐT", (object)sdt ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)diaChi ?? DBNull.Value)
            };
            int result = DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, prms);
            return result > 0;
        }
    }
}