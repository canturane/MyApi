using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Data.Entities;
using MyApi.Service.Dtos;
using MyApi.Service.PersonService;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
       private readonly IPersonService _personService;
        private readonly IMapper _mapper;
        public PersonController(IPersonService personService,IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonResponseDto>> Get()
        {
            var persons = await _personService.GetAllAsync();
            return _mapper.Map<IEnumerable<PersonResponseDto>>(persons);
        }

        [HttpGet("{id}")]
        public async Task<PersonResponseDto> Get(int id)
        {
            var user = await _personService.GetByIdAsync(id);
            return _mapper.Map<PersonResponseDto>(user);
        }


        [HttpPost]
        public async Task<PersonResponseDto> Post([FromBody] PersonRequestDto personRequestDto)
        {


            var person = _mapper.Map<Person>(personRequestDto);
            var createdPerson = await _personService.InsertAsync(person);
            return _mapper.Map<PersonResponseDto>(createdPerson);
        }

        [HttpPut]
        public async Task<PersonResponseDto> Put([FromBody] PersonRequestDto personRequestDto)
        {
            var person = _mapper.Map<Person>(personRequestDto);
            var updatedPerson = await _personService.UpdateAsync(person);
            return _mapper.Map<PersonResponseDto>(updatedPerson);
        }

        [HttpDelete("{id}")]
        public async Task<PersonResponseDto> Delete(int id)
        {
            var deletedPerson = await _personService.DeleteAsync(id);
            return _mapper.Map<PersonResponseDto>(deletedPerson);
        }


    }
}
