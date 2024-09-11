using Core_Repo_Test.Models;
using Core_Repo_Test.Repositories.Classes;
using Core_Repo_Test.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<FlightContext>(
    opt=>opt.UseLazyLoadingProxies().UseSqlServer(sc)
    );
builder.Services.AddScoped<IFlightRepo, FlightsRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();
var app = builder.Build();
app.MapDefaultControllerRoute();


app.Run();
