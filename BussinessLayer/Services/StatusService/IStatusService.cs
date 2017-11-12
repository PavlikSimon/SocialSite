﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;

namespace BussinessLayer.Services.StatusService
{
    public interface IStatusService
    {

        //Task<IEnumerable<AppUserDTO>> ListUsersStatusesAsync(AppUserFilterDto filter);


        void PostStatusToGroup(StatusDTO status, GroupDTO group);

        void PostStatusToEvent(StatusDTO status, EventDTO event_);


        // TODO - THIS COULD BE DELETED LATER 
        // after succesfull implement. of ICRUDBase generic interface

        /// <summary>
        /// Gets DTO representing the entity according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <param name="withIncludes">include all entity complex types</param>
        /// <returns>The DTO representing the entity</returns>
        Task<StatusDTO> GetAsync(int entityId, bool withIncludes = true);

        /// <summary>
        /// Creates new entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        int Create(StatusDTO entityDto);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        Task Update(StatusDTO entityDto);

        /// <summary>
        /// Deletes entity with given Id
        /// </summary>
        /// <param name="entityId">Id of the entity to delete</param>
        void Delete(int entityId);

        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        Task<QueryResultDto<StatusDTO, StatusFilterDto>> ListAllAsync();
    }
}