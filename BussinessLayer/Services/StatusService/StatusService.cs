using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects;
using BussinessLayer.QueryObjects.Common;
using BussinessLayer.Services.GroupService;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;
using QueryInfrastracture;


namespace BussinessLayer.Services.StatusService
{
    public class StatusService : CRUDBase<Status, StatusDTO, StatusFilterDto>, IStatusService
    {
        private readonly QueryObjectBase<AppUserDTO, AppUser, AppUserFilterDto, QueryInfrastracture.IQuery<AppUser>> appUserQueryObject;

        private readonly IRepository<Group, int> _groupRepository;

        private readonly IRepository<Event, int> _eventRepository;

        public void PostStatusToGroup(StatusDTO status, GroupDTO group)
        {
            Create(status);
            Status repStatus = Mapper.Map<Status>(status);
            Group repGroup = Mapper.Map<Group>(group);
            repStatus.Group = repGroup;
            repGroup.Statuses.Add(repStatus);
            _groupRepository.Update(repGroup);
            Repository.Update(repStatus);

        }

        public void PostStatusToEvent(StatusDTO status, EventDTO event_)
        {
            Create(status);
            Status repStatus = Mapper.Map<Status>(status);
            Event repEvent = Mapper.Map<Event>(event_);
            repStatus.Event = repEvent;
            repEvent.Statuses.Add(repStatus);
            _eventRepository.Update(repEvent);
            Repository.Update(repStatus);
        }


        public StatusService(IMapper mapper, IRepository<Status, int> statusRepository,
            StatusQueryObject statusQueryObject, IRepository<Group, int> groupRepository,
            IRepository<Event, int> eventRepository)
            : base(mapper, statusRepository, statusQueryObject)
        {
            _groupRepository = groupRepository;
            _eventRepository = eventRepository;
        }

        protected override async Task<Status> GetWithIncludesAsync(int entityId)
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

            /*
        public async Task<IEnumerable<AppUserDTO>> ListUsersStatusesAsync(AppUserFilterDto filter)
        {
            return (await appUserQueryObject.ExecuteQuery(filter)).Items;
        }
        */



    }
}
