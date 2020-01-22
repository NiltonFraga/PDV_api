using System;
using System.Collections.Generic;

namespace Domain.Saller
{
    public class Saller
    {
        public Guid Id { get; }
        public List<Product.Product> Product { get; private set; }
        public Person.Person Person { get; private set; }
        public Salesman.Salesman Salesman { get; private set; }
        public DateTime Seller { get; private set; }
        public decimal TotalSale { get; private set; }

        public Saller(List<Product.Product> product, Person.Person person, Salesman.Salesman salesman, decimal totalSale)
        {
            Id = Guid.NewGuid();
            Product = product;
            Person = person;
            Salesman = salesman;
            Seller = DateTime.Now;
            TotalSale = totalSale;
        }
    }
}
