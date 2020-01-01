using System;

namespace Domain.LegalPerson
{
    public class LegalPerson : Person.Person
    {
        public string CorporateName { get; private set; }

        public LegalPerson(
            string document,
            string corporateName,
            string name,
            string address,
            string phone,
            string email) : base(name, address, phone, email, document)
        {
            Id = Guid.NewGuid();
            Document = document;
            CorporateName = corporateName;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
