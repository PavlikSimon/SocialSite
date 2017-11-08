 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DataTransferObjects.Common;

namespace BussinessLayer.DTO
{
    public class GroupDTO : DTOBase
    {
        //[Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        //[Required]
        public string Name { get; set; }
        public string Description { get; set; }

        //[Required]
        public Boolean Private { get; set; }

        //[Required]
        public AppUserDTO Admin { get; set; }

        public   ICollection<AppUserDTO> Members { get; set; }
        public   ICollection<StatusDTO> Statuses { get; set; }

        public GroupDTO()
        {
            this.Members = new HashSet<AppUserDTO>();
            this.Statuses = new HashSet<StatusDTO>();
        }
    }
}
