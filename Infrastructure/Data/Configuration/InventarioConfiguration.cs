using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            // builder.HasIndex(x => x.).IsUnique();

            // builder.Property(x => x.CO).IsRequired();
            builder.Property(x => x.Idprenda).IsRequired();
            builder.Property(x => x.ValorVtaCop).IsRequired();
            builder.Property(x => x.ValorVtaUsd).IsRequired();

            builder.HasOne(I => I.Prendarenda)
            .WithMany(P => P.inventarios)
            .HasForeignKey(I => I.Idprenda);

        }
    }
}