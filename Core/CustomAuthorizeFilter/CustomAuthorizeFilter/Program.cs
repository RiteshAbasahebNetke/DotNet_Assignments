using CustomAuthorizeFilter.Models;
using CustomAuthorizeFilter.Repositories.Classes;
using CustomAuthorizeFilter.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// for session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

builder.Services.AddControllersWithViews();
string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
    opt=>opt.UseLazyLoadingProxies().UseSqlServer(sc)
    );
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

var app = builder.Build();
// for session
app.UseSession();
app.MapDefaultControllerRoute();
app.Run();
