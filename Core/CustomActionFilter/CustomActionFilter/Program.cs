using CustomActionFilter.CusAuthFilters;
using CustomActionFilter.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(
    opt=>opt.Filters.Add(new LogFilter())
    );
string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<LogContext>(
    opt=>opt.UseSqlServer(sc)
    );

var app = builder.Build();
app.MapDefaultControllerRoute(); 

app.Run();
