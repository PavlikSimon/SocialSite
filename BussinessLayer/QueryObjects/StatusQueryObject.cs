using System;
using AutoMapper;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using DAL.Entities;
using DAL.IdentityEntities;
using QueryInfrastracture;
using QueryInfrastracture.Predicates;
using QueryInfrastracture.Predicates.Operators;

namespace BussinessLayer.QueryObjects
{
    public class StatusQueryObject : QueryObjectBase<StatusDTO, Status, StatusFilterDto, IQuery<Status>>
    {
        public StatusQueryObject(IMapper mapper, IQuery<Status> query) : base(mapper, query)
        {
        }

        protected override IQuery<Status> ApplyWhereClause(IQuery<Status> query, StatusFilterDto filter)
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