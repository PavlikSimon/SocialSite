using AutoMapper;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using DAL.IdentityEntities;
using QueryInfrastracture;
using QueryInfrastracture.Predicates;
using QueryInfrastracture.Predicates.Operators;

namespace BussinessLayer.QueryObjects
{
    public class AppUserQueryObject : QueryObjectBase<AppUserDTO, AppUser, AppUserFilterDto, IQuery<AppUser>>
    {
        public AppUserQueryObject(IMapper mapper, IQuery<AppUser> query) : base(mapper, query)
        {
        }

        protected override IQuery<AppUser> ApplyWhereClause(IQuery<AppUser> query, AppUserFilterDto filter)
        {
            if (string.IsNullOrWhiteSpace(filter.Email))
            {
                return query;
            }
            return query.Where(new SimplePredicate(nameof(AppUser.Email), ValueComparingOperator.Equal, filter.Email));

        }
    }
}