using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class SalesmanMap : IEntityTypeConfiguration<EntitySalesman>
    {
        public void Configure(EntityTypeBuilder<EntitySalesman> builder)
        {
            builder.ToTable("Salerman", "API");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
