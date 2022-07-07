using BackBeta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.AppService.Mappers
{
    public class PedidoMap : IEntityTypeConfiguration<PedidoEntity>
    {
        public void Configure(EntityTypeBuilder<PedidoEntity> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                  .IsRequired()
                  .HasMaxLength(100)
                  .HasColumnType("varchar");
        }
    }
}
