using MyApi.Data.Entities;
using MyApi.Data.Repositories.person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Service.PersonService
{
    public class PersonService:IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository PersonRepository)
        {
            _personRepository = PersonRepository;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        public async Task<Person> InsertAsync(Person entity)
        {
            return await _personRepository.InsertAsync(entity);
        }

        public async Task<Person> UpdateAsync(Person entity)
        {
            return await _personRepository.UpdateAsync(entity);
        }

        public async Task<Person> DeleteAsync(int id)
        {
            return await _personRepository.DeleteAsync(id);
        }

        
    }
}
