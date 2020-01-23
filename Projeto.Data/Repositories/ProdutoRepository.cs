using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Context;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;

namespace Projeto.Data.Repositories
{
    public class ProdutoRepository
        : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DataContext context;

        public ProdutoRepository()
            : base()
        {
            
        }
    }
}
