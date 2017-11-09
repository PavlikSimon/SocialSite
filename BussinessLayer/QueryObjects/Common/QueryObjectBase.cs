using System.Threading.Tasks;
using AutoMapper;
using BussinessLayer.Filters;
using Riganti.Utils.Infrastructure.Core;

namespace BussinessLayer.QueryObjects.Common
{
    public abstract class QueryObjectBase<TDto, TEntity, TFilter, TQuery>
        where TFilter : FilterDtoBase
        where TQuery : QueryInfrastracture.IQuery<TEntity>
        where TEntity : class, IEntity<int>, new()
    {
        private readonly IMapper mapper;

        protected readonly QueryInfrastracture.IQuery<TEntity> Query;

        protected QueryObjectBase(IMapper mapper, TQuery query)
        {
            this.mapper = mapper;
            this.Query = query;
        }

        protected abstract QueryInfrastracture.IQuery<TEntity> ApplyWhereClause(QueryInfrastracture.IQuery<TEntity> query, TFilter filter);

        public virtual async Task<QueryResultDto<TDto, TFilter>> ExecuteQuery(TFilter filter)
        {
            var query = ApplyWhereClause(Query, filter);
            if (!string.IsNullOrWhiteSpace(filter.SortCriteria))
            {
                query = query.SortBy(filter.SortCriteria, filter.SortAscending);
            }
            if (filter.RequestedPageNumber.HasValue)
            {
                query = query.Page(filter.RequestedPageNumber.Value, filter.PageSize);
            }
            var queryResult = await query.ExecuteAsync();

            var queryResultDto = mapper.Map<QueryResultDto<TDto, TFilter>>(queryResult);
            queryResultDto.Filter = filter;
            return queryResultDto;
        }
    }
}