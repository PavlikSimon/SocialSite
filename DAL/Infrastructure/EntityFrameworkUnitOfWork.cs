﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    /*
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        
        public DatabaseContext Context { get; }

        public DatabaseContext GetContext()
        {
            return Context;
        }

        public EntityFrameworkUnitOfWork()
        {
            Context = new DatabaseContext();
        }


        public void Dispose()
        {
            Context.Dispose();
        }

        protected async Task CommitCore()
        {
            await Context.SaveChangesAsync();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void RegisterAction(Action action)
        {
            throw new NotImplementedException();
        }
    }
    */
}
