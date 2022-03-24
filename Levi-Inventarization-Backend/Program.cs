using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ConfigurationContainer;
using Data;

using Data.UnitOfWork.Abstract;
using Data.Repository;
using Services.RoomService;
using Services.Abstract;
using Services.DefectService;
using Services.InventoryService;
using Services.UserService;
using Services.SetupService;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllersWithViews();

IConfiguration configuration = builder.Configuration;

builder.Services.AddDbContext<ApplicationContext>(opts => 
    opts.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"],
     b => b.MigrationsAssembly("Levi-Inventarization-Backend")
     ));//---------------------//


builder.Services.AddAuthorization(auth =>
{
    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
        .RequireAuthenticatedUser().Build());
});

builder.Services.AddSingleton(new GetJwtSettings(configuration["Jwt:Key"],
    configuration["Jwt:Issuer"],
    configuration["Jwt:Audience"]));

builder.Services.AddSingleton(new GetConnectionString(configuration["ConnectionStrings:DefaultConnection"]));
// добавить все сервисы в сервис коллекцию
builder.Services.AddTransient<ApplicationContext, ApplicationContext>();
//defectWorkers
builder.Services.AddTransient<IDefectService, DefectService>();
builder.Services.AddTransient<IDefectRepository, DefectRepository>();
//RoomsWorkers
builder.Services.AddTransient<IRoomService, RoomService>();
builder.Services.AddTransient<IRoomRepository, RoomRepository>();

//InventoryWorkers 
builder.Services.AddTransient<IInventoryService, InventoryService>();
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();

//UsersWorkers
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

//SetupWorkers
builder.Services.AddTransient<ISetupService, SetupService>();
builder.Services.AddTransient<ISetupRepository, SetupRepository>();

//Other workers
builder.Services.AddTransient<IDefectService, DefectService>();
builder.Services.AddTransient<IDefectService, DefectService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            //Required else token will fail to be validated and auth will fail
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
            ValidateLifetime = true,
            ValidIssuer = configuration["Jwt:Issuer"],
            ValidAudience = configuration["Jwt:Audience"],
            ValidateIssuer = true,
        };
        options.RequireHttpsMetadata = false;
    });
Console.WriteLine(configuration.GetValue<string>("Jwt:Audience"));
Console.WriteLine(configuration.GetValue<string>("Jwt:Issuer"));
Console.WriteLine(configuration.GetValue<string>("Jwt:Key"));
Console.WriteLine(configuration.GetValue<string>("ConnectionStrings:DefaultConnection"));

builder.Services.AddAutoMapper(typeof(Program).Assembly);//все классы, наследующие от библиотеки

var app = builder.Build();

/*app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>();*/
/*app.Services.GetService<ApplicationContext>();*/
app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "paging",
    pattern: "{controller}/{page}x{offSet}"
    );
app.MapControllerRoute(
    name: "Search",
    pattern: "{controller}/{page}x{offSet}/s={search}"
    );
app.MapControllerRoute(
    name: "Filter",
    pattern: "{controller}/{page}x{offSet}/f={filters}-{ascend}"
    );
app.MapControllerRoute(
    name: "SearchFilter",
    pattern: "{controller}/{page}x{offSet}/s={search}/f={filters}-{ascend}"
    );
app.MapControllerRoute(
    name: "SearchCategory",
    pattern: "{controller}/{page}x{offSet}/s={search}/c={category}"
    );
app.MapControllerRoute(
    name: "FilterCategory",
    pattern: "{controller}/{page}x{offSet}/f={filters}-{ascend}/c={category}"
    );
app.MapControllerRoute(
    name: "SearchFilterCategory",
    pattern: "{controller}/{page}x{offSet}/s={search}/f={filters}-{ascend}/c={category}"
    );*/

app.MapFallbackToFile("index.html");
app.UseCors(x => x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());


app.Run("http://localhost:3001");
