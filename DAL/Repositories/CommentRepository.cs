using DAL.Entities;
using System;
using DAL.Infrastructure;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;


namespace DAL.Repositories
{
   
        public class CommentRepository : EntityFrameworkRepository<Comment, int, DatabaseContext>  //IRepository<Status>
        {

            public CommentRepository(Riganti.Utils.Infrastructure.Core.IUnitOfWorkProvider unitOfWorkProvider, IDateTimeProvider dateTimeProvider)
                : base(unitOfWorkProvider, dateTimeProvider)
            {
            }

        }
    }