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

namespace BussinessLayer.Services.EventService
{
    public class EventService : CRUDBase<Event, EventDTO, EventFilterDto>, IEventService
    {
        public EventService(IMapper mapper, IRepository<Event, int> eventRepository, EventQueryObject eventQueryObject, IRepository<AppUser, int> userRepository)
            : base(mapper, eventRepository, eventQueryObject)
        {
            this._userRepository = userRepository;
        }

        private readonly IRepository<AppUser, int> _userRepository;

        protected override async Task<Event> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetByIdAsync(entityId);
        }

        

        public void SubscribeToEvent(EventDTO event_, AppUserDTO subscribingUser)
        {
            AppUser repUser = Mapper.Map<AppUserDTO, AppUser>(subscribingUser);
            Event repEvent = Mapper.Map<EventDTO, Event>(event_);
            repUser.EventsAttended.Add(repEvent);
            repEvent.Guests.Add(repUser);
            Repository.Update(repEvent);
            _userRepository.Update(repUser);
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
