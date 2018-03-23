using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public interface IRepository<T>
    {
        T GetSingle(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(int id);
        void Edit(T entity);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);       
    }
}
