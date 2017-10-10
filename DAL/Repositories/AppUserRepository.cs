using DAL.IdentityEntities;
using DAL.Infrastructure;

namespace DAL.Repositories
{
    public class AppUserRepository : IRepository<AppUser>
    {
        private IUnitOfWorkProvider unitOfWorkProvider;

        public DatabaseContext Context =>
            ((EntityFrameworkUnitOfWork)unitOfWorkProvider.GetUnitOfWorkInstance()).GetContext();
        
        public void Add(AppUser entity)
        {
            throw new System.NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(AppUser entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(AppUser entity)
        {
            throw new System.NotImplementedException();
        }
    }
}