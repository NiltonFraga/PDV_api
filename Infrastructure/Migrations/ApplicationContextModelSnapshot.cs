﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Infrastructure.Entities.EntityLegalPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("CorporateName")
                        .IsRequired()
                        .HasColumnType("character varying(70)")
                        .HasMaxLength(70);

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("Document")
                        .IsUnique();

                    b.ToTable("LegalPerson");
                });

            modelBuilder.Entity("Infrastructure.Entities.EntityPhysicalPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("Document")
                        .IsUnique();

                    b.ToTable("PhysicalPerson");
                });

            modelBuilder.Entity("Infrastructure.Entities.EntityProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("EntitySallerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("EntitySallerId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Infrastructure.Entities.EntitySalesman", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Salerman");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d6e884da-7d36-4378-8a32-d962f160bedc"),
                            Email = "admin@gmail.com",
                            Name = "admin",
                            Phone = "21999999999"
                        });
                });

            modelBuilder.Entity("Infrastructure.Entities.EntitySaller", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SalesmanId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Seller")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("TotalSale")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("SalesmanId");

                    b.ToTable("Saller");
                });

            modelBuilder.Entity("Infrastructure.Entities.EntityProduct", b =>
                {
                    b.HasOne("Infrastructure.Entities.EntitySaller", null)
                        .WithMany("Product")
                        .HasForeignKey("EntitySallerId");
                });

            modelBuilder.Entity("Infrastructure.Entities.EntitySaller", b =>
                {
                    b.HasOne("Infrastructure.Entities.EntitySalesman", "Salesman")
                        .WithMany()
                        .HasForeignKey("SalesmanId");
                });
#pragma warning restore 612, 618
        }
    }
}
