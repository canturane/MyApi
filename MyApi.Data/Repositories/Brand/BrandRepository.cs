using System.Collections.Generic;
using System.Threading.Tasks;
using MyApi.Data.Entities;

namespace MyApi.Data.Repositories.Brand
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IGenericRepository<Entities.Brand> _genericRepository;

        public BrandRepository(IGenericRepository<Entities.Brand> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<Entities.Brand>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<Entities.Brand> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.Brand> InsertAsync(Entities.Brand entity)
        {
            return await _genericRepository.InsertAsync(entity);
        }

        public async Task<Entities.Brand> UpdateAsync(Entities.Brand entity)
        {
            return await _genericRepository.UpdateAsync(entity);
        }

        public async Task<Entities.Brand> DeleteAsync(int id)
        {
            return await _genericRepository.DeleteAsync(id);
        }
    }
}
