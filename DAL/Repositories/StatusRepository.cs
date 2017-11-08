using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace DAL.Repositories
{
    public class StatusRepository : EntityFrameworkRepository<Status, int, DatabaseContext>  //IRepository<Status>
    {

        public StatusRepository(Riganti.Utils.Infrastructure.Core.IUnitOfWorkProvider unitOfWorkProvider, IDateTimeProvider dateTimeProvider)
            : base(unitOfWorkProvider, dateTimeProvider)
        {
        }



        // private IUnitOfWorkProvider unitOfWorkProvider;

        /*public DatabaseContext Context =>
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
*/

    }
}