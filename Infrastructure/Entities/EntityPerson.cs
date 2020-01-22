using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entities
{
    public class EntityPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
    }
}
