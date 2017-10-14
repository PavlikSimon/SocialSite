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
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public Boolean Private { get; set; }

        [Required]
        public AppUser Admin { get; set; }

        public virtual ICollection<AppUser> Members { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }

        public Group()
        {
            this.Members = new HashSet<AppUser>();
            this.Statuses = new HashSet<Status>();
        }

    }
}
