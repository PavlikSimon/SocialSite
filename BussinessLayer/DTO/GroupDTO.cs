 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class GroupDTO
    {
        //[Required]
        public int Id { get; set; }
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
