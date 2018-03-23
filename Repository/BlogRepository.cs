using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public class BlogRepository<C, T> : IRepository<T> where T : BaseModel where C : DbContext
    {
        private BlogAppDbContext context = new BlogAppDbContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(int id)
        {
            var query = context.Set<T>().FirstOrDefault(a => a.Id == id);
            context.Set<T>().Remove(query);
            Save();
        }

        public void Edit(T entity)
        {
            context.SaveChanges();
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            var Single = context.Set<T>();
            return Single;
        }

        public T GetSingle(int id)
        {
            var Single = context.Set<T>().FirstOrDefault(f => f.Id == id);
            return Single;
           
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
