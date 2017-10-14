using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using DAL.Enumerations;
using DAL.IdentityEntities;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Always deletes old db before creating new one
            //Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseAlways<DatabaseContext>());

            Database.SetInitializer<DatabaseContext>(new DatabaseContextInitializer());

            using (var db = new DatabaseContext())
            {
                // UserName should be unique so this is just a helper.
                var RandomNumber = new Random().Next(99999999);

                AppUser newUser = new AppUser
                {
                    //Id = 0,
                    AccessFailedCount = 0,
                    //CreatedOn = DateTime.Today,
                    Gender = Gender.Male,
                    Name = "Name",
                    Surname = "Surname",
                    UserName = "User" + RandomNumber
                };

                //newUser.CreatedBy = newUser;
                db.AppUsers.Add(newUser);
                db.SaveChanges();

                Status newStatus = new Status()
                {
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Private = true,
                    Text = "You should give us 8 points for this!",
                    CreatedBy = newUser,
                };

                db.Statuses.Add(newStatus);
                db.SaveChanges();


                var user = db.AppUsers.Find(newUser.Id);
                Console.WriteLine($"Name: {user.UserName} \n {user.Statuses.First().Text}");
                Console.ReadLine();
            }
        }
    }
}
