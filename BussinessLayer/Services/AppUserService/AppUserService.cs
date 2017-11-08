using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using DAL.IdentityEntities;

namespace BussinessLayer.Services.AppUserService
{
    public class AppUserService : CRUDBase<AppUser, AppUserDTO, AppUserFilterDto>, IAppUserService
    {
        public AppUserService(IMapper mapper, IRepository<AppUser > appUserRepository, CRUDBase<AppUserDto, AppUser, AppUserFilterDto, IQuery<AppUser>> appUserQueryObject)
            : base(mapper, appUserRepository, customerQueryObject) { }

        protected override async Task<AppUser> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetAsync(entityId);
        }

        /// <summary>
        /// Gets customer with given email address
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Customer with given email address</returns>
        public async Task<CustomerDto> GetCustomerAccordingToEmailAsync(string email)
        {
            var queryResult = await Query.ExecuteQuery(new CustomerFilterDto { Email = email });
            return queryResult.Items.SingleOrDefault();
        }
    }
}
