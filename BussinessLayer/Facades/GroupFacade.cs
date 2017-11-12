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


namespace BussinessLayer.Facades
{
    public class GroupFacade : FacadeBase
    {
        private readonly IGroupService groupService;

        public GroupFacade(IUnitOfWorkProvider unitOfWorkProvider, IGroupService groupService) : base(unitOfWorkProvider)
        {
            this.groupService = groupService;
        }

 
    }
}
