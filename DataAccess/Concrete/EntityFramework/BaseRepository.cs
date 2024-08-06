using DataAccess.Abstract;
using Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class BaseRepository<TContext, TEntity> : IBaseRepoitory<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            var context = new TContext();
            context.Add(entity);
            var changes = context.SaveChanges();
            Console.WriteLine("Number of changes in db: " + changes);
        }

        public void Update(TEntity entity)
        {
            var context = new TContext();
            context.Update(entity);
            var changes = context.SaveChanges();
            Console.WriteLine("Number of changes in db: " + changes);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            var context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var context = new TContext();
            return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
        }

        public void Delete(TEntity entity)
        {
            var context = new TContext();
            context.Remove(entity);
            var changes = context.SaveChanges();
            Console.WriteLine("Number of changes in db: " + changes);
        }
    }
}
