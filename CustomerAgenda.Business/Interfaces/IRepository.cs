using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;

namespace CustomerAgenda.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        void Insert(TEntity entity);
        TEntity Read(Guid id);
        void Update(TEntity entity);
        void Delete(Guid id);
        IEnumerable<TEntity> List();
        int SaveChanges();
    }
}
