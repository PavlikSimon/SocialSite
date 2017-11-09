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
    public class EventQueryObject : QueryObjectBase<EventDTO, Event, EventFilterDto, IQuery<Event>>
    {
        public EventQueryObject(IMapper mapper, IQuery<Event> query) : base(mapper, query)
        {
        }

        protected override IQuery<Event> ApplyWhereClause(IQuery<Event> query, EventFilterDto filter)
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