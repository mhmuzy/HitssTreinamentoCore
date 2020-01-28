using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Projeto.Services;

namespace Projeto.Services.Domain.Services
{
    public class ProdutoDomainService
        : BaseDomainService<Produtos>
    {
        private readonly IProdutoRepository repository;

        //public ProdutoDomainService(IProdutoRepository repository)
        //{
        //    this.repository = repository;
        //}

        public ProdutoDomainService(IBaseRepository<Produtos> repository) : base(repository)
        {

        }

        public override bool Equals(object obj)
        {
            var service = obj as ProdutoDomainService;
            return service != null &&
                   EqualityComparer<IProdutoRepository>.Default.Equals(repository, service.repository);
        }
    }
}
