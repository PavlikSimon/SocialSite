using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;

namespace BussinessLayer.Services.GroupService
{
    public interface IGroupService
    {
        /// <summary>
        /// Adds user to group (called by "user himself", so it has to be checked if the group is not private)
        /// </summary>
        /// <param name="user"></param>
        /// <param name="group"></param>
        /// <returns>true if user was added, false otherwise (group was private)</returns>
        bool EnterGroup(AppUserDTO user, GroupDTO group);

        /// <summary>
        /// Method for admins for adding people to private groups
        /// </summary>
        /// <param name="user"></param>
        /// <param name="group"></param>
        void AddUserToGroup(AppUserDTO user, GroupDTO group);


        // TODO - THIS COULD BE DELETED LATER 

        // after succesfull implement. of ICRUDBase generic interface

        /// <summary>
        /// Gets DTO representing the entity according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <param name="withIncludes">include all entity complex types</param>
        /// <returns>The DTO representing the entity</returns>
        Task<GroupDTO> GetAsync(int entityId, bool withIncludes = true);

        /// <summary>
        /// Creates new entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        int Create(GroupDTO entityDto);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        Task Update(GroupDTO entityDto);

        /// <summary>
        /// Deletes entity with given Id
        /// </summary>
        /// <param name="entityId">Id of the entity to delete</param>
        void DeleteProduct(int entityId);

        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        Task<QueryResultDto<GroupDTO, GroupFilterDto>> ListAllAsync();
    }
}