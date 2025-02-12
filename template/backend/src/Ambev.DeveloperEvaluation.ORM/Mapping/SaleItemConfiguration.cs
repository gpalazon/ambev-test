﻿using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItens");

        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(s => s.ProductName).IsRequired().HasMaxLength(100);
        builder.Property(s => s.Quantity).IsRequired();
        builder.Property(s => s.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(s => s.Discount).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(s => s.TotalItemAmount).IsRequired().HasColumnType("decimal(18,2)");

        builder.HasOne<Sale>()
           .WithMany(s => s.Items)
           .HasForeignKey(i => i.SaleId)
           .OnDelete(DeleteBehavior.Cascade);

    }


}
