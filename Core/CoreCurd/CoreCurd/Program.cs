using CoreCurd.Models;
using CoreCurd.Repositories.Classes;
using CoreCurd.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string st=builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
    opt=>opt.UseLazyLoadingProxies().UseSqlServer(st)
    );
builder.Services.AddScoped<IBusRepo, BusRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();
var app = builder.Build();
app.MapDefaultControllerRoute();

app.Run();
