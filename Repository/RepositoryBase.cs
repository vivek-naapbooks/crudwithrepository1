using CRUDWITHREPOSITORY.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRUDWITHREPOSITORY.Repository
{
    public class RepositoryBase<T> : IRespositoryBase<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        public RepositoryBase(ApplicationDbContext RepositoryContext)
        {
            this.RepositoryContext = RepositoryContext;
        }
        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
            this.RepositoryContext.SaveChanges();
        }
        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
            this.RepositoryContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
            this.RepositoryContext.SaveChanges();
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindbyCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }


    }

}
