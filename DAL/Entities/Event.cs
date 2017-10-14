using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Event : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual AppUser Admin { get; set; }


        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }


        [MaxLength(150)]
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public virtual ICollection<AppUser> Guests { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }

        public Event()
        {
            this.Guests = new HashSet<AppUser>();
            this.Statuses = new HashSet<Status>();
        }
    }
}
