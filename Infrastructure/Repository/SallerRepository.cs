using Application.Repositories.Saller;
using AutoMapper;
using Domain.Saller;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class SallerRepository : ISallerReadOnlyUseCase, ISallerWriteOnlyUseCase
    {
        private readonly IMapper mapper;

        public SallerRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public int Add(Saller saller)
        {
            using (var context = new ApplicationContext())
            {
                context.Add(saller);
                return context.SaveChanges();
            }
        }

        public List<Saller> GetAll()
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<List<Saller>>(context.Sallers.ToList());
            }
        }

        public Saller GetById(Guid id)
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<Saller>(context.Sallers.Find(id));
            }
        }

        public int Remove(Saller saller)
        {
            using (var context = new ApplicationContext())
            {
                context.Remove(saller);
                return context.SaveChanges();
            }
        }

        public int Update(Saller saller)
        {
            using (var context = new ApplicationContext())
            {
                context.Update(saller);
                return context.SaveChanges();
            }
        }
    }
}
