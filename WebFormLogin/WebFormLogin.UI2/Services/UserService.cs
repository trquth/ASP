using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;
using WebFormLogin.DataAccess.Repositories;

namespace WebFormLogin.UI2.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository = new UserRepository();
        public User AddUser(User user)
        {
            return userRepository.Insert(user);
        }
    }
}
