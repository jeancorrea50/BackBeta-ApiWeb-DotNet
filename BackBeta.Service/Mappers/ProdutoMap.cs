using BackBeta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Infrastructure.CrossCutting.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao)
                  .IsRequired()
                  .HasMaxLength(100)
                  .HasColumnType("varchar");
        }

    }
}
