using CurdApiEx.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(
    opt => {
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
builder.Services.AddSwaggerGen();

string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CustContext>(
    opt=>opt.UseSqlServer(st)
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
