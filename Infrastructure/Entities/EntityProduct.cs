using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entities
{
    public class EntityProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal CostPrice { get; set; }
        public Decimal SalePrice { get; set; }
        public Decimal DiscountPrice { get; set; }
        public int Amount { get; set; }
    }
}
