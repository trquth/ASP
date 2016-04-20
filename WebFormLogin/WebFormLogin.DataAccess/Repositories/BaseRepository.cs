using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Models;

namespace WebFormLogin.DataAccess.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IEnumerable<TEntity> result = null;

            try
            {
                using (var db = new WebFormLoginContext())
                {
                    result = db.Set<TEntity>().Where(i => !i.IsDeleted).Where(predicate).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return result ?? Enumerable.Empty<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            IEnumerable<TEntity> result = null;
            try
            {
                using (var db = new WebFormLoginContext())
                {
                    result = db.Set<TEntity>().Where(i => !i.IsDeleted).ToList();
                }
            }
            catch (Exception)
            {
            }
            return result ?? Enumerable.Empty<TEntity>();
        }

        public TEntity GetById(Guid id)
        {
            TEntity entity = null;

            try
            {
                using (var db = new WebFormLoginContext())
                {
                    entity = db.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {

            }

            return entity;
        }

        public TEntity Insert(TEntity dto)
        {
            TEntity entity = null;

            try
            {
                using (var db = new WebFormLoginContext())
                {
                    entity = db.Set<TEntity>().Add(dto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
            return entity;
        }

        public TEntity SingleBy(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity entity = null;

            try
            {
                using (var db = new WebFormLoginContext())
                {
                    entity = db.Set<TEntity>().Where(i => !i.IsDeleted).FirstOrDefault(predicate);
                }
            }
            catch (Exception ex)
            {

            }

            return entity;
        }

        public TEntity Update(TEntity dto)
        {

            TEntity entity = null;

            try
            {
                using (var db = new WebFormLoginContext())
                {
                    entity = db.Set<TEntity>().Find(dto.Id);
                    if (entity != null)
                    {
                        db.Entry(entity).CurrentValues.SetValues(dto);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                entity = null;
            }
            return entity;
        }
    }
}
