using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DataTransferObjects.Common;

namespace BussinessLayer.DTO
{
    public class EventDTO : DTOBase
    {
        //[Required]
        public virtual AppUserDTO Admin { get; set; }


        //[Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        //[MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }


        //[MaxLength(150)]
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public ICollection<AppUserDTO> Guests { get; set; }
        public ICollection<StatusDTO> Statuses { get; set; }

        public EventDTO()
        {
            this.Guests = new HashSet<AppUserDTO>();
            this.Statuses = new HashSet<StatusDTO>();
        }
    }
}
