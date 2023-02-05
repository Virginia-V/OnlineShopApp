using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;

namespace OnlineShop.Dal.EntityConfiguration
{
    public class ProductColorConfig : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ColorId });

        }
    }
}
