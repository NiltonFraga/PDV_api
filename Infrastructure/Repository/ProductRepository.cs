using Application.Repositories.Product;
using AutoMapper;
using Domain.Product;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductReadOnlyUseCase, IProductWriteOnlyUseCase
    {
        private readonly IMapper mapper;
        public ProductRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public int Add(Product product)
        {
            using (var context = new ApplicationContext())
            {
                context.Add(product);
                return context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<List<Product>>(context.Products.ToList());
            }
        }

        public Product GetById(Guid id)
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<Product>(context.Products.Find());
            }
        }

        public int Remove(Product product)
        {
            using (var context = new ApplicationContext())
            {
                context.Remove(product);
                return context.SaveChanges();
            }
        }

        public int Update(Product product)
        {
            using (var context = new ApplicationContext())
            {
                context.Update(product);
                return context.SaveChanges();
            }
        }
    }
}
