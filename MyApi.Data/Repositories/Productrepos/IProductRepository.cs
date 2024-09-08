using MyApi.Data.Entities;

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
