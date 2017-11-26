using System;
using System.Data.Entity;
using AutoMapper;
using BussinessLayer.Facades.Common;
using BussinessLayer.QueryObjects.Common;
using BussinessLayer.Services;
using Castle;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DAL;
using Riganti.Utils.Infrastructure.Core;

namespace BussinessLayer
{
    public class BLInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // Choose prefered DAL
            new EntityFrameworkInstaller().Install(container, store);
            
            container.Register(
                /*
                Component.For<Func<DbContext>>()
                    .Instance(() => new DatabaseContext())
                    .LifestyleTransient(),*/

                Component.For<IUnitOfWorkProvider>()
                    .ImplementedBy<UnitOfWorkProviderBase>()
                    .LifestyleSingleton(),

                /*
                Component.For<IUnitOfWorkRegistry>()
                    .Instance(new HttpContextUnitOfWorkRegistry(new ThreadLocalUnitOfWorkRegistry()))
                    .LifestyleSingleton(),*/



                Classes.FromThisAssembly()
                    .BasedOn(typeof(QueryObjectBase<,,,>))
                    .WithServiceBase()
                    .LifestyleTransient(),

                Classes.FromThisAssembly()
                    .BasedOn<ServiceBase>()
                    .WithServiceDefaultInterfaces()
                    .LifestyleTransient(),

                Classes.FromThisAssembly()
                    .BasedOn<FacadeBase>()
                    .LifestyleTransient(),

                Component.For<IMapper>()
                    .Instance(new Mapper(new MapperConfiguration(MappingConfig.ConfigureMapping)))
                    .LifestyleSingleton()
                    /*

            Component.For(typeof(IRepository<,>))
                .ImplementedBy(typeof(EntityFrameworkRepository<,>))
                .LifestyleTransient(),

    */

            );

            // add collection subresolver in order to resolve IEnumerable in Price Calculator Resolver
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel));
        }
    }
}
