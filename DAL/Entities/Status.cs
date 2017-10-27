using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities
{
    public class Status : IEntity<int>
    {
        [Required]
        //[Key] - defaulte je primarny kluc Id alebo ClassnameID
        public int Id { get; set; }

        
        //[Required]
        public virtual AppUser CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [MaxLength(150)]
        [Required]
        public string Text { get; set; }

        [Required]
		public Boolean Private { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }

        public Status()
         {
             this.Comments = new HashSet<Comment>();
        }
    }
}
