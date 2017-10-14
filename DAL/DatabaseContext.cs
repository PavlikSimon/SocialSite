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

        /* public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder,
string schema)
{
//modelBuilder.Entity<Status>().WillCascadeOnDelete(true);
modelBuilder.Entity<AppUser>()
.HasOptional<AppUser>(s => s.Statuses)
.WithMany()
.WillCascadeOnDelete(true);
}*/
        //OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //        .HasOptional<Standard>(s => s.Standard)
        //        .WithMany()
        //        .WillCascadeOnDelete(false);
        //}
        /* static DatabaseContext()
         {
             System.Data.Entity.Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>());
         }

         public DatabaseContext()
             : base("Name=EzapDbContext")
         {
             InitializePartial();
         }

         partial void InitializePartial();*/
    }
}
