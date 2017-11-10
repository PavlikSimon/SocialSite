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
    public class AppUserFacade : FacadeBase
    {
        private readonly IAppUserService appUserService;
        private readonly IStatusService statusService;

        public AppUserFacade(IUnitOfWorkProvider unitOfWorkProvider, IAppUserService appUserService) : base(unitOfWorkProvider)
        {
            this.appUserService = appUserService;
        }

        
        /// <summary>
        /// Gets customer according to email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Customer with specified email</returns>
        public async Task<AppUserDTO> GetCustomerAccordingToEmailAsync(string email)
        {
            using (UnitOfWorkProvider.Create())
            {
                return await appUserService.GetAppUserAccordingToEmailAsync(email);
            }
        }
        

        /// <summary>
        /// Gets all appUsers according to page
        /// </summary>
        /// <returns>all appUsers</returns>
        public async Task<QueryResultDto<AppUserDTO, AppUserFilterDto>> GetAllAppUsersAsync()
        {
            using (UnitOfWorkProvider.Create())
            {
                return await appUserService.ListAllAsync();
            }
        }

        /*
        public async Task<IEnumerable<StatusDTO>> ListAppUserStatusesAsync(StatusFilterDto filter)
        {
            using (UnitOfWorkProvider.Create())
            {
                return await statusService.ListUsersStatusesAsync(filter);
            }
        }
        */
    }
}
