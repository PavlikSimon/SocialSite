using DAL.Infrastructure;

namespace DAL.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private IUnitOfWorkProvider unitOfWorkProvider;

        public DatabaseContext Context =>
            ((EntityFrameworkUnitOfWork)unitOfWorkProvider.GetUnitOfWorkInstance()).GetContext();

        public void Add(Group entity)
        {
            throw new System.NotImplementedException();
        }

        public Group GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Group entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Group entity)
        {
            throw new System.NotImplementedException();
        }
    }
}