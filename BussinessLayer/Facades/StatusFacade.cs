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
using BussinessLayer.Services.StatusService;
using Riganti.Utils.Infrastructure.Core;



namespace BussinessLayer.Facades
{
    public class StatusFacade : FacadeBase
    {
        private readonly IStatusService statusService;

        public StatusFacade(IUnitOfWorkProvider unitOfWorkProvider, IStatusService statusService) : base(unitOfWorkProvider)
        {
            this.statusService = statusService;
        }

        public int Create(StatusDTO status)
        {
            int returnValue;
            using (UnitOfWorkProvider.Create())
            {
                returnValue = statusService.Create(status);
            }
            return returnValue;
        }

        public void Update(StatusDTO status)
        {
            using (UnitOfWorkProvider.Create())
            {
                statusService.Update(status);
            }
        }

        public void Delete(StatusDTO status)
        {
            using (UnitOfWorkProvider.Create())
            {
                statusService.Delete(status.Id);
            }

        }

        public async Task<StatusDTO> GetByIdAsync(int statusId)
        {
            return await statusService.GetAsync(statusId);
        }

        public IEnumerable<StatusDTO> ListAll()
        {
            return statusService.ListAllAsync().Result.Items;
        }

        public void PostStatusToGroup(StatusDTO status, GroupDTO group)
        {
            statusService.PostStatusToGroup(status, group);
        }

        public void PostStatusToEvent(StatusDTO status, EventDTO event_)
        {
            statusService.PostStatusToEvent(status, event_);
        }



    }
}
