﻿namespace MyApi.Service.Dtos
{
    public class PersonRequestDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
