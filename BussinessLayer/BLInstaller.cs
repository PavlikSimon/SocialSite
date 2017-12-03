using System;
using System.Data.Entity;
using AutoMapper;
using BussinessLayer.Facades.Common;
using BussinessLayer.QueryObjects.Common;
using BussinessLayer.Services;
using BussinessLayer.Services.AppUserService;
using Castle;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DAL;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.Services.Facades;
using QueryInfrastracture;

namespace BussinessLayer
{
    public class BLInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // Choose prefered DAL
            new EntityFrameworkInstaller().Install(container, store);
            
            container.Register(
                Classes.FromThisAssembly()
                    .BasedOn(typeof(QueryObjectBase<,,,>))
                    //.WithServiceBase()
                    .LifestyleTransient(),

                Classes.FromThisAssembly()
                    .BasedOn<ServiceBase>()
                    .WithServiceDefaultInterfaces()
                    .LifestyleTransient(),

                /*Classes.FromThisAssembly()
                    .BasedOn(typeof(CRUDBase<,,>))
                    .LifestyleTransient(),*/
                /*Component.For<AppUserService>()
                    .LifestyleSingleton(),

                  Classes.FromThisAssembly()
.BasedOn<AppUserService>()
.LifestyleTransient(),*/
/*
                Component.For<AppUserService>()
                    .LifestyleSingleton(),
*/


                Classes.FromThisAssembly()
                    .BasedOn<FacadeBase>()
                    .LifestyleTransient(),

                Component.For<IMapper>()
                    .Instance(new Mapper(new MapperConfiguration(MappingConfig.ConfigureMapping)))
                    .LifestyleSingleton(),

                Component.For<IUnitOfWorkRegistry>()
                    .LifestyleSingleton(),

                Component.For<IDateTimeProvider>()
                    .LifestyleSingleton(), 


            /*
            Classes.FromThisAssembly()
                .BasedOn<IUnitOfWorkRegistry>()
                .WithServiceDefaultInterfaces()
                .LifestyleTransient(),*/

            Classes.FromThisAssembly()
                .BasedOn<IDateTimeProvider>()
                .LifestyleTransient()


            

            , Component.For<IUnitOfWorkProvider>()
                .ImplementedBy<UnitOfWorkProviderBase>()
                .LifestyleSingleton()
                

            );
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel));
        }
    }
}
