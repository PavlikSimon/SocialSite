using DAL.Entities;
using DAL.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * @authors Šimon Pavlík 422465, Honza Čech 445524
 */


namespace DAL
{
    /// <summary>
    /// Database Context
    /// </summary>
    /// 
    /// public database context
    public class DatabaseContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Event> Events { get; set; }

        
    }
}
