using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;

namespace OnlineShop.Dal.EntityConfiguration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductSKU)
                 .IsRequired()
                 .HasMaxLength(50);
            builder.Property(x => x.ProductName)
                 .IsRequired()
                 .HasMaxLength(50);
            builder.Property(x => x.ProductPrice)
                 .IsRequired();
            builder.Property(x => x.ProductDescription)
                 .IsRequired()
                 .HasMaxLength(200);
            builder.Property(x => x.ProductImage)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
