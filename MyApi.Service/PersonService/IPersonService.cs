<<<<<<< HEAD
<<<<<<< HEAD
﻿using MyApi.Service.Dtos;
using System.Collections.Generic;
=======
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
﻿using MyApi.Data.Entities;
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
    public interface IPersonService
    {
        Task<IEnumerable<PersonResponseDto>> GetAllAsync();
        Task<PersonResponseDto> GetByIdAsync(int id);
        Task<PersonResponseDto> InsertAsync(PersonRequestDto personRequestDto);
        Task<PersonResponseDto> UpdateAsync(PersonRequestDto personRequestDto);
        Task<PersonResponseDto> DeleteAsync(int id);
=======
    public interface IPersonService:IGenericService<Person>
    {
      
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
    public interface IPersonService:IGenericService<Person>
    {
      
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
    }
}
