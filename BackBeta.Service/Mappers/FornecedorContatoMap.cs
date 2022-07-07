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
    public class FornecedorContatoMap : IEntityTypeConfiguration<FornecedorContatoEntity>
    {
        public void Configure(EntityTypeBuilder<FornecedorContatoEntity> builder)
        {
            builder.ToTable("FornecedorContato");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                  .IsRequired()
                  .HasMaxLength(100);
        }

    }
}
