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

    }
}
