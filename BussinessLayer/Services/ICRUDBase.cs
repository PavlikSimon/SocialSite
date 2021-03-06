﻿using System;
using System.Threading.Tasks;
using BussinessLayer.DataTransferObjects.Common;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using Riganti.Utils.Infrastructure.Core;


namespace BussinessLayer.Services
{
    public interface ICRUDBase <TEntity, TDto, TFilterDto>
        where TFilterDto : FilterDtoBase, new()
        where TEntity : class, IEntity<int>, new()
        where TDto : DTOBase
    {
 
        /// <summary>
        /// Gets DTO representing the entity according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <param name="withIncludes">include all entity complex types</param>
        /// <returns>The DTO representing the entity</returns>
        Task<TDto> GetAsync(int entityId, bool withIncludes = true);

        /// <summary>
        /// Creates new entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        int Create(TDto entityDto);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        Task Update(TDto entityDto);

        /// <summary>
        /// Deletes entity with given Id
        /// </summary>
        /// <param name="entityId">Id of the entity to delete</param>
        void Delete(int entityId);

        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        Task<QueryResultDto<TDto, TFilterDto>> ListAllAsync();
    }
}