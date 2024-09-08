using MyApi.Common.Entities;

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
