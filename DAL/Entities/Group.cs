using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace DAL
{
    public class Group
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
    }
}
