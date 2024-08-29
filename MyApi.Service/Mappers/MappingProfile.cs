using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Service.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.PersonRequestDto, MyApi.Data.Entities.Person>().ReverseMap();
            CreateMap<Dtos.PersonResponseDto, MyApi.Data.Entities.Person>().ReverseMap();
        }

    }
}
