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

//Other workers
builder.Services.AddTransient<IDefectService, DefectService>();
builder.Services.AddTransient<IDefectService, DefectService>();
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


var app = builder.Build();

/*app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationContext>();*/
/*app.Services.GetService<ApplicationContext>();*/
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");
app.UseCors(x => x
                .WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader()
            );


app.Run("http://localhost:3001");
