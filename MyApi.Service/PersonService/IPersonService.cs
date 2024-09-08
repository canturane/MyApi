
using MyApi.Service.Dtos;

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
