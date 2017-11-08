 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DataTransferObjects.Common;
using Riganti.Utils.Infrastructure.Core;

namespace BussinessLayer.DTO
{
    public class MessageDTO : DTOBase
    {
        // [Required]
        public DateTime CreatedOn { get; set; }
        //[Required]
        public AppUserDTO Sender { get; set; }
        //[Required]
        public AppUserDTO Receiver { get; set; }

    }
}
