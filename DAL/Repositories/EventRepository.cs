using DAL.Entities;
using DAL.Infrastructure;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;

namespace DAL.Repositories
{
    
        public class EventRepository : EntityFrameworkRepository<Event, int, DatabaseContext>  //IRepository<Status>
        {

            public EventRepository(Riganti.Utils.Infrastructure.Core.IUnitOfWorkProvider unitOfWorkProvider, IDateTimeProvider dateTimeProvider)
                : base(unitOfWorkProvider, dateTimeProvider)
            {
            }

        }
    }