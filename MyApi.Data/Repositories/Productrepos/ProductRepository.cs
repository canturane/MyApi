using Microsoft.EntityFrameworkCore;
using MyApi.Data.Context;
using MyApi.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApi.Data.Repositories.Productrepos
{
    public class ProductRepository : IProductRepository
    {
        private readonly IGenericRepository<Product> _genericRepository;
        private readonly AppDbContext _context;

        public ProductRepository(IGenericRepository<Product> genericRepository, AppDbContext context)
        {
            _genericRepository = genericRepository;
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products
                .Include(p => p.Brand)  // Brand verilerini sorguya dahil eder
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Brand)  // Brand verilerini sorguya dahil eder
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> InsertAsync(Product entity)
        {
            return await _genericRepository.InsertAsync(entity);
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            return await _genericRepository.UpdateAsync(entity);
        }

        public async Task<Product> DeleteAsync(int id)
        {
            return await _genericRepository.DeleteAsync(id);
        }
    }
}
