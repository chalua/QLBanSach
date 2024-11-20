using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBS;

namespace BLL_QLBS
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanQuyen = new PhanQuyenDAL();
        public PhanQuyenBLL()
        {

        }
        public List<UserDTO> loadDataEmployee()
        {
            return phanQuyen.loadDataEmployee();
        }
    }
}
