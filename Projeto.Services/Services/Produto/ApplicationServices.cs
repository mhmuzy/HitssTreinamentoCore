using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Services.Contracts;
using Projeto.Services.Models.Produtos;
using Projeto.Services.Contracts.Services.Produto;
using AutoMapper;
using Projeto.Data.Entities;

namespace Projeto.Services.Services.Produto
{
    public class ApplicationServices : IProdutoAplicationServices
    {
        //atributo
        private readonly IDomainService domainServices;
        private readonly IMapper mapper;

        public ApplicationServices(IDomainService domainServices, IMapper mapper)
        {
            this.domainServices = domainServices;
            this.mapper = mapper;
        }

        public void Atualizar(Editar editar)
        {
            var produto = mapper.Map<Produtos>(editar);
        }

        public Consultar ConsultarPorId(int id)
        {
            var produto = domainServices.GetEntityId(id);
            return mapper.Map<Consultar>(produto);
        }

        public List<Consultar> consultars()
        {
            var lista = domainServices.GetEntities();
            return mapper.Map<List<Consultar>>(lista);
        }

        public void Dispose()
        {
            domainServices.Dispose();
        }

        public void Excluir(int id)
        {
            var produto = domainServices.GetEntityId(id);
            domainServices.Excluir(id);
        }

        public void Inserir(Cadastro cadastro)
        {
            var produto = mapper.Map<Produtos>(cadastro);
            domainServices.Inserir(produto);
        }
    }
}
