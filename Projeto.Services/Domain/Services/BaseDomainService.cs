using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Services.Contracts.Services;
using System.Data;
using Projeto.Data.Contracts;

namespace Projeto.Services.Domain.Services
{
    public class BaseDomainService<TEntity> 
        : IBaseDomainService<TEntity> where TEntity : class
    {
        //atributo
        private readonly IBaseRepository<TEntity> repository;

        //construtor para injeção de dependência
        public BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Atualizar(TEntity entity)
        {
            repository.Alterar(entity);  
        }

        public void Dispose()
        {
            //repository.
        }

        public void Excluir(int id)
        {
            repository.Excluir(id);
        }

        public List<TEntity> GetEntities()
        {
            return repository.ObterTodos();
        }

        public TEntity GetEntityId(int id)
        {
            return repository.ObterPorId(id);
        }

        public void Inserir(TEntity entity)
        {
            repository.Inserir(entity);
        }
    }
}
