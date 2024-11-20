using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENUM;

namespace DAL_QLBS
{
    public class PhanQuyenDAL
    {
        BookManagementDataContext qlbs = new BookManagementDataContext();
        public PhanQuyenDAL()
        {

        }
        public List<UserDTO> loadDataEmployee()
        {
            var e = (from t in qlbs.users where t.code_role != Role.CUSTOMER.ToString() select new UserDTO {
                HoTen = t.full_name,
                SoDienThoai = t.phone,
                NgaySinh = t.date_of_birth.ToString(),
                GioiTinh = t.gender,
                Email = t.email,
                DiaChi = t.address,
                ChucVu = t.code_role,
            }).ToList();
            return e;
        }
    }
}
