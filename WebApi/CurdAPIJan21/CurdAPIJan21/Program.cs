
using CurdAPIJan21.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

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

builder.Services.AddEndpointsApiExplorer();
string st = builder.Configuration.GetConnectionString("scon");

builder.Services.AddDbContextPool<Context>(
    opt => opt.UseSqlServer(st)
    );

var app = builder.Build();
app.UseCors();
app.MapControllers();
app.Run();