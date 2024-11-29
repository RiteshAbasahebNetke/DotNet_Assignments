using CurdUsingRepoEX.Models;
using CurdUsingRepoEX.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st)
    );

builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
