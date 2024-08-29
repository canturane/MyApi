using MyApi.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Tittle { get; set; }
        public string Description { get; set; }

       
        public int BrandId { get; set; }
        public Brand? Brand{ get; set; }

    }
}
