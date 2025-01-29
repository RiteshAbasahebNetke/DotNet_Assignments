using AssignmentCoreEx.Models;
using AssignmentCoreEx.Repositories.Classes;
using AssignmentCoreEx.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st)
    );

builder.Services.AddScoped<IProductCategoryRepo,ProductCategoryRepo>();
builder.Services.AddScoped<IColorRepo,ColorRepo>();
builder.Services.AddScoped<IMfgRepo,MfgRepo>();
builder.Services.AddScoped<IProductRepo,ProductRepo>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
