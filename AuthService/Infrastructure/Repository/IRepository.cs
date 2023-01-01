using System.Linq.Expressions;

namespace AuthService.Infrastructure.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        IQueryable<T> GetAll();
        int Count(Expression<Func<T, bool>> expression);
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        bool Exists(Expression<Func<T, bool>> expression);
        T Add(T entity);
        List<T> AddRange(IEnumerable<T> entities);
        public void Update(T entity);
        void Remove(T entity);
        public void RemoveById(object id);

        void RemoveRange(IEnumerable<T> entities);
        void SaveChanges();
    }

}
