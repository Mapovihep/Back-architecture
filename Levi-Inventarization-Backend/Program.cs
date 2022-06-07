using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ConfigurationContainer;
using Data;

using Data.UnitOfWork.Abstract;
using Services.RoomService;
using Services.Abstract;
using Services.DefectService;
using Services.InventoryService;
using Services.UserService;
using Services.SetupService;
using Data.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);
//Swagger
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Swagger
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
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ApplicationContext, ApplicationContext>();
builder.Services.AddTransient<IDefectService, DefectService>();
builder.Services.AddTransient<IRoomService, RoomService>();
builder.Services.AddTransient<IInventoryService, InventoryService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ISetupService, SetupService>();
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

builder.Services.AddAutoMapper(typeof(Program).Assembly);//все классы, наследующие от библиотеки
//builder.Services.AddControllers().AddNewtonsoftJson()
var app = builder.Build();
app.UseRouting();

app.UseCors(x => x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.MapFallbackToFile("index.html");
//Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
//Swagger
app.Run("http://localhost:3001");
