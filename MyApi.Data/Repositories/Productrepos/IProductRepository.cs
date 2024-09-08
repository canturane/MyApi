using MyApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Data.Repositories.Productrepos
{
    public interface IProductRepository
    {
        Task<Product> DeleteAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> InsertAsync(Product entity);
        Task<Product> UpdateAsync(Product entity);
    }
}
