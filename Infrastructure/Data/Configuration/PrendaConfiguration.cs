using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdPrenda).IsUnique();
            builder.Property(x => x.Nombre).IsRequired();
            builder.Property(x => x.ValorUnitCop).IsRequired();
            builder.Property(x => x.ValorUnitUsd).IsRequired();

            builder.HasOne(P => P.Estado)
            .WithMany(E => E.prendas)
            .HasForeignKey(P => P.IdEstado);

            builder.HasOne(P => P.Genero)
            .WithMany(G => G.prendas)
            .HasForeignKey(P => P.IdGenero);

            builder.HasOne(P => P.TipoProteccion)
            .WithMany(T => T.prendas)
            .HasForeignKey(P => P.IdTipoProteccion);
        }
    }
}