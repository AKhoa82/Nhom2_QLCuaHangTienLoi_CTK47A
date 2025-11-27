using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO _instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KhachHangDAO();
                return _instance;
            }
        }

        private KhachHangDAO() { }

        public List<KhachHang> GetAllKhachHang()
        {
            string procName = "KhachHang_GetAll";
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
            List<KhachHang> dsKhachHang = new List<KhachHang>();

            foreach (DataRow row in data.Rows)
                dsKhachHang.Add(new KhachHang(row));
            return dsKhachHang;
        }

        public bool InsertKhachHang(KhachHang kh)
        {
            try
            {
                string procName = "KhachHang_Insert";
                SqlParameter[] parameters = {
                    new SqlParameter("@TenKH", kh.TenKH),
                    new SqlParameter("@SĐT", kh.SĐT ?? ""),
                    new SqlParameter("@DiemTichLuy", kh.DiemTichLuy)
                };

                DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters);

                return IsKhachHangExists(kh.TenKH, kh.SĐT);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi InsertKhachHang: {ex.Message}");
                System.Windows.Forms.MessageBox.Show($"Chi tiết lỗi database: {ex.Message}", "Debug",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                return false;
            }
        }

        private bool IsKhachHangExists(string tenKH, string sdt)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM KhachHang WHERE TenKH = @TenKH AND [SĐT] = @SĐT";
                SqlParameter[] parameters = {
                    new SqlParameter("@TenKH", tenKH),
                    new SqlParameter("@SĐT", sdt ?? "")
                };

                var result = DataProvider.Instance.ExecuteQuery(query, parameters);
                if (result.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(result.Rows[0][0]);
                    return count > 0;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateKhachHang(KhachHang kh)
        {
            try
            {
                string procName = "KhachHang_Update";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaKH", kh.MaKH),
                    new SqlParameter("@TenKH", kh.TenKH),
                    new SqlParameter("@SĐT", kh.SĐT),
                    new SqlParameter("@LoaiKH", kh.LoaiKH),
                    new SqlParameter("@DiemTichLuy", kh.DiemTichLuy)
                };

                DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteKhachHang(int maKH)
        {
            try
            {
                string procName = "KhachHang_Delete";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaKH", maKH)
                };

                DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<KhachHang> SearchKhachHangByName(string keyword)
        {
            string procName = "KhachHang_SearchByName";
            SqlParameter param = new SqlParameter("@TenKH", keyword);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);

            List<KhachHang> result = new List<KhachHang>();
            foreach (DataRow row in data.Rows)
            {
                int diem = Convert.ToInt32(row["DiemTichLuy"]);
                string loaiKH = XacDinhLoaiKH(diem);

                result.Add(new KhachHang(
                    Convert.ToInt32(row["MaKH"]),
                    row["TenKH"].ToString(),
                    row["SĐT"].ToString(),
                    diem
                ));
            }
            return result;
        }

        private string XacDinhLoaiKH(int diem)
        {
            if (diem < 100) return "Thường";
            else if (diem < 500) return "Thân thiết";
            else return "VIP";
        }

        public int GetMaKHBySDT(string sdt)
        {
            string procName = "KhachHang_GetBySDT";
            SqlParameter prm = new SqlParameter("@SĐT", sdt);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, prm);

            if (data.Rows.Count > 0)
                return Convert.ToInt32(data.Rows[0]["MaKH"]);

            return -1;
        }

        public void UpdateDiemTichLuy(int maKH, int soDiemCongThem)
        {
            string procName = "KhachHang_UpdateDiem";
            SqlParameter[] prms = new SqlParameter[]
            {
                new SqlParameter("@MaKH", maKH),
                new SqlParameter("@SoDiemCongThem", soDiemCongThem)
            };
            DataProvider.Instance.ExecuteNonQueryStoredProcedure(procName, prms);
        }
    }
}
