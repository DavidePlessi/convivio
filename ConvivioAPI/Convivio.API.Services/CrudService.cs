using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Convivio.API.Entities;
using Convivio.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Convivio.API.Services
{
    public abstract class CrudService<T, TDbContext> : BaseService<TDbContext>, ICrudService<T>
        where T : Entity, new()
        where TDbContext : DbContext
    {
        protected CrudService(TDbContext dbContext) : base(dbContext) { }
        
        public long Delete(int id)
        {
            var entityToDelete = new T { Id = id };
            DbContext.Remove(entityToDelete);
            DbContext.SaveChanges();

            return 1;
        }

        public List<T> LoadAll()
        {
            return DbContext.Set<T>().ToList();
        }

        public List<TResult> LoadAndSelect<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return DbContext.Set<T>().Where(filter).Select(selector).ToList();
        }

        public T LoadSingle(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public long Save(T entity)
        {
            DbContext.Entry(entity).State = entity.Id == 0
                ? EntityState.Added
                : EntityState.Modified;

            DbContext.SaveChanges();

            return entity.Id;
        }
    }
}