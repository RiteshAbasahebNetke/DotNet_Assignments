using CURDUsing6._0.Models;
using CURDUsing6._0.Repositories.Classes;
using CURDUsing6._0.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(sc)
    );

builder.Services.AddScoped<IEmpRepo, EmpRepo>();
builder.Services.AddScoped<IDeptRepo, DeptRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
