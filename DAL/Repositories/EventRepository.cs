using DAL.Entities;
using DAL.Infrastructure;

namespace DAL.Repositories
{
    public class EventRepository : IRepository<Event>
    {
        private IUnitOfWorkProvider unitOfWorkProvider;

        public DatabaseContext Context =>
            ((EntityFrameworkUnitOfWork)unitOfWorkProvider.GetUnitOfWorkInstance()).GetContext();

        public void Add(Event entity)
        {
            Context.Events.Add(entity);
        }

        public Event GetById(int id)
        {
            return Context.Events.Find(id);
        }

        public void Delete(Event entity)
        {
            Context.Events.Remove(entity);
        }

        public void Update(Event entity)
        {
            var foundEvent = Context.Events.Find(entity.Id);
            Context.Entry(foundEvent).CurrentValues.SetValues(entity);
        }
    }
}