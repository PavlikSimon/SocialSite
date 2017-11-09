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
    public class CommentQueryObject : QueryObjectBase<CommentDTO, Comment, CommentFilterDto, IQuery<Comment>>
    {
        public CommentQueryObject(IMapper mapper, IQuery<Comment> query) : base(mapper, query)
        {
        }

        protected override IQuery<Comment> ApplyWhereClause(IQuery<Comment> query, CommentFilterDto filter)
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