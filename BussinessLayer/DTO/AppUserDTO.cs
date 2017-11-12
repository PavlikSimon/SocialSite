 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DataTransferObjects.Common;
using DAL.Enumerations;

namespace BussinessLayer.DTO
{
    public class AppUserDTO : DTOBase
    {
        //[Required]
        //[MaxLength(20)]
        public string UserName { get; set; }

        //[MaxLength(50)]
        public string Name { get; set; }

        //[MaxLength(50)]
        public string Surname { get; set; }

        public Gender Gender { get; set; }
        public Boolean Hidden { get; set; }


        public ICollection<AppUserDTO> Friends { get; set; }
        public ICollection<EventDTO> EventsCreated { get; set; }
        public ICollection<EventDTO> EventsAttended { get; set; }
        public ICollection<GroupDTO> Groups { get; set; }
        public   ICollection<StatusDTO> Statuses { get; set; }
        public   ICollection<CommentDTO> Comments { get; set; }
        public   ICollection<MessageDTO> SentMessages { get; set; }
        public   ICollection<MessageDTO> ReceivedMessages { get; set; }


        public AppUserDTO()
        {
            this.Friends = new HashSet<AppUserDTO>();
            this.EventsCreated = new HashSet<EventDTO>();
            this.EventsAttended = new HashSet<EventDTO>();
            this.Comments = new HashSet<CommentDTO>();
            this.Statuses = new HashSet<StatusDTO>();
            this.SentMessages = new HashSet<MessageDTO>();
            this.ReceivedMessages = new HashSet<MessageDTO>();
        }
    }
}
