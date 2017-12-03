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
using Riganti.Utils.Infrastructure.Services.Facades;


namespace BussinessLayer.Facades
{
    public class AppUserFacade : FacadeBase
    {
        private readonly AppUserService appUserService;
        //private readonly IStatusService statusService;

        public AppUserFacade(IUnitOfWorkProvider unitOfWorkProvider, AppUserService appUserService) : base(unitOfWorkProvider)
        {
            this.appUserService = appUserService;
        }

        public void CreateFriendship(AppUserDTO user1, AppUserDTO user2)
        {
            appUserService.CreateFriendship(user1, user2);
        }

        public void RemoveFriendship(AppUserDTO user1, AppUserDTO user2)
        {
            appUserService.RemoveFriendship(user1, user2);
        }
        
        /// <summary>
        /// Gets customer according to email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Customer with specified email</returns>
        public async Task<AppUserDTO> GetCustomerAccordingToEmailAsync(string email)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                //uow.Commit();
                return await appUserService.GetAppUserAccordingToEmailAsync(email);
                //uow.RegisterAfterCommitAction(confirmationAction);
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



        public int Create(AppUserDTO entityDto)
        {
            int returnValue;
            using (UnitOfWorkProvider.Create())
            {
                returnValue = appUserService.Create(entityDto);
            }
            return returnValue;
        }

        public void Update(AppUserDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                appUserService.Update(entityDto);
            }
        }

        public void Delete(AppUserDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                appUserService.Delete(entityDto.Id);
            }
        }

        public async Task<AppUserDTO> GetByIdAsync(int entityId)
        {
            return await appUserService.GetAsync(entityId);
        }

        public IEnumerable<AppUserDTO> ListAll()
        {
            return appUserService.ListAllAsync().Result.Items;
        }

    }
}
