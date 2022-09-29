using Autofac;
using NLayer.BLL.Mapping;
using NLayer.BLL.Service;
using NLayer.Core.Repositories;
using NLayer.Core.Service;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository;
using NLayer.Repository.Repositories;
using NLayer.Repository.UnitOfWORKS;
using System.Reflection;
using Module = Autofac.Module;
namespace NLayer.API.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            Assembly apiAssembly = Assembly.GetExecutingAssembly();
            Assembly repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            Assembly serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));
             
            builder.RegisterAssemblyTypes(apiAssembly,repoAssembly,serviceAssembly).Where(x=> x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


            //InstancePerLifetimesScope => Scope
            //InstancePerDependency => transient


        }
    }
}
