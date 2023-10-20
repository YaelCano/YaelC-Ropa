using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("ModuloNotificaciones");

            builder.HasKey(x => x.Id);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descripcion);
            builder.Property(x => x.SueldoBase);
        }
    }
}