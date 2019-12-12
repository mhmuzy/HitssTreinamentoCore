using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Contracts
{
    public interface IUnityOfWork
    {
        IFornecedorRepository FornecedorRepository
        {
            get;
        }

        IProdutoRepository ProdutoRepository
        {
            get;
        }
    }
}
