using AutoMapper;

using MyApi.Data.Entities;
using MyApi.Service.Dtos;

namespace MyApi.Service.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.PersonRequestDto, MyApi.Data.Entities.Person>().ReverseMap();
            CreateMap<Dtos.PersonResponseDto, MyApi.Data.Entities.Person>().ReverseMap();
            CreateMap<Dtos.ProductResponseDto, MyApi.Data.Entities.Product>().ReverseMap();
            CreateMap<Dtos.ProductRequestDto, MyApi.Data.Entities.Product>().ReverseMap();

  

            CreateMap<Product, ProductResponseDto>()
    .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => new BrandDto
    {
        Id = src.Brand.Id,
        Name = src.Brand.Name  
    }))
    .ReverseMap();

        

        }

    }
}
