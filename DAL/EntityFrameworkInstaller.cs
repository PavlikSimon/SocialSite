﻿using System;
using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFramework;
 

namespace DAL
{
    
    public class EntityFrameworkInstaller : IWindsorInstaller
    {
        
        //internal const string ConnectionString = "Data source=(localdb)\\mssqllocaldb;Database=DemoEshopDatabaseSample;Trusted_Connection=True;MultipleActiveResultSets=true";
        
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<Func<DbContext>>()
                    .Instance(() => new DatabaseContext())
                    .LifestyleTransient(),
                Component.For<IUnitOfWorkProvider>()
                    .ImplementedBy<EntityFrameworkUnitOfWorkProvider>()
                    .LifestyleTransient(),
                Component.For(typeof(IRepository<,>))
                    .ImplementedBy(typeof(EntityFrameworkRepository<,>))
                    .LifestyleTransient(),
                Component.For(typeof(QueryInfrastracture.IQuery<>))
                    .ImplementedBy(typeof(QueryInfrastructureEntityFramework.EntityFrameworkQuery<>))
                    .LifestyleTransient()
            );
        }
    }
}
