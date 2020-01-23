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
        private readonly DataContext Context;

        //construtor para injeção de dependência
        public BaseRepository()
        {

        }

        public void Alterar(T obj)
        {
            //context.Entry(obj).State = EntityState.Modified;
            //context.SaveChanges();
        }

        public void Excluir(int id)
        {
            //var obj = context.Set<T>().Find(id);

            //context.Entry(obj).State = EntityState.Deleted;
            //context.SaveChanges();
        }

        public void Inserir(T obj)
        {
            //context.Entry(obj).State = EntityState.Added;
            //context.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        //public T ObterPorId(int id)
        //{
        //return context.Set<T>().Find(id);
        //}

        //public List<T> ObterTodos()
        //{
        //return context.Set<T>().ToList();
        //}
    }
}
