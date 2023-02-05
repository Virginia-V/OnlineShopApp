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


            builder.HasData(new { Id = 1, CategoryName = "Coats", CategoryImage = "https://i.pinimg.com/564x/33/db/25/33db259e2b81912d310f8e662a8df978.jpg" },
                          new { Id = 2, CategoryName = "Gym Clothes", CategoryImage = "https://i.pinimg.com/564x/67/89/99/678999e2b02a0e0df8e008c1ceeef56c.jpg" },
                          new { Id = 3, CategoryName = "Jeans", CategoryImage = "https://i.pinimg.com/564x/67/59/0b/67590bf349a8f6dc016dac3ff3fd9c14.jpg" },
                          new { Id = 4, CategoryName = "Hoodies", CategoryImage = "https://i.pinimg.com/564x/07/a0/d5/07a0d5a33b8f4168ef6ec4c03944ad92.jpg" },
                          new { Id = 5, CategoryName = "Vests", CategoryImage = "https://i.pinimg.com/564x/31/e6/a5/31e6a56cc424e4ce13153568489277de.jpg" },
                          new { Id = 6, CategoryName = "T-Shirts", CategoryImage = "https://i.pinimg.com/564x/c3/2f/7a/c32f7a60a8fa5335e83c3cc82795c609.jpg" },
                          new { Id = 7, CategoryName = "Skirts", CategoryImage = "https://i.pinimg.com/564x/3d/81/de/3d81dedfd3a51be3175291d9d34b4fca.jpg" },
                          new { Id = 8, CategoryName = "Shorts", CategoryImage = "https://i.pinimg.com/564x/14/4e/26/144e26c0bcce43eb12ff83518188b87d.jpg" },
                          new { Id = 9, CategoryName = "Sweaters", CategoryImage = "https://i.pinimg.com/564x/88/a7/87/88a7879cd516666f15cf3bbe458ba169.jpg" },
                          new { Id = 10, CategoryName = "Shirts", CategoryImage = "https://i.pinimg.com/564x/09/c3/0f/09c30fdf441f01e4c17712252c54436e.jpg" },
                          new { Id = 11, CategoryName = "Swimsuits", CategoryImage = "https://i.pinimg.com/564x/dc/b2/99/dcb29963df0ee7aec9843e2bf7e4d598.jpg" },
                          new { Id = 12, CategoryName = "Pajamas", CategoryImage = "https://i.pinimg.com/564x/75/8a/f1/758af14dc0f392d1d1f47126a35d7762.jpg" },
                          new { Id = 13, CategoryName = "Sheath Dresses", CategoryImage = "https://i.pinimg.com/564x/e8/09/6d/e8096d13866fa0d9ad3f554a85d7a40f.jpg" },
                          new { Id = 14, CategoryName = "Scarfs", CategoryImage = "https://i.pinimg.com/564x/b4/24/27/b42427e7a1e8ca9272cdfc7ac44fbda4.jpg" },
                          new { Id = 15, CategoryName = "Raincoats", CategoryImage = "https://i.pinimg.com/564x/72/4a/53/724a53d910fc333bfb10526c6c2b8e32.jpg" },
                          new { Id = 16, CategoryName = "Tracksuits", CategoryImage = "https://i.pinimg.com/564x/c6/bc/58/c6bc5809fefe0f39d5f796953655909a.jpg" });
        }
    }
}
