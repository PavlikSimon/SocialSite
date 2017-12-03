using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BussinessLayer.DataTransferObjects.Common;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects;
using BussinessLayer.QueryObjects.Common;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using QueryInfrastracture;

namespace BussinessLayer.Services
{
        public abstract class CRUDBase<TEntity, TDto, TFilterDto> : ServiceBase, ICRUDBase<TEntity, TDto, TFilterDto>
        where TFilterDto : FilterDtoBase, new()
        where TEntity : class, IEntity<int>, new()
        where TDto : DTOBase
    {
        protected readonly IRepository<TEntity, int> Repository;

        protected readonly QueryObjectBase<TDto, TEntity, TFilterDto, QueryInfrastracture.IQuery<TEntity>> Query;

        protected CRUDBase(IMapper mapper, IRepository<TEntity, int> repository, QueryObjectBase<TDto, TEntity, TFilterDto, QueryInfrastracture.IQuery<TEntity>> query) : base(mapper)
        {
            this.Query = query;
            this.Repository = repository;
        }

        /// <summary>
        /// Gets DTO representing the entity according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <param name="withIncludes">include all entity complex types</param>
        /// <returns>The DTO representing the entity</returns>
        public virtual async Task<TDto> GetAsync(int entityId, bool withIncludes = true)
        {
            TEntity entity;
            if (withIncludes)
            {
                entity = await GetWithIncludesAsync(entityId);
            }
            else
            {
                entity = await Repository.GetByIdAsync(entityId);
            }
            return entity != null ? Mapper.Map<TDto>(entity) : null;
        }

        /// <summary>
        /// Gets entity (with complex types) according to ID
        /// </summary>
        /// <param name="entityId">entity ID</param>
        /// <returns>The DTO representing the entity</returns>
        protected abstract Task<TEntity> GetWithIncludesAsync(int entityId);

        /// <summary>
        /// Creates new entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        public virtual int Create(TDto entityDto)
        {
            var entity = Mapper.Map<TEntity>(entityDto);
            Repository.Insert(entity);
            return entity.Id;
        }

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityDto">entity details</param>
        public virtual async Task Update(TDto entityDto)
        {
            var entity = await GetWithIncludesAsync(entityDto.Id);
            Mapper.Map(entityDto, entity);
            Repository.Update(entity);
        }

        /// <summary>
        /// Deletes entity with given Id
        /// </summary>
        /// <param name="entityId">Id of the entity to delete</param>
        public virtual void Delete(int entityId)
        {
            Repository.Delete(entityId);
        }

        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        public virtual async Task<QueryResultDto<TDto, TFilterDto>> ListAllAsync()
        {
            return await Query.ExecuteQuery(new TFilterDto());
        }
    }
}