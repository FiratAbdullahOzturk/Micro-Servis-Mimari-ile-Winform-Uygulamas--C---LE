using GlosySoftwareCase.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GlosySoftwareCase.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TDeleteAsync(int id);
        Task<List<T>> TGetListAsync();
        Task<List<ProductInfo>> TGetAllProductsWithPrices();
        Task<T> TGetByIdAsync(int id);
        Task<int> TCountAsync();
        Task<T> TFindAsync(Expression<Func<T, bool>> predicate);
    }
}
