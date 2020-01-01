using System;

namespace Domain.Person
{
    public abstract class Person
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Address { get; protected set; }
        public string Phone { get; protected set; }
        public string Email { get; protected set; }
        public string Document { get; protected set; }

        protected Person(string name, string address, string phone, string email, string document)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Document = document;
        }
    }
}
