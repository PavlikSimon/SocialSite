using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;
using QueryInfrastracture;

namespace BussinessLayer
{
    /*public static class Mapping
    {
        public static IMapper Mapper { get; }
        static Mapping()
        {
            var config = new MapperConfiguration(c =>
            {

                c.CreateMap<Comment, CommentDTO>().ReverseMap();
                c.CreateMap<Event, EventDTO>().ReverseMap();
                c.CreateMap<Group, GroupDTO>().ReverseMap();
                c.CreateMap<Message, MessageDTO>().ReverseMap();
                c.CreateMap<AppUser, AppUserDTO>().ReverseMap();
            });
            Mapper = config.CreateMapper();
        }
    }*/

    
    public class MappingConfig
    {
        //public static IMapper Mapper { get; }

        //static Mapping()
        public static void ConfigureMapping(IMapperConfigurationExpression c)
        {
            // var config = new MapperConfiguration(c =>
            // {

            c.CreateMap<Comment, CommentDTO>().ReverseMap();
                c.CreateMap<Event, EventDTO>().ReverseMap();
                c.CreateMap<Group, GroupDTO>().ReverseMap();
                c.CreateMap<Message, MessageDTO>().ReverseMap();
                c.CreateMap<AppUser, AppUserDTO>().ReverseMap();
                //c.CreateMap<AppUser, NewAppUserDto>().ReverseMap();

            c.CreateMap<QueryResult<Comment>, QueryResultDto<CommentDTO, CommentFilterDto>>();
            c.CreateMap<QueryResult<Event>, QueryResultDto<EventDTO, EventFilterDto>>();
            c.CreateMap<QueryResult<Group>, QueryResultDto<GroupDTO, GroupFilterDto>>();
            c.CreateMap<QueryResult<Message>, QueryResultDto<MessageDTO, MessageFilterDto>>();
            c.CreateMap<QueryResult<AppUser>, QueryResultDto<AppUserDTO, AppUserFilterDto>>();

            //});
            //Mapper = config.CreateMapper();
        }
    } 
     

}


