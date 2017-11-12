using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using DAL.Entities;
using DAL.Enumerations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.IdentityEntities
{
    public class AppUserRole : IdentityUserRole<int>
    {
        [Key]
        public int Id { get; set; }
    }

    public class AppRole : IdentityRole<int, AppUserRole>
    {
    }

    public class AppUserClaim : IdentityUserClaim<int>
    {

    }
    public class AppUserLogin : IdentityUserLogin<int>
    {
        [Key]
        public int Id { get; set; }
    }

    public class AppUser : IdentityUser<int, AppUserLogin, AppUserRole, AppUserClaim>, IEntity<int>
    {
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(20)]
        public override string UserName { get; set; }

        //public int Id { get; set; } - obsahuje dedena trieda
        //[Required]
        //public virtual AppUser CreatedBy { get; set; }
        /*
        public virtual AppUser ModifiedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        */

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }

        public Gender Gender { get; set; }
        public Boolean Hidden { get; set; }


        public virtual ICollection<AppUser> Friends { get; set; }
        public virtual ICollection<Event> EventsCreated { get; set; }
        public virtual ICollection<Event> EventsAttended { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public virtual ICollection<Status> Statuses { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Message> SentMessages { get; set; }
        public virtual ICollection<Message> ReceivedMessages { get; set; }


        public AppUser()
        {
            this.Friends = new HashSet<AppUser>();
            this.EventsCreated = new HashSet<Event>();
            this.EventsAttended = new HashSet<Event>();
            this.Comments = new HashSet<Comment>();
            this.Statuses = new HashSet<Status>();
            this.SentMessages = new HashSet<Message>();
            this.ReceivedMessages = new HashSet<Message>();
        }


    }
    
}
