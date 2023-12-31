using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fecha);

            builder.HasOne(v => v.FormaPago)
            .WithMany(f => f.ventas)
            .HasForeignKey(V => V.IdFormaPago);

            builder.HasOne(V => V.Cliente)
            .WithMany(C => C.Ventas)
            .HasForeignKey(V => V.IdCliente);

            builder.HasOne(V => V.Empleado)
            .WithMany(E => E.ventas)
            .HasForeignKey(V => V.IdEmpleado);

        }
}
