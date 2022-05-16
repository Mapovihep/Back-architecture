using API.Controllers;
using Autofac;
using ConfigurationContainer;
using Data;
using Data.UnitOfWork;
using Data.UnitOfWork.Abstract;
using Data.UnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.DefectService;
using Services.InventoryService;
using Services.RoomService;
using Services.SetupService;
using Services.UserService;
using System.Reflection;

namespace Levi_Inventarization_Backend
{
    public class ContainerConfig
    {
        public IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<GetJwtSettings>();

            containerBuilder.RegisterType<DefectController>();
            containerBuilder.RegisterType<InventoryController>();
            containerBuilder.RegisterType<RoomsController>();
            containerBuilder.RegisterType<SetupsController>();
            containerBuilder.RegisterType<UsersController>();

            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            containerBuilder.RegisterType<DbContextOptions<ApplicationContext>>();
            containerBuilder.RegisterType<ApplicationContext>();

            containerBuilder.RegisterType<DefectService>().As<IDefectService>();
            containerBuilder.RegisterType<InventoryService>().As<IInventoryService>();
            containerBuilder.RegisterType<RoomService>().As<IRoomService>();
            containerBuilder.RegisterType<SetupService>().As<ISetupService>();
            containerBuilder.RegisterType<UserService>().As<IUserService>();

            return containerBuilder.Build();
        }
        public class ConfigurationOptions
        {
            public const string ConnectionStrings = "ConnectionStrings";
            public string DefaultConnection { get; set; } = String.Empty;
        }
        public class JwtConfiguration
        {
            public const string JwtSettings = "JwtSettings";
            public string Secret { get; set; } = String.Empty;
            public string TokenLifetime { get; set; } = String.Empty;
        }
        public class JwtOptions
        {
            public const string Jwt = "Jwt";
            public string Issuer { get; set; } = String.Empty;
            public string Audience { get; set; } = String.Empty;
            public string Key { get; set; } = String.Empty;
        }
    }
}
