using Microsoft.OpenApi.Models;
using System.Reflection;
using VehicleInformationService.Api.Middleware;
using VehicleInformationService.Infrastructure.Rdw;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
configuration.AddUserSecrets(Assembly.GetExecutingAssembly());
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.AddSecurityDefinition(ApiKeyMiddleware.ApiKey, new OpenApiSecurityScheme
    {
        Name = ApiKeyMiddleware.ApiKey,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "ApiKeyScheme",
        In = ParameterLocation.Header,
        Description = "ApiKey must appear in header"
    });
    x.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = ApiKeyMiddleware.ApiKey
                },
                In = ParameterLocation.Header
            },
            new string[]{}
        }
    });
});

builder.Services.AddRdwApi(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ApiKeyMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
