using CurdRepoEx.Models;
using CurdRepoEx.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st));

builder.Services.AddScoped<IDeptRepo, DeptRepo>();
builder.Services.AddScoped<IEmpRepo, EmpRepo>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
