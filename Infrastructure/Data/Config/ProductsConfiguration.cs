// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Core.Entity;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;

// namespace Infrastructure.Data.Config
// {
//     public class ProductsConfiguration : IEntityTypeConfiguration<Product>
//     {
//         public void Configure(EntityTypeBuilder<Product> builder)
//         {
//             builder.Property(p => p.Id).IsRequired();
//             builder.Property(p => p.Name).IsRequired();
//             builder.Property( p=> p.Description).IsRequired();
//             builder.Property(p=> p.Price).IsRequired();
//             builder.Property(p => p.PictureUrl).IsRequired();
//             builder.HasOne(b => b.ProductBrand).WithMany().HasForeignKey( b=> b.ProductBrandId);
//             builder.HasOne(t => t.ProductType).WithMany().HasForeignKey( t=> t.ProductTypeId);
//         }
//     }
// }