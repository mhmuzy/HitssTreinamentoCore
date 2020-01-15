using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Services.Contracts;
using Projeto.Services.Models.Fornecedor;
using AutoMapper;
using Projeto.Data.Entities;
using Projeto.Services.Contracts.Services.Fornecedor;

namespace Projeto.Services.Services.Fornecedor
{
    public class ApplicationServices : IFornecedorApplicationServices
    {
        //atributo
        private readonly IDomainService domainService;
        private readonly IMapper mapper;

        public ApplicationServices(IDomainService domainService, IMapper mapper)
        {
            this.domainService = domainService;
            this.mapper = mapper;
        }

        public void Atualizar(Editar editar)
        {
            var fornecedor = mapper.Map<Fornecedores>(editar);
        }

        public List<Consultar> consultars()
        {
            var lista = domainService.GetEntities();
            return mapper.Map<List<Consultar>>(lista);
        }

        public void Dispose()
        {
            domainService.Dispose();
        }

        public void Excluir(int id)
        {
            var fornecedor = domainService.GetEntityId(id);
            domainService.Excluir(fornecedor);
        }

        public Consultar GetConsultarId(int id)
        {
            var fornecedor = domainService.GetEntityId(id);
            return mapper.Map<Consultar>(fornecedor);
        }

        public void Inserir(Cadastro cadastro)
        {
            var fornecedor = mapper.Map<Fornecedores>(cadastro);
            domainService.Inserir(fornecedor);
        }
    }
}
