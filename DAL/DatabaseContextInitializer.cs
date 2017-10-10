using System.Data.Entity;
using DAL.IdentityEntities;

namespace DAL
{
    public class DatabaseContextInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.AppUsers.Add(new AppUser(/*ToDo write something meaningful here*/));
            
            base.Seed(context);
        }
    }
}