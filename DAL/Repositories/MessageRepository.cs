using DAL.Entities;
using DAL.Infrastructure;

namespace DAL.Repositories
{
    public class MessageRepository : IRepository<Message>
    {
        private IUnitOfWorkProvider unitOfWorkProvider;

        public DatabaseContext Context =>
            ((EntityFrameworkUnitOfWork)unitOfWorkProvider.GetUnitOfWorkInstance()).GetContext();

        public void Add(Message entity)
        {
            throw new System.NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Message entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new System.NotImplementedException();
        }
    }
}