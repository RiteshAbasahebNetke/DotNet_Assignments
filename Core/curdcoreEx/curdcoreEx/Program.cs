using curdcoreEx.Models;
using curdcoreEx.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(sc)
    );

builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
