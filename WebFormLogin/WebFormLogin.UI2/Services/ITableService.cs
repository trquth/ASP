using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WebFormLogin.UI2.Services
{
    public interface ITableService
    {
        IEnumerable<WebFormLogin.DataAccess.Models.Table> GetAll();
    }
}
