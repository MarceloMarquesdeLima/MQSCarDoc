﻿
using MQSCarDoc.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MQSCarDoc.DAL.Interfaces
{
    public class RepositoryBase<T> : IRepository<T>, IDisposable where T : class
    {
        private MQSCarDocContext Context;

        public RepositoryBase()
        {
            Context = new MQSCarDocContext();
        }
        public IQueryable<T> GetTodos()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return  Context.Set<T>().Where(predicate);
        }

        public T Find(params object[] key)
        {
            return Context.Set<T>().Find(key);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public void Adicionar(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Atualizar(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Deletar(Func<T, bool> predicate)
        {
            Context.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => Context.Set<T>().Remove(del));
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}

