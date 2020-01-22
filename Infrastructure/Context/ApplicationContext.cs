using Domain.Salesman;
using Infrastructure.Entities;
using Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EntityLegalPerson> LegalPersons { get; set; }
        public DbSet<EntityPhysicalPerson> PhysicalPersons { get; set; }
        public DbSet<EntityProduct> Products { get; set; }
        public DbSet<EntitySalesman> Salesmans { get; set; }
        public DbSet<EntitySaller> Sallers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql("User ID=postgres;Password=1234567;Host=db-postgres;Port=5432;Database=API;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LegalPersonMap());
            modelBuilder.ApplyConfiguration(new PhysicalPersonMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new SalesmanMap());
            modelBuilder.ApplyConfiguration(new SallerMap());

            modelBuilder.Entity<EntitySalesman>().HasData(
                new EntitySalesman()
                {
                    Id = Guid.NewGuid(),
                    Name = "admin",
                    Email = "admin@gmail.com",
                    Phone = "21999999999"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
