using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Entities
{
    public class EntitySaller
    {
        public Guid Id { get; set; }
        public List<EntityProduct> Product { get; set; }
        public Guid PersonId { get; set; }

        [NotMapped]
        public EntityPerson Person { get; set; }

        public EntitySalesman Salesman { get; set; }
        public DateTime Seller { get; set; }
        public decimal TotalSale { get; set; }
    }
}
