using Application.Repositories.Salesman;
using AutoMapper;
using Domain.Salesman;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class SalesmanRepository : ISalesmanReadOnlyUseCase, ISalesmanWriteOnlyUseCase
    {
        private readonly IMapper mapper;

        public SalesmanRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public int Add(Salesman salesman)
        {
            using (var context = new ApplicationContext())
            {
                context.Add(salesman);
                return context.SaveChanges();
            }
        }

        public List<Salesman> GetAll()
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<List<Salesman>>(context.Salesmans.ToList()); 
            }
        }

        public Salesman GetById(Guid id)
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<Salesman>(context.Salesmans.Find(id));
            }
        }

        public int Remove(Salesman salesman)
        {
            using (var context = new ApplicationContext())
            {
                context.Remove(salesman);
                return context.SaveChanges();
            }
        }

        public int Update(Salesman salesman)
        {
            using (var context = new ApplicationContext())
            {
                context.Update(salesman);
                return context.SaveChanges();
            }
        }
    }
}
