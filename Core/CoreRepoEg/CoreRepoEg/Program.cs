using CoreRepoEg.Models;
using CoreRepoEg.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
string st = builder.Configuration.GetConnectionString("scon");

builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st)
    );

builder.Services.AddScoped<IAreaRepo, AreaRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
