using curdEX.Models;
using curdEX.Repositiories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
      opt => opt.UseLazyLoadingProxies().UseSqlServer(sc)
    );

builder.Services.AddScoped<IDeptRepo, DeptRepo>();
builder.Services.AddScoped<IEmpRepo, EmpRepo>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
