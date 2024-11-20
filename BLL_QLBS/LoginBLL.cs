using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBS;
using DTO_QLBS;

namespace BLL_QLBS
{
    public class LoginBLL
    {
        LoginDAL login = new LoginDAL();

        public LoginBLL()
        {

        }
        public string getNameUserName(string username, string password)
        {
            return login.getNameUserName(username, password);   
        }

        public bool getUserNameAndPassword(string username, string password)
        {
            return login.getUserNameAndPassword(username, password); 
        }
    }
}
