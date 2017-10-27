 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class AppUserDTO
    {
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(20)]
        public override string UserName { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }

        public Gender Gender { get; set; }
        public Boolean Hidden { get; set; }


        public   ICollection<AppUserDTO> Friends { get; set; }
        public   ICollection<EventDTO> EventsCreated { get; set; }
        public   ICollection<EventDTO> EventsAttended { get; set; }


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
