using Lancamentos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancamentos.Data.Mapping
{
    public class MovimentacaoMapping : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Valor)
                .IsRequired();

            builder.Property(prop => prop.Data)
               .IsRequired();
        }
    }
}
