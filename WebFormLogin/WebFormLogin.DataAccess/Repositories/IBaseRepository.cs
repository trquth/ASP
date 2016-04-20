using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;

namespace WebFormLogin.DataAccess.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T Insert(T dto);
        T Update(T dto);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T SingleBy(Expression<Func<T, bool>> predicate);
    }
}
