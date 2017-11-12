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


namespace BussinessLayer.Facades
{
    public class EventFacade : FacadeBase
    {
        private readonly IEventService eventService;

        public EventFacade(IUnitOfWorkProvider unitOfWorkProvider, IEventService eventService) : base(unitOfWorkProvider)
        {
            this.eventService = eventService;
        }

 
    }
}
