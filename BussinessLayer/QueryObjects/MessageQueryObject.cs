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
    public class MessageQueryObject : QueryObjectBase<MessageDTO, Message, MessageFilterDto, IQuery<Message>>
    {
        public MessageQueryObject(IMapper mapper, IQuery<Message> query) : base(mapper, query)
        {
        }

        protected override IQuery<Message> ApplyWhereClause(IQuery<Message> query, MessageFilterDto filter)
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