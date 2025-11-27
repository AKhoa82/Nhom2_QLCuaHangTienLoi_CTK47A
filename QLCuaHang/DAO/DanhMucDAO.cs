using QLCuaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO _instance;

        public static DanhMucDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DanhMucDAO();
                return _instance;
            }
        }

        private DanhMucDAO()
        {
        
        }

        public List<DanhMuc> GetAll_DanhMuc()
        {
            string query = "EXEC DanhMucHang_GetAll";
            List<DanhMuc> loaiHangHoas = new List<DanhMuc>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
                loaiHangHoas.Add(new DanhMuc(row));
            return loaiHangHoas;
        }
        public bool Insert_DanhMuc(string tenDanhMuc)
        {
            try
            {
                SqlParameter param = new SqlParameter("@TenDanhMuc", tenDanhMuc);
                int result = DataProvider.Instance.ExecuteNonQueryStoredProcedure("DanhMucHang_Insert", param);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm danh mục: {ex.Message}");
            }
        }

        public bool Delete_DanhMuc(int maDanhMuc)
        {
            try
            {
                SqlParameter param = new SqlParameter("@MaDM", maDanhMuc);
                int result = DataProvider.Instance.ExecuteNonQueryStoredProcedure("DanhMucHang_Delete", param);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa danh mục: {ex.Message}");
            }
        }
    }
}
