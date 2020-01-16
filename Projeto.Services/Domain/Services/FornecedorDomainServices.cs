using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Data.Contracts;

namespace Projeto.Services.Domain.Services
{
    public class FornecedorDomainServices
        : BaseDomainService<Fornecedores>
    {
        private readonly IFornecedorRepository repository;

        public FornecedorDomainServices(IFornecedorRepository repository)
        {
            this.repository = repository;
        }
    }
}
