using AutoMapper;
using Domain.LegalPerson;
using Domain.Person;
using Domain.PhysicalPerson;
using Domain.Product;
using Domain.Salesman;
using Domain.Saller;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mapping
{
    public class EntityToDomain : Profile
    {
        public EntityToDomain()
        {
            CreateMap<EntityPerson, Person>().ReverseMap();

            CreateMap<EntityLegalPerson, LegalPerson>().ReverseMap();

            CreateMap<EntityPhysicalPerson, PhysicalPerson>().ReverseMap();

            CreateMap<EntitySalesman, Salesman>().ReverseMap();

            CreateMap<EntityProduct, Product>().ReverseMap();

            CreateMap<EntitySaller, Saller>().ReverseMap();
        }
    }
}
