using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.AppUserService;
using DAL.Infrastructure;

namespace BussinessLayer.Facades
{
    public class AppUserFacade
    {
        private readonly IAppUserService appUserService;

        public AppUserFacade(IUnitOfWorkProvider unitOfWorkProvider, IAppUserService appUserService) : base(unitOfWorkProvider)
        {
            this.appUserService = appUserService;
        }
        /*
        /// <summary>
        /// Gets customer according to email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Customer with specified email</returns>
        public async Task<CustomerDto> GetCustomerAccordingToEmailAsync(string email)
        {
            const string fakeEmail = "daisy@gmail.com";
            using (UnitOfWorkProvider.Create())
            {
                return await customerService.GetCustomerAccordingToEmailAsync(fakeEmail);
            }
        }

        /// <summary>
        /// Gets all customers according to page
        /// </summary>
        /// <returns>all customers</returns>
        public async Task<QueryResultDto<CustomerDto, CustomerFilterDto>> GetAllCustomersAsync()
        {
            using (UnitOfWorkProvider.Create())
            {
                return await customerService.ListAllAsync();
            }
        }

        ///// <summary>
        ///// Performs customer registration
        ///// </summary>
        ///// <param name="registrationDto">Customer registration details</param>
        ///// <param name="success">argument that tells whether the registration was successful</param>
        ///// <returns>Registered customer account ID</returns>
        //public Guid RegisterCustomer(UserRegistrationDto registrationDto, out bool success)
        //{
        //    // TODO...

        //    if (customerService.GetCustomerAccordingToEmailAsync(registrationDto.Email) != null)
        //    {
        //        success = false;
        //        return new Guid();
        //    }
        //    var accountId = ...
        //    customerService.CreateCustomer(accountId);
        //    success = true;
        //    return accountId;
        //}
        */
    }
}
