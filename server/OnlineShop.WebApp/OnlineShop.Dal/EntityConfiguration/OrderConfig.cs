﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;

namespace OnlineShop.Dal.EntityConfiguration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.OrderDate).HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.ShippingAmount)
                 .IsRequired();

        }
    }
}
