using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using tusdotnet;
using tusdotnet.Models;
using tusdotnet.Models.Concatenation;
using tusdotnet.Models.Configuration;
using tusdotnet.Stores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}

app.UseCors("AllowAll");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// TUS configuration
var fileServerPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

var tusOptions = new DefaultTusConfiguration
{
    Store = new TusDiskStore(fileServerPath),
    UrlPath = "/files",
    Events = new Events
    {
        OnBeforeCreateAsync = ctx =>
        {
            // Validate file extension
            var extension = Path.GetExtension(ctx.Metadata["filename"].GetString(Encoding.UTF8)).ToLowerInvariant();
            if (string.IsNullOrEmpty(extension) || (extension != ".zip" && extension != ".rar"))
            {
                ctx.FailRequest("סוג הקובץ אינו נתמך. ניתן להעלות רק קבצי ZIP או RAR");
                return Task.CompletedTask;
            }

            // Validate file size
            if (ctx.FileConcatenation is FileConcatPartial && ctx.UploadLength == null)
            {
                ctx.FailRequest("Upload length is required.");
            }

            return Task.CompletedTask;
        },
        OnFileCompleteAsync = ctx =>
        {
            // File upload complete
            return Task.CompletedTask;
        }
    }
};

app.UseTus(httpContext => Task.FromResult(tusOptions));

app.Run();