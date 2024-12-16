using ApiCurdEx.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //enable newtonsoft
builder.Services.AddEndpointsApiExplorer();  //api explore end point
builder.Services.AddSwaggerGen();

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


string scon = builder.Configuration.GetConnectionString("scon");

builder.Services.AddDbContextPool<Context>(
    opt => opt.UseSqlServer(scon));


var app = builder.Build();
app.UseCors();
if(!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();
