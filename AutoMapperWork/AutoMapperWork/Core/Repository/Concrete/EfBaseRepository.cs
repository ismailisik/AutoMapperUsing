using AutoMapperWork.Core.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AutoMapperWork.Core.Repository.Concrete
{
    public class EfBaseRepository<T, IContext> : IEntityRepository<T>
        where T : class, new()
        where IContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using (var context = new IContext())
            {
                var AddEntity = context.Entry(entity);
                AddEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new IContext())
            {
                var DeleteEntity = context.Entry(entity);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new IContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new IContext())
            {
                return filter ==null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context = new IContext())
            {
                var UpdateEntity = context.Entry(entity);
                UpdateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
