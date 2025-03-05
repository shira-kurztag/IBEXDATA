using IBEXDATA.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using DB;
using Common;
using Service;
using Serilog;
using Microsoft.OpenApi.Models;
using IBEXDATA.Services;
using Common.DTO;

var builder = WebApplication.CreateBuilder(args);

// הגדרת Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("logs\\log-.txt", rollingInterval: RollingInterval.Day) // לוגים לקובץ
    .CreateLogger();

// Add services to the container.                                                                                                                                                                                                                         

builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectDB, ProjectDB>();
builder.Services.AddScoped<IBankService, BankService>();
builder.Services.AddScoped<IBankDB, BankDB>();
builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<IOwnerDB, OwnerDB>();
builder.Services.AddScoped<IContractorRepository, ContractorRepository>();
builder.Services.AddScoped<IContractorService, ContractorService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<ContractorDTO, Contractor>()
        .ForMember(dest => dest.InsertDate, opt => opt.Ignore()) // במידה ויש צורך להתעלם משדה מסוים
        .ForMember(dest => dest.ContractorStatus, opt => opt.Ignore()); // במידה ויש צורך להתעלם משדה מסוים
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ChinesesActstion API",
        Description = "A simple example ASP.NET Core API to manage Chineses",
        Contact = new OpenApiContact
        {
            Name = "Your Name",
            Email = "your.email@example.com",
            Url = new Uri("https://yourwebsite.com"),
        }
    });

    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Enter 'Bearer {your_token}'"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
        {
            {
                new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Reference = new Microsoft.OpenApi.Models.OpenApiReference
                    {
                        Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] {}
            }
    });
});

//builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<dbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// הוסף את הגדרת ה-CORS כאן, לפני השימוש ב-Routing
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularClient", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

// Add authentication services
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();

//    // Enable middleware to serve generated Swagger as a JSON endpoint.
//    app.UseSwagger();

//    // Enable middleware to serve Swagger UI (HTML, JS, CSS, etc.)
//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "project API V1");
//        c.RoutePrefix = string.Empty; // Serve Swagger UI at the app's root
//    });
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// מיקום ה-CORS צריך להיות לפני Routing
app.UseCors("AllowAngularClient");  // מפעיל את המדיניות של CORS

//app.UseMiddleware<CustomMiddleware>();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication(); // Add this line to enable authentication
app.UseAuthorization();

app.MapControllers();

app.Run();