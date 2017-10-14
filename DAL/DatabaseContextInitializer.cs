﻿using System;
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
            base.Seed(context);
        }
    }
}