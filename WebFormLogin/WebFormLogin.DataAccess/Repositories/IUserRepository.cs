using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;

namespace WebFormLogin.DataAccess.Repositories
{
    public interface IUserRepository: IBaseRepository<User>
    {
    }
}
