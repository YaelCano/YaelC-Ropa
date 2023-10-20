using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
         public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");
            //TODO: llave compuesta
            builder.HasKey(t => new { t.IdInsumo, t.Idprenda });
            builder.HasKey(t => new { t.Idprenda, t.IdInsumo });
            builder.Ignore(t => t.Id);

            builder.HasOne(I => I.Insummo)
            .WithMany(P => P.insumoPrendas)
            .HasForeignKey(I => I.IdInsumo);

            builder.HasOne(I => I.prenda)
            .WithMany(P => P.insumoPrendas)
            .HasForeignKey(I => I.Idprenda);
        }
    }
}