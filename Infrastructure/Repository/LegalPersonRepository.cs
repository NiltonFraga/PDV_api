using Application.Repositories.LegalPerson;
using AutoMapper;
using Domain.LegalPerson;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class LegalPersonRepository : ILegalPersonReadOnlyUseCase, ILegalPersonWriteOnlyUseCase
    {
        private readonly IMapper mapper;

        public LegalPersonRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public int Add(LegalPerson legalPerson)
        {
            using (var context = new ApplicationContext())
            {
                context.Add(legalPerson);
                return context.SaveChanges();
            }
        }

        public List<LegalPerson> GetAll()
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<List<LegalPerson>>(context.LegalPersons.ToList());
            }
        }

        public LegalPerson GetById(Guid id)
        {
            using (var context = new ApplicationContext())
            {
                return mapper.Map<LegalPerson>(context.LegalPersons.Find(id));
            }
        }

        public int Remove(LegalPerson legalPerson)
        {
            using (var context = new ApplicationContext())
            {
                context.Remove(legalPerson);
                return context.SaveChanges();
            }
        }

        public int Update(LegalPerson legalPerson)
        {
            using (var context = new ApplicationContext())
            {
                context.Update(legalPerson);
                return context.SaveChanges();
            }
        }
    }
}
