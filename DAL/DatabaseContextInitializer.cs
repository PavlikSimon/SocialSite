using System;
using System.Data.Entity;
using DAL.Enumerations;
using DAL.IdentityEntities;

/*
 * @authors Šimon Pavlík 422465, Honza Čech 445524
 */

namespace DAL
{
    public class DatabaseContextInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
       protected override void Seed(DatabaseContext context)
        {
            AppUser newUser = new AppUser
            {
                AccessFailedCount = 0,
                Gender = Gender.Male,
                Name = "Chuck",
                Surname = "Norris",
                UserName = "Admin"
            };
            context.AppUsers.Add(newUser);
            context.SaveChanges();

            AppUser simon = new AppUser
            {
                AccessFailedCount = 0,
                Gender = Gender.Male,
                Name = "Simon",
                Surname = "Pavlik",
                UserName = "CEO-Simon"
            };
            context.AppUsers.Add(simon);
            context.SaveChanges();

            AppUser honza = new AppUser
            {
                AccessFailedCount = 0,
                Gender = Gender.Male,
                Name = "Honza",
                Surname = "Cech",
                UserName = "CEO-Honza"
            };
            context.AppUsers.Add(honza);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}