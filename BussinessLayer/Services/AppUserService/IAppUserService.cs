using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DataTransferObjects.Common;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using Riganti.Utils.Infrastructure.Core;

namespace BussinessLayer.Services.AppUserService
{
    public interface IAppUserService //: ICRUDBase<TEntity, TDto, TFilterDto>

    {
        void CreateFriendship(AppUserDTO user1, AppUserDTO user2);

        void RemoveFriendship(AppUserDTO user1, AppUserDTO user2);

        Task<AppUserDTO> GetAppUserAccordingToEmailAsync(string email);


        

        // TODO - THIS COULD BE DELETED LATER 
        // after succesfull implement. of ICRUDBase generic interface

        /// <summary>
        /// Gets DTO representing the entity according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <param name="withIncludes">include all entity complex types</param>
        /// <returns>The DTO representing the entity</returns>
        Task<AppUserDTO> GetAsync(int entityId, bool withIncludes = true);

        /// <summary>
        /// Creates new entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        int Create(AppUserDTO entityDto);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        Task Update(AppUserDTO entityDto);

        /// <summary>
        /// Deletes entity with given Id
        /// </summary>
        /// <param name="entityId">Id of the entity to delete</param>
        void Delete(int entityId);

        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        Task<QueryResultDto<AppUserDTO, AppUserFilterDto>> ListAllAsync();

    }
}