using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.Facades.Common;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using BussinessLayer.Services.AppUserService;
using BussinessLayer.Services.CommentService;
using BussinessLayer.Services.StatusService;
using Riganti.Utils.Infrastructure.Core;


namespace BussinessLayer.Facades
{
    public class CommentFacade : FacadeBase
    {
        private readonly ICommentService commentService;

        public CommentFacade(IUnitOfWorkProvider unitOfWorkProvider, ICommentService commentService) : base(unitOfWorkProvider)
        {
            this.commentService = commentService;
        }


        public int Create(CommentDTO entityDto)
        {
            int returnValue;
            using (UnitOfWorkProvider.Create())
            {
                returnValue = commentService.Create(entityDto);
            }
            return returnValue;
        }

        public void Update(CommentDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                commentService.Update(entityDto);
            }
        }

        public void Delete(CommentDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                commentService.Delete(entityDto.Id);
            }
        }

        public async Task<CommentDTO> GetByIdAsync(int entityId)
        {
            return await commentService.GetAsync(entityId);
        }

        public IEnumerable<CommentDTO> ListAll()
        {
            return commentService.ListAllAsync().Result.Items;
        }
    }
}
