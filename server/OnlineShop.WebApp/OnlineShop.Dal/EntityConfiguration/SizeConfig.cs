using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;

namespace OnlineShop.Dal.EntityConfiguration
{
    public class SizeConfig : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(x => x.ProductSize)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.HasData(new { Id = 1, ProductSize = "XS" },
                          new { Id = 2, ProductSize = "S" },
                          new { Id = 3, ProductSize = "M" },
                          new { Id = 4, ProductSize = "L" },
                          new { Id = 5, ProductSize = "XL" },
                          new { Id = 6, ProductSize = "XXL" });
                        

        }
    }
}
