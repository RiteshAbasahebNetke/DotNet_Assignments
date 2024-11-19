using DependentDropDownEX.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseSqlServer(sc));

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
