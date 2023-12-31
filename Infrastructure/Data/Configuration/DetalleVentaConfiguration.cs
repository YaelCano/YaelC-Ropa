using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");        
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Cantidad);
            builder.Property(x => x.ValorUnit);

            builder.HasOne(D => D.talla)
            .WithMany(C => C.detalleVentas)
            .HasForeignKey(D => D.IdTalla);

            builder.HasOne(D => D.Venta)
            .WithMany(C => C.detalleVentas)
            .HasForeignKey(D => D.IdVenta);

            builder.HasOne(D => D.Inventario)
            .WithMany(C => C.detalleVentas)
            .HasForeignKey(D => D.IdProducto);    
}

}

