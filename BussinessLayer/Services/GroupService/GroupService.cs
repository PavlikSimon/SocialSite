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
using DAL.IdentityEntities;

namespace BussinessLayer.Services.GroupService
{
    public class GroupService : CRUDBase<Group, GroupDTO, GroupFilterDto>, IGroupService
    {
        public GroupService(IMapper mapper, IRepository<Group, int> groupRepository, GroupQueryObject groupQueryObject, IRepository<AppUser, int> userRepository)
            : base(mapper, groupRepository, groupQueryObject)
        {
            _userRepository = userRepository;
        }

        private readonly IRepository<AppUser, int> _userRepository;
        protected override async Task<Group> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetByIdAsync(entityId);
        }


        public bool EnterGroup(AppUserDTO user, GroupDTO group)
        {
            if (group.Private)
            {
                return false;
            }
            AppUser repUser = Mapper.Map<AppUser>(user);
            Group repGroup = Mapper.Map<Group>(group);
            repUser.Groups.Add(repGroup);
            repGroup.Members.Add(repUser);
            _userRepository.Update(repUser);
            Repository.Update(repGroup);
            return true;
        }

        public void AddUserToGroup(AppUserDTO user, GroupDTO group)
        {
            AppUser repUser = Mapper.Map<AppUser>(user);
            Group repGroup = Mapper.Map<Group>(group);
            repUser.Groups.Add(repGroup);
            repGroup.Members.Add(repUser);
            _userRepository.Update(repUser);
            Repository.Update(repGroup);

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
