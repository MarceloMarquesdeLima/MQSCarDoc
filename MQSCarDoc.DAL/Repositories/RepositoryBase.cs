
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MQSCarDoc.DAL.Interfaces
{
    public class RepositoryBase<T> : IRepository<T>, IDisposable where T : class
    {
        public void Adicionar(T entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Deletar(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Find(params object[] key)
        {
            throw new NotImplementedException();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetTodos()
        {
            throw new NotImplementedException();
        }
    }
}
