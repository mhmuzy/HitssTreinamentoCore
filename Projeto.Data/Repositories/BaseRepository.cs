using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projeto.Data.Context;
using Projeto.Data.Contracts;
using System.Linq;

namespace Projeto.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        //atributo
        private readonly DataContext context;

        //construtor para injeção de dependência
        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Alterar(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T obj)
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
