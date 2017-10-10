using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.Build.Framework;

namespace DAL
{
    public class Group : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual AppUser CreatedBy { get; set; }
        public virtual AppUser ModifiedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public Boolean Private { get; set; }

        public AppUser Admin { get; set; }

        public virtual ICollection<AppUser> Members { get; set; }

        public Group()
        {
            this.Members = new HashSet<AppUser>();
        }

    }
}
