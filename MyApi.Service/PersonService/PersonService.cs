<<<<<<< HEAD
<<<<<<< HEAD
﻿using AutoMapper;
using MyApi.Data.Entities;
using MyApi.Data.Repositories.person;
using MyApi.Service.Dtos;
using System.Collections.Generic;
=======
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
﻿using MyApi.Data.Entities;
using MyApi.Data.Repositories.person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
using System.Threading.Tasks;

namespace MyApi.Service.PersonService
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonResponseDto>> GetAllAsync()
        {
            var persons = await _personRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PersonResponseDto>>(persons);
        }

        public async Task<PersonResponseDto> GetByIdAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            return _mapper.Map<PersonResponseDto>(person);
        }

        public async Task<PersonResponseDto> InsertAsync(PersonRequestDto personRequestDto)
        {
            var person = _mapper.Map<Person>(personRequestDto);
            var createdPerson = await _personRepository.InsertAsync(person);
            return _mapper.Map<PersonResponseDto>(createdPerson);
        }

        public async Task<PersonResponseDto> UpdateAsync(PersonRequestDto personRequestDto)
        {
            var person = _mapper.Map<Person>(personRequestDto);
            var updatedPerson = await _personRepository.UpdateAsync(person);
            return _mapper.Map<PersonResponseDto>(updatedPerson);
        }

        public async Task<PersonResponseDto> DeleteAsync(int id)
        {
            var deletedPerson = await _personRepository.DeleteAsync(id);
            return _mapper.Map<PersonResponseDto>(deletedPerson);
        }
=======
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
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

        
<<<<<<< HEAD
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
    }
}
