using DAL.Entities;
using System;
using DAL.Infrastructure;


namespace DAL.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private IUnitOfWorkProvider unitOfWorkProvider;

        public DatabaseContext Context =>
            ((EntityFrameworkUnitOfWork) unitOfWorkProvider.GetUnitOfWorkInstance()).GetContext();

        public CommentRepository(IUnitOfWorkProvider unitOfWorkProvider)
        {
            this.unitOfWorkProvider = unitOfWorkProvider ?? throw new ArgumentNullException(nameof(unitOfWorkProvider));
        }

        public void Add(Comment entity)
        {
            Context.Comments.Add(entity);
        }

        public void Delete(Comment entity)
        {
            Context.Comments.Remove(entity);
        }

        public Comment GetById(int id)
        {
            return Context.Comments.Find(id);
        }

        public void Update(Comment entity)
        {
            var foundComment = Context.Comments.Find(entity.Id);
            Context.Entry(foundComment).CurrentValues.SetValues(entity);
        }
    }
}
