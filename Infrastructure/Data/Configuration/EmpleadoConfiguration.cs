using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdEmp).IsUnique();

            builder.HasOne(e => e.Cargo)
            .WithMany(c => c.empleados)
            .HasForeignKey(e => e.IdCargo);

            builder.HasOne(E => E.Municipio)
            .WithMany(f => f.Empleados)
            .HasForeignKey(r => r.IdMunicipio);
        }
    }
}