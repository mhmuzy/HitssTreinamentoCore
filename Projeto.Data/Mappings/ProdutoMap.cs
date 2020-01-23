using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entities;

namespace Projeto.Data.Mappings
{
    //classe de mapeamento para a entidade Produto
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //builder.ToTable("Produto");

            //        builder.HasKey(p => p.IdProduto);

            //        builder.Property(p => p.IdProduto);

            //        builder.Property(p => p.Nome)
            //            .HasMaxLength(150)
            //            .IsRequired();

            //        builder.Property(p => p.Preco)
            //            .IsRequired();

            //        builder.Property(p => p.Quantidade)
            //            .IsRequired();
        }
    }
}
