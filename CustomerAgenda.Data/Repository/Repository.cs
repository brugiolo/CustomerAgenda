using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using CustomerAgenda.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CustomerAgenda.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly CustomerAgendaContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(CustomerAgendaContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public TEntity Read(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public IEnumerable<TEntity> List()
        {
            return DbSet.AsQueryable();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
