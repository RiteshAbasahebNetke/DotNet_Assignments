using CustomAuthFilter.Models;
using CustomAuthFilter.Repositories.Classes;
using CustomAuthFilter.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
    opt => opt.UseSqlServer(sc)
    );
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseSession();
app.MapDefaultControllerRoute();
app.Run();
