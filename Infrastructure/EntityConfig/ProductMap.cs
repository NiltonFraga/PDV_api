using Domain.Product;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class ProductMap : IEntityTypeConfiguration<EntityProduct>
    {
        public void Configure(EntityTypeBuilder<EntityProduct> builder)
        {
            builder.ToTable("Product", "PDV");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.CostPrice)
                .IsRequired();

            builder.Property(x => x.SalePrice)
                .IsRequired();

            builder.Property(x => x.Amount)
                .IsRequired();
        }
    }
}
