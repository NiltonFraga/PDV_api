using System;

namespace Domain.Salesman
{
    public class Salesman
    {
        public Guid Id { get; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public Salesman(string name, string phone, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
