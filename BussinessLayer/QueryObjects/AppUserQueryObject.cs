using AutoMapper;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using DAL.IdentityEntities;
using QueryInfrastracture;

namespace BussinessLayer.QueryObjects
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