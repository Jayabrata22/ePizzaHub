using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodOrder.Repositories.Interfaces
{
    public interface IRepositoryy<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity FindById(object id);
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(object id);
        public void Remove(TEntity entity);

        public int Savechanges();
    }
}
