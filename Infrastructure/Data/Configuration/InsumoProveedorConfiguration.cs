using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");
            builder.HasKey(t => new { t.IdPorveedor, t.IdInsumo });
            builder.HasKey(t => new { t.IdInsumo, t.IdPorveedor });
            builder.Ignore(t => t.Id);

            builder.HasOne(I => I.Proveedor)
            .WithMany(P => P.insumoProveedores)
            .HasForeignKey(I => I.IdPorveedor);

            builder.HasOne(I => I.Insumo)
            .WithMany(P => P.insumoProveedores)
            .HasForeignKey(I => I.IdInsumo);
        }
    }
}
