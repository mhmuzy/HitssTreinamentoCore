﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projeto.Data.Mappings;
using Projeto.Data.Entities;
using System.Reflection.Emit;

namespace Projeto.Data.Context
{
    //REGRA 1) Herdar DbContext
    public class DataContext2 //: DbContext
    {
        //REGRA 2) Sobrescrever o método OnModelCreating
        //e neste método adicionar cada classe de mapéamento
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //adicionar cada classe de mapeamento do projeto
    
        //    modelBuilder.ApplyConfiguration(new FornecedorMap());
        //    modelBuilder.ApplyConfiguration(new ProdutoMap());
        //}

        //REGRA 3) Declarar uma property 'DbSet' para cada entidade do projeto
        //public DbSet<Fornecedor> Fornecedor
        //{
        //   get;
        //   set;
        //}

        //    public DbSet<Produto> Produto
        //    {
        //        get;
        //        set;
        //    }
    }

    
}
