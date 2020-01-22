using Domain.Saller;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class SallerMap : IEntityTypeConfiguration<EntitySaller>
    {
        public void Configure(EntityTypeBuilder<EntitySaller> builder)
        {
            builder.ToTable("Saller", "API");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Product)
                .IsRequired();

            builder.Property(x => x.Person)
                .IsRequired();

            builder.Property(x => x.Salesman)
                .IsRequired();

            builder.Property(x => x.TotalSale)
                .IsRequired();
        }
    }
}
