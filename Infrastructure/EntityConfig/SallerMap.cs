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
            builder.ToTable("Saller");

            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Product);

            builder.HasOne(x => x.Salesman);

            builder.Property(x => x.TotalSale)
                .IsRequired();
        }
    }
}
