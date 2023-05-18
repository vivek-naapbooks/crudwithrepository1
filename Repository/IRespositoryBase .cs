using System.Linq.Expressions;

namespace CRUDWITHREPOSITORY.Repository
{
    public interface IRespositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindbyCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
