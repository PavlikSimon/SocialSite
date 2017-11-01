using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.DTO;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;

namespace BL
{
    public static class Mapping
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
    }
}
