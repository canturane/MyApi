using MyApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Service.Dtos
{
    public class ProductRequestDto
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public bool IsActive { get; set; }
      






    }
}
