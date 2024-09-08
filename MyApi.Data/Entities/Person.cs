using MyApi.Common.Entities;

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
