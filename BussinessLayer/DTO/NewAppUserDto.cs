﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Enumerations;

namespace BussinessLayer.DTO
{
    public class NewAppUserDto
    {
        public string UserName { get; set; }

        //[MaxLength(50)]
        public string Name { get; set; }
        //[MaxLength(50)]
        public string Surname { get; set; }

        public Gender Gender { get; set; }
    }
}
