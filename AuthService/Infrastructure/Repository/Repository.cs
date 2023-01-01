using System.Linq.Expressions;
using AuthService.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Infrastructure.Repository;

internal class Repository<T> : IRepository<T> where T : class
{
    private readonly AuthDbContext _context;

    public Repository(AuthDbContext authDbContext)
    {
        this._context = authDbContext;
    }

    public T Add(T entity)
    {

        _context.Set<T>().Add(entity);
        _context.SaveChanges();

        return entity;
    }
    public List<T> AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
        _context.SaveChanges();

        return entities.ToList();
    }
    public IQueryable<T> Find(Expression<Func<T, bool>> filter)
    {
        DbSet<T> dbSet1 = _context.Set<T>();
        IQueryable<T> query = dbSet1;

        query = query.Where(filter);
        return query;
    }
    public bool Exists(Expression<Func<T, bool>> filter)
    {
        DbSet<T> dbSet1 = _context.Set<T>();
        IQueryable<T> query = dbSet1;

        bool res = query.Any(filter);
        return res;
    }
    public IQueryable<T> GetAll()
    {
        DbSet<T> dbSet1 = _context.Set<T>();
        IQueryable<T> query = dbSet1;
        return query;
    }
    public T GetById(object id)
    {
        return _context.Set<T>().Find(id);
    }
    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public void RemoveById(object id)
    {
        var entity = _context.Set<T>().Find(id);
        if (entity != null) _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public int Count(Expression<Func<T, bool>> expression)
    {
        DbSet<T> dbSet1 = _context.Set<T>();
        IQueryable<T> query = dbSet1;

        query = query.Where(expression);
        return query.Count();
    }
}
