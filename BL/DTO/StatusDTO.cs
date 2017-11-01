 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class StatusDTO
    {
        //[Required]
        public int Id { get; set; }


        //[Required]
        public virtual AppUserDTO CreatedBy { get; set; }

        //[Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        //[MaxLength(150)]
        //[Required]
        public string Text { get; set; }

        //[Required]
        public Boolean Private { get; set; }


        public ICollection<CommentDTO> Comments { get; set; }

        public StatusDTO()
        {
            this.Comments = new HashSet<CommentDTO>();
        }
    }
}
