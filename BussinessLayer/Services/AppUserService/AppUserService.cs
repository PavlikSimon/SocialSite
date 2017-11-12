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
            AppUserFilterDto filter = new AppUserFilterDto {Email = email};
            var result = await Query.ExecuteQuery(filter);
            return result.Items.SingleOrDefault();
            
        }


        public void CreateFriendship(AppUserDTO user1, AppUserDTO user2)
        {
            AppUser repUser1 = Mapper.Map<AppUserDTO, AppUser>(user1);
            AppUser repUser2 = Mapper.Map<AppUserDTO, AppUser>(user2);
            repUser1.Friends.Add(repUser2);
            repUser2.Friends.Add(repUser1);
            Repository.Update(repUser2);
            Repository.Update(repUser1);
        }

        public void RemoveFriendship(AppUserDTO user1, AppUserDTO user2)
        {
            AppUser repUser1 = Mapper.Map<AppUserDTO, AppUser>(user1);
            AppUser repUser2 = Mapper.Map<AppUserDTO, AppUser>(user2);
            repUser2.Friends.Remove(repUser1);
            repUser1.Friends.Remove(repUser2);
            Repository.Update(repUser2);
            Repository.Update(repUser1);
        }
    }
}
