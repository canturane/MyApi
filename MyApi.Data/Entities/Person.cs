using MyApi.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Data.Entities
{
    public class Person: BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
