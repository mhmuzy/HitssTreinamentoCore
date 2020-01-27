using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services.Contracts.Services
{
    public interface IBaseDomainService<TEntity> 
        : IDisposable where TEntity : class
    {

        void Inserir(TEntity entity);

        void Atualizar(TEntity entity);

        void Excluir(int id);

        List<TEntity> GetEntities();

        TEntity GetEntityId(int id);

    }
}
