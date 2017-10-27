using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : IEntity<int>
    {
        void Add(T entity);

        T GetById(int id);

        void Delete(T entity);

        void Update(T entity);
    }
}
