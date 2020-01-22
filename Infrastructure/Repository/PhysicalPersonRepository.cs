using Application.Repositories.PhysicalPerson;
using AutoMapper;
using Domain.PhysicalPerson;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class PhysicalPersonRepository : IPhysicalPersonReadOnlyUseCase, IPhysicalPersonWriteOnlyUseCase
    {
        private readonly IMapper mapper;

        public PhysicalPersonRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public int Add(PhysicalPerson physicalPerson)
        {
            using (var context = new ApplicationContext())
            {
                context.Add(physicalPerson);
                return context.SaveChanges();
            }
        }

        public List<PhysicalPerson> GetAll()
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<List<PhysicalPerson>>(context.PhysicalPersons.ToList());
            }
        }

        public PhysicalPerson GetById(Guid id)
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<PhysicalPerson>(context.PhysicalPersons.Find(id));
            }
        }

        public int Remove(PhysicalPerson physicalPerson)
        {
            using (var context = new ApplicationContext())
            {
                context.Remove(physicalPerson);
                return context.SaveChanges();
            }
        }

        public int Update(PhysicalPerson physicalPerson)
        {
            using (var context = new ApplicationContext())
            {
                context.Update(physicalPerson);
                return context.SaveChanges();
            }
        }
    }
}
