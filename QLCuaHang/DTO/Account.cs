using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class Account
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Tell { get; set; }
        public DateTime DateCreated { get; set; }

        public List<string> Roles { get; set; } = new List<string>();
        public string RoleName { get; set; }
        public bool Actived { get; set; }
        public Account() { }

        public Account(DataRow row)
        {
            AccountName = row["AccountName"].ToString();
            Password = row["Password"].ToString();
            FullName = row["FullName"].ToString();
            Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : null;
            Tell = row["Tell"] != DBNull.Value ? row["Tell"].ToString() : null;
            DateCreated = Convert.ToDateTime(row["DateCreated"]);

            if (row.Table.Columns.Contains("RoleName"))
                RoleName = row["RoleName"].ToString();
            if (row.Table.Columns.Contains("Actived"))
                Actived = Convert.ToBoolean(row["Actived"]);
        }
    }
}
