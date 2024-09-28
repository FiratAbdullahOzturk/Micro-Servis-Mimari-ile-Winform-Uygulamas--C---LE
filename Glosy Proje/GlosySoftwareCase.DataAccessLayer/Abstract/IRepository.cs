using GlosySoftwareCase.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GlosySoftwareCase.DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetListAsync();
        Task<List<ProductInfo>> GetAllProductsWithPrices();
        Task<T> GetByIdAsync(int id);
        Task<int> CountAsync();
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
