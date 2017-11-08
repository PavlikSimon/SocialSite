using AutoMapper;
using BL.DTO;
using BL.Filters;
using DAL.IdentityEntities;
using QueryInfrastracture;

namespace BL.QueryObjects
{
    public class AppUserQueryObject : QueryObjectBase<AppUserDTO, AppUser, AppUserFilterDto, IQuery<AppUser>>
    {
        public AppUserQueryObject(IMapper mapper, IQuery<AppUser> query) : base(mapper, query)
        {
        }

        protected override IQuery<AppUser> ApplyWhereClause(IQuery<AppUser> query, AppUserFilterDto filter)
        {
            throw new System.NotImplementedException();
        }
    }
}