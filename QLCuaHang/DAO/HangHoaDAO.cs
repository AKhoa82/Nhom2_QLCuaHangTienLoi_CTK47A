using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO _instance;

        public static HangHoaDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HangHoaDAO();
                return _instance;
            }
        }

        private HangHoaDAO() { }

        public List<HangHoa> GetAllHangHoa()
        {
            string procName = "SanPham_GetAll";

            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
            List<HangHoa> dsHangHoa = new List<HangHoa>();

            foreach (DataRow row in data.Rows)
                dsHangHoa.Add(new HangHoa(row));
            return dsHangHoa;
        }

        public List<HangHoa> GetAllHangHoaByDanhMuc(int loaiHangHoaId)
        {
            string procName = "SanPham_GetByDanhMuc";
            SqlParameter param = new SqlParameter("@MaDanhMuc", loaiHangHoaId);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);
            List<HangHoa> dsHangHoa = new List<HangHoa>();

            foreach (DataRow row in data.Rows)
                dsHangHoa.Add(new HangHoa(row));

            return dsHangHoa;
        }

        public List<HangHoa> SearchHangHoaByTenHangHoa(string tenHangHoa)
        {
            string procName = "SanPham_SearchByName";
            SqlParameter param = new SqlParameter("@TenSP", tenHangHoa);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);
            List<HangHoa> result = new List<HangHoa>();

            foreach (DataRow row in data.Rows)
                result.Add(new HangHoa(row));

            return result;
        }

        public bool UpdateHangHoa(int maHH, string tenHH, int maDanhMuc, string tenNCC, string donViTinh, decimal giaNhap, decimal giaBan, int soLuongTon, string hinhAnh)
        {
            string procName = "SanPham_Update";
            SqlParameter[] parameters = {
                new SqlParameter("@MaSP", maHH),
                new SqlParameter("@TenSP", tenHH),
                new SqlParameter("@MaDM", maDanhMuc),
                new SqlParameter("@TenNCC", tenNCC),
                new SqlParameter("@DonViTinh", donViTinh),
                new SqlParameter("@GiaNhap", giaNhap),
                new SqlParameter("@GiaBan", giaBan),
                new SqlParameter("@SoLuongTon", soLuongTon),
                new SqlParameter("@HinhAnh", hinhAnh ?? (object)DBNull.Value)
            };
            
            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters) > 0;
        }

        public bool DeleteHangHoa(int maHH)
        {
            string procName = "SanPham_Delete";
            SqlParameter param = new SqlParameter("@MaSP", maHH);
            
            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, param) > 0;
        }
        public bool InsertHangHoa(string tenHangHoa, int maDanhMuc, int maNCC, string donViTinh, decimal giaNhap, int soLuongTon, string hinhAnh)
        {
            string procName = "SanPham_Insert";
            SqlParameter[] parameters = {
                new SqlParameter("@TenSP", tenHangHoa),
                new SqlParameter("@MaDM", maDanhMuc),
                new SqlParameter("@MaNCC", maNCC),
                new SqlParameter("@DonViTinh", donViTinh),
                new SqlParameter("@GiaNhap", giaNhap),
                new SqlParameter("@SoLuongTon", soLuongTon),
                new SqlParameter("@HinhAnh", hinhAnh ?? (object)DBNull.Value)
            };
            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters) > 0;
        }

        public bool GiamSoLuongTon(int maHH, int soLuongGiam)
        {
            string procName = "SanPham_GiamSoLuongTon";
            SqlParameter[] parameters = {
                new SqlParameter("@MaSP", maHH),
                new SqlParameter("@SoLuongGiam", soLuongGiam)
            };

            return DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters) > 0;
        }
    }
}
