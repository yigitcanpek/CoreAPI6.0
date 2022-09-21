using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { id = 1, Name = "Kurşun Kalem", CategoryId = 1, Price = 100, Stock = 20 },
                new Product { id=2,Name="Lotr",CategoryId=2,Price=100,Stock = 20 },
                new Product { id=3 , Name="Telli Defter",CategoryId=3,Price=100,Stock=30}
                );
        }
    }
}
