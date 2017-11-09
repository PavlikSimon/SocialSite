using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects;
using BussinessLayer.Services.GroupService;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;

namespace BussinessLayer.Services.GroupService
{
    public class MessageService : CRUDBase<Message, MessageDTO, MessageFilterDto>, IMessageService
    {
        public MessageService(IMapper mapper, IRepository<Message, int> messageRepository, MessageQueryObject messageQueryObject)
            : base(mapper, messageRepository, messageQueryObject) { }

        protected override async Task<Message> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetByIdAsync(entityId);
        }

        /*
        /// <summary>
        /// Gets customer with given email address
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Customer with given email address</returns>
        public async Task<AppUserDTO> GetCustomerAccordingToEmailAsync(string email)
        {
            var users = await Repository.GetAll();
            return  Mapper.Map<AppUser, AppUserDTO>(users.SingleOrDefault(a => a.Email == email));
        }


        public void createFriendship(AppUserDTO user1, AppUserDTO user2)
        {
            throw new NotImplementedException();
        }
        */


    }
}
