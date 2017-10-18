using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities
{
    public class Comment : IEntity<int>
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual AppUser CreatedBy { get; set; }


        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [Required]
        [MaxLength(150)]
        public string Text { get; set; }
        [Required]
        public virtual Status Status { get; set; }


    }
}
