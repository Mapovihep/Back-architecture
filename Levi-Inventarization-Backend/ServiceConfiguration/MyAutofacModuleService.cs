using Autofac;
using Data;
using Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.DefectService;
using Services.InventoryService;
using Services.RoomService;
using Services.SetupService;
using Services.UserService;

namespace Levi_Inventarization_Backend.ServiceConfiguration
{
    public class MyAutofacModuleService : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            //containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            //containerBuilder.RegisterType<DbContextOptions<ApplicationContext>>();
            //containerBuilder.RegisterType<ApplicationContext>();

            containerBuilder.RegisterType<DefectService>().As<IDefectService>();

            containerBuilder.RegisterType<InventoryService>().As<IInventoryService>();

            containerBuilder.RegisterType<RoomService>().As<IRoomService>();
            containerBuilder.RegisterType<SetupService>().As<ISetupService>();
            containerBuilder.RegisterType<UserService>().As<IUserService>();

           
        }
    }
}
