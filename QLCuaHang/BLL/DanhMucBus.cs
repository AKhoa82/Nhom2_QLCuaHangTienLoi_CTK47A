using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHang.DAO;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class DanhMucBus
    {
        public List<DanhMuc> LayTatCa()
        {
            return DanhMucDAO.Instance.GetAll_DanhMuc();
        }
        public bool XoaDanhMuc(int maDanhMuc)
        {
            return DanhMucDAO.Instance.Delete_DanhMuc(maDanhMuc);
        }
    }
}
