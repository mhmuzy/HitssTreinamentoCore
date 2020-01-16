using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Services;

namespace Projeto.Services.Domain.Services
{
    public class ProdutoDomainService
        : BaseDomainService<Produtos>
    {
        private readonly IProdutoRepository repository;

        public ProdutoDomainService(IProdutoRepository repository)
        {
            this.repository = repository;
        }
    }
}
