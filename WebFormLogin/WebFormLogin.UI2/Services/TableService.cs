using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;
using WebFormLogin.DataAccess.Repositories;

namespace WebFormLogin.UI2.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository tableRepository = new TableRepository();
        public IEnumerable<Table> GetAll()
        {
            return tableRepository.GetAll();
        }
    }
}
