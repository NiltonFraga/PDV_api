using System;

namespace Domain.PhysicalPerson
{
    public class PhysicalPerson : Person.Person
    {
        public DateTime Birthday { get; private set; }

        public PhysicalPerson(
            string document, 
            string name, 
            DateTime birthday, 
            string address,
            string phone,
            string email) : base (name, address, phone, email, document)
        {
            Id = Guid.NewGuid();
            Document = document;
            Birthday = birthday;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
