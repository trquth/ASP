using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;
using WebFormLogin.DataAccess.Repositories;
using WebFormLogin.UI2.Infrastructures;

namespace WebFormLogin.UI2.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository = new UserRepository();
        public User AddUser(User user)
        {
            return userRepository.Insert(user);
        }

        public bool CheckUserNameAndPassword(string userName, string password)
        {
            var model = userRepository.SingleBy(x => (x.UserName == userName&&x.Password==password));
            if (model.IsNotNull())
            {
                return true;
            }
            return false;
        }

        public bool CheckUserNameExist(string userName)
        {
            var model = userRepository.SingleBy(x => x.Name == userName);
            if (model.IsNotNull())
            {
                return true;
            }
            return false;
        }
    }
}
