using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BL.DTO
{
    public class CommentDTO
    {
            [Required]
            public int Id { get; set; }
            [Required]
            public virtual AppUserDTO CreatedBy { get; set; }


            [Required]
            public DateTime CreatedOn { get; set; }
            public DateTime ModifiedOn { get; set; }

            [Required]
            [MaxLength(150)]
            public string Text { get; set; }
            [Required]
            public virtual StatusDTO StatusDTO { get; set; }



}
}
