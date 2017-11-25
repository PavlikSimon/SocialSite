using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.DTO.Enumerations;
using BussinessLayer.Facades;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BussinessLayer.Tests.FacadesTests
{
 
    public class AppUserFacadeTests
    {
        /*
        //[Test]
        public async Task GetCustomerAccordingToEmailAsync_ExistingCustomer_ReturnsCorrectCustomer()
        {
            var RandomNumber = new Random().Next(99999999);
            const string customerEmail = "user@somewhere.com";
            var expectedUser = new AppUserDTO
            {
                Id=0,
                AccessFailedCount = 0,
                Gender = Gender.Male,
                Name = "Name",
                Surname = "Surname",
                UserName = "User" + RandomNumber
            };
            var expectedQueryResult = new QueryResultDto<AppUserDTO, AppUserFilterDto> {Items = new List<AppUserDTO> { expectedUser } };
            var appUserFacade = CreateAppUserFacade(expectedQueryResult);

            var actualUser = await appUserFacade.GetCustomerAccordingToEmailAsync(customerEmail);

            Assert.AreEqual(actualUser, expectedUser);
        }
        
       
        private static AppUserFacade CreateAppUserFacade(QueryResultDto<AppUserDTO, AppUserFilterDto> expectedQueryResult)
        {
            var mockManager = new FacadeMockManager();
            var uowMock = FacadeMockManager.ConfigureUowMock();
            var mapper = FacadeMockManager.ConfigureRealMapper();
            var repositoryMock = mockManager.ConfigureRepositoryMock<Customer>();
            var queryMock = mockManager.ConfigureQueryObjectMock<CustomerDto, Customer, CustomerFilterDto>(expectedQueryResult);
            var customerService = new CustomerService(mapper, repositoryMock.Object, queryMock.Object);
            var customerFacade = new CustomerFacade(uowMock.Object, customerService);
            return customerFacade;
        }



    */
    }

}
