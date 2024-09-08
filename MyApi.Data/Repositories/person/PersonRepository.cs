namespace MyApi.Data.Repositories.person
{
    public class PersonRepository:IPersonRepository
    {
        private readonly IGenericRepository<Entities.Person> _genericRepository;

        public PersonRepository(IGenericRepository<Entities.Person> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<Entities.Person>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<Entities.Person> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.Person> InsertAsync(Entities.Person entity)
        {
            return await _genericRepository.InsertAsync(entity);
        }

        public async Task<Entities.Person> UpdateAsync(Entities.Person entity)
        {
            return await _genericRepository.UpdateAsync(entity);
        }

        public async Task<Entities.Person> DeleteAsync(int id)
        {
            return await _genericRepository.DeleteAsync(id);
        }
    }
}
