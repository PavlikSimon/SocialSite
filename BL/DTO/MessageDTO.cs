 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class MessageDTO
    {
        //[Required]
        public int Id { get; set; }
        // [Required]
        public DateTime CreatedOn { get; set; }
        //[Required]
        public AppUserDTO Sender { get; set; }
        //[Required]
        public AppUserDTO Receiver { get; set; }
    }
}
