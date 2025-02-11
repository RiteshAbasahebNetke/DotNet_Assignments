using CoreExample.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st)
    );

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
