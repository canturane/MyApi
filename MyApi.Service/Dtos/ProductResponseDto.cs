using MyApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Service.Dtos
{
    public class ProductResponseDto
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}
