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
using BussinessLayer.Services.EventService;
using BussinessLayer.Services.StatusService;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.Services.Facades;


namespace BussinessLayer.Facades
{
    public class EventFacade : FacadeBase
    {
        private readonly IEventService eventService;

        public EventFacade(IUnitOfWorkProvider unitOfWorkProvider, IEventService eventService) : base(unitOfWorkProvider)
        {
            this.eventService = eventService;
        }

        public void SubscribeToEvent(EventDTO eventDTO, AppUserDTO subscribingUser)
        {
            eventService.SubscribeToEvent(eventDTO, subscribingUser);
        }






        public int Create(EventDTO entityDto)
        {
            int returnValue;
            using (UnitOfWorkProvider.Create())
            {
                returnValue = eventService.Create(entityDto);
            }
            return returnValue;
        }

        public void Update(EventDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                eventService.Update(entityDto);
            }
        }

        public void Delete(EventDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                eventService.Delete(entityDto.Id);
            }
        }

        public async Task<EventDTO> GetByIdAsync(int entityId)
        {
            return await eventService.GetAsync(entityId);
        }

        public IEnumerable<EventDTO> ListAll()
        {
            return eventService.ListAllAsync().Result.Items;
        }
    }
}
