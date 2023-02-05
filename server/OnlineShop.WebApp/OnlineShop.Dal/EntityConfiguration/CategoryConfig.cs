using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;

namespace OnlineShop.Dal.EntityConfiguration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName)
                 .IsRequired()
                 .HasMaxLength(50);
            builder.Property(x => x.CategoryImage)
                 .IsRequired()
                 .HasMaxLength(200);
        }
    }
}
