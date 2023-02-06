﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Dal;

#nullable disable

namespace OnlineShop.Dal.Migrations
{
    [DbContext(typeof(OnlineShopDbContext))]
    [Migration("20230206151548_AddTablesForIdentity")]
    partial class AddTablesForIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineShop.Domain.Auth.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserRoles", "Auth");
                });

            modelBuilder.Entity("OnlineShop.Domain.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("OnlineShop.Domain.BasketProduct", b =>
                {
                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("BasketId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketProducts");
                });

            modelBuilder.Entity("OnlineShop.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryImage = "https://i.pinimg.com/564x/33/db/25/33db259e2b81912d310f8e662a8df978.jpg",
                            CategoryName = "Coats"
                        },
                        new
                        {
                            Id = 2,
                            CategoryImage = "https://i.pinimg.com/564x/67/89/99/678999e2b02a0e0df8e008c1ceeef56c.jpg",
                            CategoryName = "Gym Clothes"
                        },
                        new
                        {
                            Id = 3,
                            CategoryImage = "https://i.pinimg.com/564x/67/59/0b/67590bf349a8f6dc016dac3ff3fd9c14.jpg",
                            CategoryName = "Jeans"
                        },
                        new
                        {
                            Id = 4,
                            CategoryImage = "https://i.pinimg.com/564x/07/a0/d5/07a0d5a33b8f4168ef6ec4c03944ad92.jpg",
                            CategoryName = "Hoodies"
                        },
                        new
                        {
                            Id = 5,
                            CategoryImage = "https://i.pinimg.com/564x/31/e6/a5/31e6a56cc424e4ce13153568489277de.jpg",
                            CategoryName = "Vests"
                        },
                        new
                        {
                            Id = 6,
                            CategoryImage = "https://i.pinimg.com/564x/c3/2f/7a/c32f7a60a8fa5335e83c3cc82795c609.jpg",
                            CategoryName = "T-Shirts"
                        },
                        new
                        {
                            Id = 7,
                            CategoryImage = "https://i.pinimg.com/564x/3d/81/de/3d81dedfd3a51be3175291d9d34b4fca.jpg",
                            CategoryName = "Skirts"
                        },
                        new
                        {
                            Id = 8,
                            CategoryImage = "https://i.pinimg.com/564x/14/4e/26/144e26c0bcce43eb12ff83518188b87d.jpg",
                            CategoryName = "Shorts"
                        },
                        new
                        {
                            Id = 9,
                            CategoryImage = "https://i.pinimg.com/564x/88/a7/87/88a7879cd516666f15cf3bbe458ba169.jpg",
                            CategoryName = "Sweaters"
                        },
                        new
                        {
                            Id = 10,
                            CategoryImage = "https://i.pinimg.com/564x/09/c3/0f/09c30fdf441f01e4c17712252c54436e.jpg",
                            CategoryName = "Shirts"
                        },
                        new
                        {
                            Id = 11,
                            CategoryImage = "https://i.pinimg.com/564x/dc/b2/99/dcb29963df0ee7aec9843e2bf7e4d598.jpg",
                            CategoryName = "Swimsuits"
                        },
                        new
                        {
                            Id = 12,
                            CategoryImage = "https://i.pinimg.com/564x/75/8a/f1/758af14dc0f392d1d1f47126a35d7762.jpg",
                            CategoryName = "Pajamas"
                        },
                        new
                        {
                            Id = 13,
                            CategoryImage = "https://i.pinimg.com/564x/e8/09/6d/e8096d13866fa0d9ad3f554a85d7a40f.jpg",
                            CategoryName = "Sheath Dresses"
                        },
                        new
                        {
                            Id = 14,
                            CategoryImage = "https://i.pinimg.com/564x/b4/24/27/b42427e7a1e8ca9272cdfc7ac44fbda4.jpg",
                            CategoryName = "Scarfs"
                        },
                        new
                        {
                            Id = 15,
                            CategoryImage = "https://i.pinimg.com/564x/72/4a/53/724a53d910fc333bfb10526c6c2b8e32.jpg",
                            CategoryName = "Raincoats"
                        },
                        new
                        {
                            Id = 16,
                            CategoryImage = "https://i.pinimg.com/564x/c6/bc/58/c6bc5809fefe0f39d5f796953655909a.jpg",
                            CategoryName = "Tracksuits"
                        });
                });

            modelBuilder.Entity("OnlineShop.Domain.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProductColor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductColor = "black"
                        },
                        new
                        {
                            Id = 2,
                            ProductColor = "silver"
                        },
                        new
                        {
                            Id = 3,
                            ProductColor = "gray"
                        },
                        new
                        {
                            Id = 4,
                            ProductColor = "white"
                        },
                        new
                        {
                            Id = 5,
                            ProductColor = "maroon"
                        },
                        new
                        {
                            Id = 6,
                            ProductColor = "red"
                        },
                        new
                        {
                            Id = 7,
                            ProductColor = "purple"
                        },
                        new
                        {
                            Id = 8,
                            ProductColor = "fuchsia"
                        },
                        new
                        {
                            Id = 9,
                            ProductColor = "green"
                        },
                        new
                        {
                            Id = 10,
                            ProductColor = "lime"
                        },
                        new
                        {
                            Id = 11,
                            ProductColor = "olive"
                        },
                        new
                        {
                            Id = 12,
                            ProductColor = "navy"
                        },
                        new
                        {
                            Id = 13,
                            ProductColor = "yellow"
                        },
                        new
                        {
                            Id = 14,
                            ProductColor = "blue"
                        },
                        new
                        {
                            Id = 15,
                            ProductColor = "teal"
                        },
                        new
                        {
                            Id = 16,
                            ProductColor = "aqua"
                        });
                });

            modelBuilder.Entity("OnlineShop.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<decimal>("ShippingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShop.Domain.OrderedProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderedProducts");
                });

            modelBuilder.Entity("OnlineShop.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductSKU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShop.Domain.ProductColor", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("OnlineShop.Domain.ProductSize", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "SizeId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSizes");
                });

            modelBuilder.Entity("OnlineShop.Domain.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProductSize")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductSize = "XS"
                        },
                        new
                        {
                            Id = 2,
                            ProductSize = "S"
                        },
                        new
                        {
                            Id = 3,
                            ProductSize = "M"
                        },
                        new
                        {
                            Id = 4,
                            ProductSize = "L"
                        },
                        new
                        {
                            Id = 5,
                            ProductSize = "XL"
                        },
                        new
                        {
                            Id = 6,
                            ProductSize = "XXL"
                        });
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.RoleClaim", b =>
                {
                    b.HasOne("OnlineShop.Domain.Auth.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserClaim", b =>
                {
                    b.HasOne("OnlineShop.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserLogin", b =>
                {
                    b.HasOne("OnlineShop.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserRole", b =>
                {
                    b.HasOne("OnlineShop.Domain.Auth.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.UserToken", b =>
                {
                    b.HasOne("OnlineShop.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Domain.Basket", b =>
                {
                    b.HasOne("OnlineShop.Domain.Auth.User", "User")
                        .WithOne("Basket")
                        .HasForeignKey("OnlineShop.Domain.Basket", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineShop.Domain.BasketProduct", b =>
                {
                    b.HasOne("OnlineShop.Domain.Basket", "Basket")
                        .WithMany("BasketProducts")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Domain.Product", "Product")
                        .WithMany("BasketProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Domain.OrderedProduct", b =>
                {
                    b.HasOne("OnlineShop.Domain.Order", "Order")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Domain.Product", "Product")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Domain.Product", b =>
                {
                    b.HasOne("OnlineShop.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OnlineShop.Domain.ProductColor", b =>
                {
                    b.HasOne("OnlineShop.Domain.Color", "Color")
                        .WithMany("ProductColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Domain.Product", "Product")
                        .WithMany("ProductColors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Domain.ProductSize", b =>
                {
                    b.HasOne("OnlineShop.Domain.Product", "Product")
                        .WithMany("ProductSizes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Domain.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("OnlineShop.Domain.Auth.User", b =>
                {
                    b.Navigation("Basket")
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Domain.Basket", b =>
                {
                    b.Navigation("BasketProducts");
                });

            modelBuilder.Entity("OnlineShop.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineShop.Domain.Color", b =>
                {
                    b.Navigation("ProductColors");
                });

            modelBuilder.Entity("OnlineShop.Domain.Order", b =>
                {
                    b.Navigation("OrderedProducts");
                });

            modelBuilder.Entity("OnlineShop.Domain.Product", b =>
                {
                    b.Navigation("BasketProducts");

                    b.Navigation("OrderedProducts");

                    b.Navigation("ProductColors");

                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("OnlineShop.Domain.Size", b =>
                {
                    b.Navigation("ProductSizes");
                });
#pragma warning restore 612, 618
        }
    }
}
