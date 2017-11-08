using DAL.Entities;
using DAL.Infrastructure;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace DAL.Repositories
{
    public class GroupRepository : EntityFrameworkRepository<Group, int, DatabaseContext>  //IRepository<Status>
    {

        public GroupRepository(Riganti.Utils.Infrastructure.Core.IUnitOfWorkProvider unitOfWorkProvider, IDateTimeProvider dateTimeProvider)
            : base(unitOfWorkProvider, dateTimeProvider)
        {
        }

    }
}