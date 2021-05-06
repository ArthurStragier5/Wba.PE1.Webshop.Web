using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.PE1.Webshop.Domain;

namespace Wba.PE1.Webshop.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsRequired();

            //modelBuilder.Entity<Product>()
            //    .Property(e => e.Price)
            //    .HasColumnType("money");

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .HasMaxLength(250);

            modelBuilder.Entity<Category>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();



            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOne(p => p.Category)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            DataSeeder.SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
