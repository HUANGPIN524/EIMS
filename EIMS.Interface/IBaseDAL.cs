using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.Interface
{
    public interface IBaseDal<T> where T : class, new()
    {
        T Update(T entity);
        T Insert(T entity);
        void Delete(T entity);
        T Find(Expression<Func<T, bool>> whereLambda);
        List<T> FindAll(Expression<Func<T, bool>> whereLambda = null);
        List<T> FindByPage<TResult>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TResult>> orderby, int pageIndex, int pageSize);
    }
}
