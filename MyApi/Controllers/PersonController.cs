<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using MyApi.Service.Dtos;
using MyApi.Service.PersonService;
using System.Collections.Generic;
using System.Threading.Tasks;
=======
﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Data.Entities;
using MyApi.Service.Dtos;
using MyApi.Service.PersonService;
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
<<<<<<< HEAD
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
=======
       private readonly IPersonService _personService;
        private readonly IMapper _mapper;
        public PersonController(IPersonService personService,IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
        }

        [HttpGet]
        public async Task<IEnumerable<PersonResponseDto>> Get()
        {
<<<<<<< HEAD
            return await _personService.GetAllAsync();
=======
            var persons = await _personService.GetAllAsync();
            return _mapper.Map<IEnumerable<PersonResponseDto>>(persons);
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
        }

        [HttpGet("{id}")]
        public async Task<PersonResponseDto> Get(int id)
        {
<<<<<<< HEAD
            return await _personService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<PersonResponseDto> Post([FromBody] PersonRequestDto personRequestDto)
        {
            return await _personService.InsertAsync(personRequestDto);
=======
            var user = await _personService.GetByIdAsync(id);
            return _mapper.Map<PersonResponseDto>(user);
        }


        [HttpPost]
        public async Task<PersonResponseDto> Post([FromBody] PersonRequestDto personRequestDto)
        {


            var person = _mapper.Map<Person>(personRequestDto);
            var createdPerson = await _personService.InsertAsync(person);
            return _mapper.Map<PersonResponseDto>(createdPerson);
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
        }

        [HttpPut]
        public async Task<PersonResponseDto> Put([FromBody] PersonRequestDto personRequestDto)
        {
<<<<<<< HEAD
            return await _personService.UpdateAsync(personRequestDto);
=======
            var person = _mapper.Map<Person>(personRequestDto);
            var updatedPerson = await _personService.UpdateAsync(person);
            return _mapper.Map<PersonResponseDto>(updatedPerson);
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
        }

        [HttpDelete("{id}")]
        public async Task<PersonResponseDto> Delete(int id)
        {
<<<<<<< HEAD
            return await _personService.DeleteAsync(id);
        }
=======
            var deletedPerson = await _personService.DeleteAsync(id);
            return _mapper.Map<PersonResponseDto>(deletedPerson);
        }


>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
    }
}
