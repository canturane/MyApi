
using MyApi.Service.Dtos;
using System.Collections.Generic;
using MyApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Service.PersonService
{

    public interface IPersonService
    {
        Task<IEnumerable<PersonResponseDto>> GetAllAsync();
        Task<PersonResponseDto> GetByIdAsync(int id);
        Task<PersonResponseDto> InsertAsync(PersonRequestDto personRequestDto);
        Task<PersonResponseDto> UpdateAsync(PersonRequestDto personRequestDto);
        Task<PersonResponseDto> DeleteAsync(int id);
      

    }
}
