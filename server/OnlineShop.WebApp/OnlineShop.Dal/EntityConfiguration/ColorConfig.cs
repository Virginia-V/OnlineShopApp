using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;

namespace OnlineShop.Dal.EntityConfiguration
{
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(x => x.ProductColor)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.HasData(new { Id = 1, ProductColor = "black" },
                          new { Id = 2, ProductColor = "silver" },
                          new { Id = 3, ProductColor = "gray" },
                          new { Id = 4, ProductColor = "white" },
                          new { Id = 5, ProductColor = "maroon" },
                          new { Id = 6, ProductColor = "red" },
                          new { Id = 7, ProductColor = "purple" },
                          new { Id = 8, ProductColor = "fuchsia" },
                          new { Id = 9, ProductColor = "green" },
                          new { Id = 10, ProductColor = "lime" },
                          new { Id = 11, ProductColor = "olive" },
                          new { Id = 12, ProductColor = "navy" },
                          new { Id = 13, ProductColor = "yellow" },
                          new { Id = 14, ProductColor = "blue" },
                          new { Id = 15, ProductColor = "teal" },
                          new { Id = 16, ProductColor = "aqua" });
        }
    }
}
