using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Service
{
    public interface IService<T> where T : class
    {
        
            Task<IEnumerable<T>> GetAllAsync();
            Task<T> GetByIdAsync(int id);
            IQueryable<T> Where(Expression<Func<T, bool>> exp);
            Task<T> AddAsync(T entity);
            Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
            Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
            Task UpdateAsync(T entity);
            Task DeleteAsync(T entity);
            Task DeleteRangeAsync(IEnumerable<T> entities);
        
    }
}
