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
using BussinessLayer.Services.GroupService;
using BussinessLayer.Services.StatusService;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.Services.Facades;


namespace BussinessLayer.Facades
{
    public class GroupFacade : FacadeBase
    {
        private readonly IGroupService groupService;

        public GroupFacade(IUnitOfWorkProvider unitOfWorkProvider, IGroupService groupService) : base(unitOfWorkProvider)
        {
            this.groupService = groupService;
        }

        public void EnterGroup(AppUserDTO user, GroupDTO group)
        {
            using (UnitOfWorkProvider.Create())
            {
                groupService.EnterGroup(user, group);
            }
            
        }

        public void AddUserToGroup(AppUserDTO user, GroupDTO group)
        {
            using (UnitOfWorkProvider.Create())
            {
                groupService.AddUserToGroup(user, group);
            }

        }

        public int Create(GroupDTO entityDto)
        {
            int returnValue;
            using (UnitOfWorkProvider.Create())
            {
                returnValue = groupService.Create(entityDto);
            }
            return returnValue;
        }

        public void Update(GroupDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                groupService.Update(entityDto);
            }
        }

        public void Delete(GroupDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                groupService.Delete(entityDto.Id);
            }
        }

        public async Task<GroupDTO> GetByIdAsync(int entityId)
        {
            return await groupService.GetAsync(entityId);
        }

        public IEnumerable<GroupDTO> ListAll()
        {
            return groupService.ListAllAsync().Result.Items;
        }
    }
}
