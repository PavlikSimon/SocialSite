using DAL.IdentityEntities;
using DAL.Infrastructure;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace DAL.Repositories
{
    public class AppUserRepository : EntityFrameworkRepository<AppUser, int, DatabaseContext>  //IRepository<Status>
    {

        public AppUserRepository(Riganti.Utils.Infrastructure.Core.IUnitOfWorkProvider unitOfWorkProvider, IDateTimeProvider dateTimeProvider)
            : base(unitOfWorkProvider, dateTimeProvider)
        {
        }

    }
}