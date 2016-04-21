using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;

namespace WebFormLogin.UI2.Services
{
    public interface IUserService
    {
        User AddUser(User user);
        bool CheckUserNameExist(string userName);
        bool CheckUserNameAndPassword(string userName, string password);
    }
}
