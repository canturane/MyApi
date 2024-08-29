using MyApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Data.Repositories.person
{
    public interface IPersonRepository
    {
        Task<Person> DeleteAsync(int id);
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(int id);
        Task<Person> InsertAsync(Person entity);
        Task<Person> UpdateAsync(Person entity);
    }
}
