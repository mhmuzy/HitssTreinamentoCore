using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Context;
using Projeto.Data.Contracts;

namespace Projeto.Data.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        //atributo
        //private readonly DataContext context;

        ////construtor para injeção de dependência
        //public UnityOfWork(DataContext context)
        //{
        //    this.context = context;
        //}

        public IFornecedorRepository FornecedorRepository;
        //=> new FornecedorRepository(context);

        public IProdutoRepository ProdutoRepository;

        IFornecedorRepository IUnityOfWork.FornecedorRepository => throw new NotImplementedException();

        IProdutoRepository IUnityOfWork.ProdutoRepository => throw new NotImplementedException();
        //=> new ProdutoRepository(context);
    }
}
