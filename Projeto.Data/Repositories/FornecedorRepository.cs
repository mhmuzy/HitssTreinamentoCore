using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Entities;
using Projeto.Data.Context;
using Projeto.Data.Contracts;

namespace Projeto.Data.Repositories
{
    public class FornecedorRepository
        //: BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly DataContext context;

        public FornecedorRepository()
            : base() //construtor da superclasse
        {

        }

        //public FornecedorRepository(DataContext context)
        //{
        //    this.context = context;
        //}
    }
}
