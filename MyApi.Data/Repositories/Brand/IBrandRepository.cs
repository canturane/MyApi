namespace MyApi.Data.Repositories.Brand
{
    public interface IBrandRepository
    {
        Task<Entities.Brand> DeleteAsync(int id);
        Task<IEnumerable<Entities.Brand>> GetAllAsync();
        Task<Entities.Brand> GetByIdAsync(int id);
        Task<Entities.Brand> InsertAsync(Entities.Brand entity);
        Task<Entities.Brand> UpdateAsync(Entities.Brand entity);
    }
}
