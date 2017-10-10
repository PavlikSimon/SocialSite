using DAL.Entities;
using DAL.Infrastructure;

namespace DAL.Repositories
{
    public class StatusRepository : IRepository<Status>
    {
        private IUnitOfWorkProvider unitOfWorkProvider;

        public DatabaseContext Context =>
            ((EntityFrameworkUnitOfWork)unitOfWorkProvider.GetUnitOfWorkInstance()).GetContext();

        public void Add(Status entity)
        {
            throw new System.NotImplementedException();
        }

        public Status GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Status entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Status entity)
        {
            throw new System.NotImplementedException();
        }
    }
}