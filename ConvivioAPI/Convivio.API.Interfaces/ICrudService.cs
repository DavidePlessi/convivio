using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Convivio.API.Entities;

namespace Convivio.API.Interfaces
{
    public interface ICrudService<T>
        where T : Entity, new()
    {
        List<T> LoadAll();

        T LoadSingle(int id);

        long Delete(int id);

        long Save(T entity);

        List<TResult> LoadAndSelect<TResult>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, TResult>> selector);
    }
}