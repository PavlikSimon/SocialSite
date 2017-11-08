using DAL.Entities;
using DAL.Infrastructure;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace DAL.Repositories
{
    public class MessageRepository : EntityFrameworkRepository<Message, int, DatabaseContext> //: IRepository<Message>
    {
        public MessageRepository(Riganti.Utils.Infrastructure.Core.IUnitOfWorkProvider unitOfWorkProvider, IDateTimeProvider dateTimeProvider)
            : base(unitOfWorkProvider, dateTimeProvider)
        {
        }

        /*
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
        }*/
    }
}