using Domain.LegalPerson;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class LegalPersonMap : IEntityTypeConfiguration<EntityLegalPerson>
    {
        public void Configure(EntityTypeBuilder<EntityLegalPerson> builder)
        {
            builder.ToTable("LegalPerson", "PDV");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Document)
                .IsUnique();

            builder.Property(x => x.CorporateName)
                .IsRequired()
                .HasMaxLength(70);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(100);
                
            builder.Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
