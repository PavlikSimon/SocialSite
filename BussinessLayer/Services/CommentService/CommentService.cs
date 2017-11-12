using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;

namespace BussinessLayer.Services.CommentService
{
    public class CommentService : CRUDBase<Comment, CommentDTO, CommentFilterDto>, ICommentService
    {
        public CommentService(IMapper mapper, IRepository<Comment, int> commentRepository, CommentQueryObject commentQueryObject,
            IRepository<Status, int> statusRepository)
            : base(mapper, commentRepository, commentQueryObject)
        {
            _statusRepository = statusRepository;
        }

        private readonly IRepository<Status, int> _statusRepository;

        protected override async Task<Comment> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetByIdAsync(entityId);
        }

        public void AddComment(StatusDTO status, CommentDTO comment, AppUserDTO user)
        {
            this.Create(comment);
            Comment repComment = Mapper.Map<CommentDTO, Comment>(comment);
            Status repStatus = Mapper.Map<StatusDTO, Status>(status);
            AppUser repUser = Mapper.Map<AppUserDTO, AppUser>(user);
            repComment.Status = repStatus;
            repComment.CreatedBy = repUser;
            repStatus.Comments.Add(repComment);
            Repository.Update(repComment);
            _statusRepository.Update(repStatus);
        }
 


    }
}
