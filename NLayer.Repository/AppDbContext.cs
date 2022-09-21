using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                ProductId = 1,
                Color = "Kırmızı",
                Width = 100,
                Height = 200

            },
            
            new ProductFeature()
            {
                Id=2,
                ProductId=2,
                Color="Mavi",
                Width=300,
                Height=300
            });
            //modelBuilder.ApplyConfiguration(new CategoryConfugiration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
