using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;

namespace Projeto.Services.Domain.Services
{
    public class FornecedorDomainServices
        : BaseDomainService<Fornecedores>
    {
        private readonly IFornecedorRepository repository;

        //public FornecedorDomainServices(IFornecedorRepository repository)
        //{
        //    this.repository = repository;
        //}

        public FornecedorDomainServices(IBaseRepository<Fornecedores> repository) : base(repository)
        {

        }

        public override bool Equals(object obj)
        {
            var services = obj as FornecedorDomainServices;
            return services != null &&
                   EqualityComparer<IFornecedorRepository>.Default.Equals(repository, services.repository);
        }

        //public FornecedorDomainServices(IFornecedorRepository repository)
        //{
        //    this.repository = repository;
        //}

    }
}
