using eFoodOrder.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodOrder.Repositories.implementation
{
    public class Repositoryy<TEntity> : IRepositoryy<TEntity> where TEntity : class
    {
        protected DbContext _appDBContext;
        public Repositoryy(DbContext dbContext)
        {
            _appDBContext = dbContext;
        }

        public void Add(TEntity entity)
        {
           _appDBContext.Set<TEntity>().Add(entity);
        }

        public void Delete(object id)
        {
            TEntity entity = _appDBContext.Set<TEntity>().Find(id);
            if (entity != null)
            {
                _appDBContext.Set<TEntity>().Remove(entity);
            }

        }

        public TEntity FindById(object id)
        {
            return _appDBContext.Set<TEntity>().Find(id); 
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _appDBContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _appDBContext.Set<TEntity>().Remove(entity);
        }

        public int Savechanges()
        {
            return _appDBContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _appDBContext.Set<TEntity>().Update(entity);
        }
    } 
}
