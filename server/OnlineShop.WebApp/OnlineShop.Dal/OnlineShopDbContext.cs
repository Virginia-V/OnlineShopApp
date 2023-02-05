using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Dal.Constants;
using OnlineShop.Domain;
using OnlineShop.Domain.Auth;

namespace OnlineShop.Dal
{
    public class OnlineShopDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnlineShopDbContext).Assembly);
            ApplyIdentityMapConfiguration(modelBuilder);
        }
        private void ApplyIdentityMapConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users", SchemaConstants.Auth);
            modelBuilder.Entity<UserClaim>().ToTable("UserClaims", SchemaConstants.Auth);
            modelBuilder.Entity<UserLogin>().ToTable("UserLogins", SchemaConstants.Auth);
            modelBuilder.Entity<UserToken>().ToTable("UserRoles", SchemaConstants.Auth);
            modelBuilder.Entity<Role>().ToTable("Roles", SchemaConstants.Auth);
            modelBuilder.Entity<RoleClaim>().ToTable("RoleClaims", SchemaConstants.Auth);
            modelBuilder.Entity<UserRole>().ToTable("UserRole", SchemaConstants.Auth);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<BasketProduct> BasketProducts { get; set; }
        public virtual DbSet<OrderedProduct> OrderedProducts { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<ProductColor> ProductColors { get; set; }

    }
}
