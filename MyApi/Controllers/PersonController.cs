using Microsoft.AspNetCore.Mvc;
using MyApi.Service.Dtos;
using MyApi.Service.PersonService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonResponseDto>> Get()
        {
            return await _personService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<PersonResponseDto> Get(int id)
        {
            return await _personService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<PersonResponseDto> Post([FromBody] PersonRequestDto personRequestDto)
        {
            return await _personService.InsertAsync(personRequestDto);
        }

        [HttpPut]
        public async Task<PersonResponseDto> Put([FromBody] PersonRequestDto personRequestDto)
        {
            return await _personService.UpdateAsync(personRequestDto);
        }

        [HttpDelete("{id}")]
        public async Task<PersonResponseDto> Delete(int id)
        {
            return await _personService.DeleteAsync(id);
        }
    }
}
