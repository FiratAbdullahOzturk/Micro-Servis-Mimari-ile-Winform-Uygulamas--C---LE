using GlosySoftwareCase.BusinessLayer.Abstract;
using GlosySoftwareCase.DataAccessLayer.Abstract;
using GlosySoftwareCase.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GlosySoftwareCase.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public GenericManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<int> TCountAsync()
        {
            return _repository.CountAsync();
        }

        public async Task TCreateAsync(T entity)
        {
            await _repository.CreateAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<T> TFindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.FindAsync(predicate);
        }

        public Task<T> TGetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<List<T>> TGetListAsync()
        {
            return _repository.GetListAsync();
        }

        public Task<List<ProductInfo>> TGetAllProductsWithPrices()
        {
            return _repository.GetAllProductsWithPrices();
        }

        public async Task TUpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
