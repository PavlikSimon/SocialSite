using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using DAL.Entities;
using DAL.Enumerations;

namespace DAL.IdentityEntities
{
    public class AppUserRole : IdentityUserRole<int>
    {

    }

    public class AppRole : IdentityRole<int, AppUserRole>
    {

    }

    public class AppUserClaim : IdentityUserClaim<int>
    {

    }
    public class AppUserLogin : IdentityUserLogin<int>
    {
    }
    public class AppUser : IdentityUser<int, AppUserLogin, AppUserRole, AppUserClaim>
    {
        //public int Id { get; set; } - obsahuje dedena trieda
        [Required]
        public virtual AppUser CreatedBy { get; set; }
        public virtual AppUser ModifiedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }

        public Gender Gender { get; set; }
        public Boolean hidden { get; set; }

        public virtual ICollection<AppUser> Friends { get; set; }
        public virtual ICollection<Event> Events { get; set; }

        public AppUser()
        {
            this.Friends = new HashSet<AppUser>();
            this.Events = new HashSet<Event>();
        }


    }
    
}
