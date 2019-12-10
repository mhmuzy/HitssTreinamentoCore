using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entities;

namespace Projeto.Data.Mappings
{
    // classe de mapeamentos para a entidade Fornecedor
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            //nome da tabela
            //builder.ToTable("Fornecedor");

            //chave primária
            builder.HasKey(f => f.IdFornecedor);

            builder.Property(f => f.Nome);
                //.HasColumnName("Nome")
                //.Has
        }
    }
}
