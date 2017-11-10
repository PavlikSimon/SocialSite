using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects;
using DAL.IdentityEntities;

namespace BussinessLayer.Services.AppUserService
{
    public class AppUserService : CRUDBase<AppUser, AppUserDTO, AppUserFilterDto>, IAppUserService
    {
        public AppUserService(IMapper mapper, IRepository<AppUser, int> appUserRepository, AppUserQueryObject appUserQueryObject)
            : base(mapper, appUserRepository, appUserQueryObject) { }

        protected override async Task<AppUser> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetByIdAsync(entityId);
        }

        /// <summary>
        /// Gets customer with given email address
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Customer with given email address</returns>
        public async Task<AppUserDTO> GetAppUserAccordingToEmailAsync(string email)
        {
            var users = await Repository.GetAll();
            return  Mapper.Map<AppUser, AppUserDTO>(users.SingleOrDefault(a => a.Email == email));
        }


        public void createFriendship(AppUserDTO user1, AppUserDTO user2)
        {
            throw new NotImplementedException();
        }
    }
}
