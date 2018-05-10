using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Entity;
namespace EIMS.Dal
{
    public partial class BaseDal<T> where T:class,new()
    {
        DbContext dbContext = null;
        public BaseDal()
        {
            dbContext=DbContextFactory.GetDbContext();
        }

        public T Update(T entity)
        {
            dbContext.Set<T>().Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
            return entity;
        }
        public T Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
            return entity;
        }
        public void Delete(T entity)
        {
            dbContext.Set<T>().Attach(entity);
            dbContext.Entry(entity).State = EntityState.Deleted;
            dbContext.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> whereLambda)
        {
            T entity=dbContext.Set<T>().Where(whereLambda).FirstOrDefault();           
            return entity;
        }
        public List<T> FindAll(Expression<Func<T, bool>> whereLambda = null)
        {
            List<T> entitys= dbContext.Set<T>().Where(whereLambda).ToList();
            return entitys;
        }
        public List<T> FindByPage<TResult>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TResult>> orderby, int pageIndex, int pageSize)
        {
            List<T> entitys = dbContext.Set<T>().Where(whereLambda).Skip((pageIndex-1)*pageSize).Take(pageSize).OrderBy(orderby).ToList();
            return entitys;
        }
    }
}