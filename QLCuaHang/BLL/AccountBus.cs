using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class AccountBus
    {
        public List<Account> LayTatCa()
        {
            return AccountDAO.Instance.GetAllAccounts();
        }

        public void ThemMoi(Account acc)
        {
            AccountDAO.Instance.Insert(acc);
        }

        public void CapNhat(Account acc)
        {
            AccountDAO.Instance.Update(acc);
        }

        public void Xoa(string accounName)
        {
            AccountDAO.Instance.Delete(accounName);
        }

        public Account DangNhap(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        public List<Account> TimKiem(string fullName)
        {
            return AccountDAO.Instance.SearchAccountByFullName(fullName);
        }

        public Account LayTheoAccountName(string accountName)
        {
            return AccountDAO.Instance.GetAccountByID(accountName);
        }

        public List<string> LayTatCaRoleNames()
        {
            return new List<string> { "admin", "nhanvien" };
        }

        public void CapNhatRoleChoAccount(string accountName, string roleName, bool isActived)
        {
            AccountDAO.Instance.UpdateRoleAccount(accountName, roleName, isActived);
        }

        public void VoHieuHoa(string accountName)
        {
            AccountDAO.Instance.DeactivateAccount(accountName);
        }
    }
}
