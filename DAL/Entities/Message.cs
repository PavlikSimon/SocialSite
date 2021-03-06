﻿using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities
{
    public class Message : IEntity<int>
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public AppUser Sender { get; set; }
        [Required]
        public AppUser Receiver { get; set; }

    }
}
