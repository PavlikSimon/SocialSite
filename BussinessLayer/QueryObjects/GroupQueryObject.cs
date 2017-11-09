using System;
using AutoMapper;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;
using QueryInfrastracture;
using QueryInfrastracture.Predicates;
using QueryInfrastracture.Predicates.Operators;

namespace BussinessLayer.QueryObjects
{
    public class GroupQueryObject : QueryObjectBase<GroupDTO, Group, GroupFilterDto, IQuery<Group>>
    {
        public GroupQueryObject(IMapper mapper, IQuery<Group> query) : base(mapper, query)
        {
        }
        
        protected override IQuery<Group> ApplyWhereClause(IQuery<Group> query, GroupFilterDto filter)
        {
            throw new NotImplementedException();
         /*
            if (string.IsNullOrWhiteSpace(filter.Email))
            {
                return query;
            }
            return query.Where(new SimplePredicate(nameof(AppUser.Email), ValueComparingOperator.Equal, filter.Email));
            */
        }
        
    }
}