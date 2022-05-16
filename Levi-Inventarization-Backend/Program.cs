using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ConfigurationContainer;
using Data;

using Services.RoomService;
using Services.Abstract;
using Services.DefectService;
using Services.InventoryService;
using Services.UserService;
using Services.SetupService;
using Data.UnitOfWork;
using Autofac;
using API.Controllers;
using Services.CommonModels;
using Autofac.Extensions.DependencyInjection;
using Levi_Inventarization_Backend;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(webBuilder =>
            {
                //webBuilder.UseSetting(WebHostDefaults.PreventHostingStartupKey, "true");
                //webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                webBuilder.UseUrls("http://localhost:3001");
                webBuilder.UseStartup<Startup>();
            });
    }
}
//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews();
//IConfiguration configuration = builder.Configuration;

//var containerBuilder = new ContainerBuilder();


//containerBuilder.RegisterModule(new MyAutofacModule());

//containerBuilder.RegisterInstance(builder.Configuration).As<IConfiguration>();//не используется в этом виде

//containerBuilder.RegisterInstance(new GetConnectionString(configuration["ConnectionStrings:DefaultConnection"]))
//    .As<IGetConnectionString>();

////containerBuilder.RegisterType<DefectController>();
////containerBuilder.RegisterType<InventoryController>();
////containerBuilder.RegisterType<RoomsController>();
////containerBuilder.RegisterType<SetupsController>();
////containerBuilder.RegisterType<UsersController>();

//containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

//containerBuilder.RegisterType<DbContextOptions<ApplicationContext>>();
//containerBuilder.RegisterType<ApplicationContext>();

//containerBuilder.RegisterType<DefectService>().As<IDefectService>();

//containerBuilder.RegisterType<InventoryService>().As<IInventoryService>();

//containerBuilder.RegisterType<RoomService>().As<IRoomService>();
//containerBuilder.RegisterType<SetupService>().As<ISetupService>();
//containerBuilder.RegisterType<UserService>().As<IUserService>();

//var container = containerBuilder.Build();

//builder.Services.AddDbContext<ApplicationContext>(opts => 
//    opts.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"],
//     b => b.MigrationsAssembly("Levi-Inventarization-Backend")
//     ));//---------------------//


//builder.Services.AddAuthorization(auth =>
//{
//    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
//        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
//        .RequireAuthenticatedUser().Build());
//});

//builder.Services.AddSingleton(new GetJwtSettings(configuration["Jwt:Key"],
//    configuration["Jwt:Issuer"],
//    configuration["Jwt:Audience"]));
//builder.Services.AddSingleton(new GetConnectionString(configuration["ConnectionStrings:DefaultConnection"]));


////builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
////builder.Services.AddTransient<ApplicationContext, ApplicationContext>();
////builder.Services.AddTransient<IDefectService, DefectService>();
////builder.Services.AddTransient<IRoomService, RoomService>();
////builder.Services.AddTransient<IInventoryService, InventoryService>();
////builder.Services.AddTransient<IUserService, UserService>();
////builder.Services.AddTransient<ISetupService, SetupService>();

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.SaveToken = true;
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            //Required else token will fail to be validated and auth will fail
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
//            ValidateLifetime = true,
//            ValidIssuer = configuration["Jwt:Issuer"],
//            ValidAudience = configuration["Jwt:Audience"],
//            ValidateIssuer = true,
//        };
//        options.RequireHttpsMetadata = false;
//    });



//var app = builder.Build();

//app.UseRouting();

//app.UseAuthorization();

//app.UseCors(x => x.AllowAnyOrigin()
//                .AllowAnyMethod()
//                .AllowAnyHeader());
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

//app.MapFallbackToFile("index.html");


//app.Run("http://localhost:3001");
