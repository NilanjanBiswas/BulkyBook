using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GellALL(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null,
            string IncludeProperyies = null);

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string IncludeProperyies = null);

        void Add(T entity);
        void Remove(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);


    }
}
