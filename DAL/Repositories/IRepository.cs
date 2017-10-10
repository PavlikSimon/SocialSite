using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T entity);

        T GetById(int id);

        void Delete(T entity);

        void Update(T entity);
    }
}
