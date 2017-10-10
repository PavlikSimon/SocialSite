namespace DAL.Infrastructure
{
    public class EntityFrameworkUnitOfWorkProvider : IUnitOfWorkProvider
    {
        //ToDo change to some parralel friendly variable
        protected IUnitOfWork localUowInstance;
        
        public IUnitOfWork Create()
        {
            localUowInstance = new EntityFrameworkUnitOfWork();
            return localUowInstance;
        }

        public IUnitOfWork GetUnitOfWorkInstance()
        {
            return localUowInstance;
        }
    }
}