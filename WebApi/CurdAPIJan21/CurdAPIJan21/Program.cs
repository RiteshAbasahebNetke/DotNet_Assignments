
using CurdAPIJan21.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddCors(
    opt =>
    {
        opt.AddDefaultPolicy(
            pol =>
            {
                pol.AllowAnyOrigin();
                pol.AllowAnyMethod();
                pol.AllowAnyHeader();
            }
            );
    }
    );

builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();
string st = builder.Configuration.GetConnectionString("scon");

builder.Services.AddDbContextPool<Context>(
    opt => opt.UseSqlServer(st)
    );

var app = builder.Build();
app.UseCors();

if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();