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
    public class AccountDAO
    {
        private static AccountDAO _instance;
        public static AccountDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountDAO();
                return _instance;
            }
        }

        private AccountDAO() { }

        public List<Account> GetAllAccounts()
        {
            string procName = "Account_GetAll";
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName);
            List<Account> ds = new List<Account>();

            foreach (DataRow row in data.Rows)
            {
                if (row["RoleName"] == DBNull.Value)
                {
                    row["RoleName"] = string.Empty; // Gán chuỗi rỗng nếu RoleName là NULL
                }
                if (row["Actived"] == DBNull.Value)
                {
                    row["Actived"] = false; // Gán False nếu Actived là NULL
                }
                ds.Add(new Account(row));
            }
            return ds;
        }

        public Account GetAccountByID(string accountName)
        {
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(
                "Account_GetByID",
                new SqlParameter("@AccountName", accountName));

            if (data.Rows.Count == 0) return null;
            return new Account(data.Rows[0]);
        }

        public List<Account> SearchAccountByFullName(string fullName)
        {
            string procName = "Account_SearchByName"; 
            SqlParameter param = new SqlParameter("@FullName", fullName);
            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, param);

            List<Account> ds = new List<Account>();
            foreach (DataRow row in data.Rows)
                ds.Add(new Account(row));
            return ds;
        }

        public void Insert(Account acc)
        {
            DataProvider.Instance.ExecuteNonQueryStoredProcedure(
                "Account_Insert",
                new SqlParameter("@AccountName", acc.AccountName),
                new SqlParameter("@Password", acc.Password),
                new SqlParameter("@FullName", acc.FullName),
                new SqlParameter("@Email", (object)acc.Email ?? DBNull.Value),
                new SqlParameter("@Tell", (object)acc.Tell ?? DBNull.Value)
            );
        }

        public void Update(Account acc)
        {
            DataProvider.Instance.ExecuteNonQueryStoredProcedure(
                "Account_Update",
                new SqlParameter("@AccountName", acc.AccountName),
                new SqlParameter("@Password", acc.Password),
                new SqlParameter("@FullName", acc.FullName),
                new SqlParameter("@Email", (object)acc.Email ?? DBNull.Value),
                new SqlParameter("@Tell", (object)acc.Tell ?? DBNull.Value)
            );
        }

        public void Delete(string accountName)
        {
            DataProvider.Instance.ExecuteNonQueryStoredProcedure(
                "Account_Delete",
                new SqlParameter("@AccountName", accountName));
        }

        public Account Login(string username, string password)
        {
            string procName = "Account_Login";
            SqlParameter[] parameters =
            {
                new SqlParameter("@AccountName", username),
                new SqlParameter("@Password", password)
            };

            DataTable data = DataProvider.Instance.ExecuteStoredProcedure(procName, parameters);

            if (data.Rows.Count == 0)
                return null;

            Account acc = new Account(data.Rows[0]);
            acc.Roles = GetRoles(acc.AccountName);
            return acc;
        }

        public List<string> GetRoles(string accountName)
        {
            List<string> roles = new List<string>();
            DataTable dt = DataProvider.Instance.ExecuteStoredProcedure("RoleAccount_GetByAccount",
                new SqlParameter("@AccountName", accountName));
            foreach (DataRow row in dt.Rows)
                roles.Add(row["RoleName"].ToString());
            return roles;
        }

        public void UpdateRoleAccount(string accountName, string roleName, bool isActived)
        {
            string queryGetRoleID = "SELECT ID FROM Role WHERE RoleName = @RoleName";
            
            DataTable dtRole = DataProvider.Instance.ExecuteQuery(queryGetRoleID, new SqlParameter("@RoleName", roleName));
            if (dtRole.Rows.Count == 0 || dtRole.Rows[0]["ID"] == DBNull.Value) return;

            int roleId = Convert.ToInt32(dtRole.Rows[0]["ID"]);

            string deleteOldRolesQuery = "DELETE FROM RoleAccount WHERE AccountName = @AccountName";

            DataProvider.Instance.ExecuteQuery(deleteOldRolesQuery, new SqlParameter("@AccountName", accountName));

            DataProvider.Instance.ExecuteNonQueryStoredProcedure(
                "RoleAccount_Insert", 
                new SqlParameter("@AccountName", accountName),
                new SqlParameter("@RoleID", roleId),
                new SqlParameter("@Actived", isActived)
            );
        }

        public void DeactivateAccount(string accountName)
        {
            string queryGetRoleID = "SELECT RoleID FROM RoleAccount WHERE AccountName = @AccountName";
            DataTable roleData = DataProvider.Instance.ExecuteQuery(queryGetRoleID, new SqlParameter("@AccountName", accountName));

            if (roleData.Rows.Count > 0)
            {
                int roleId = Convert.ToInt32(roleData.Rows[0]["RoleID"]);

                DataProvider.Instance.ExecuteNonQueryStoredProcedure(
                    "RoleAccount_Update",
                    new SqlParameter("@AccountName", accountName),
                    new SqlParameter("@RoleID", roleId),
                    new SqlParameter("@Actived", false),
                    new SqlParameter("@Notes", DBNull.Value) 
                );
            }
        }
    }
}