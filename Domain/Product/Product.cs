using System;

namespace Domain.Product
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; private set; }
        public Decimal CostPrice { get; private set; }
        public Decimal SalePrice { get; private set; }
        public Decimal DiscountPrice { get; private set; }
        public int Amount { get; private set; }

        public Product(string name, decimal costPrice, decimal salePrice, decimal discountPrice, int amount)
        {
            Id = Guid.NewGuid();
            Name = name;
            CostPrice = costPrice;
            SalePrice = salePrice;
            DiscountPrice = discountPrice;
            Amount = amount;
        }
    }
}
