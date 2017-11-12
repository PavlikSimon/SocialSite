using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;

namespace BussinessLayer.Services.EventService
{
    public interface IEventService
    {

        void SubscribeToEvent(EventDTO event_ /*collision with event keyword*/, AppUserDTO subscribingUser);

        // TODO - THIS COULD BE DELETED LATER 
        // after succesfull implement. of ICRUDBase generic interface

        /// <summary>
        /// Gets DTO representing the entity according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <param name="withIncludes">include all entity complex types</param>
        /// <returns>The DTO representing the entity</returns>
        Task<EventDTO> GetAsync(int entityId, bool withIncludes = true);

        /// <summary>
        /// Creates new entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        int Create(EventDTO entityDto);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        Task Update(EventDTO entityDto);

        /// <summary>
        /// Deletes entity with given Id
        /// </summary>
        /// <param name="entityId">Id of the entity to delete</param>
        void Delete(int entityId);

        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        Task<QueryResultDto<EventDTO, EventFilterDto>> ListAllAsync();
    }
}