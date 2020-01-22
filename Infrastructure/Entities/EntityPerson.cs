using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entities
{
    public abstract class EntityPerson
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Address { get; protected set; }
        public string Phone { get; protected set; }
        public string Email { get; protected set; }
        public string Document { get; protected set; }
    }
}
