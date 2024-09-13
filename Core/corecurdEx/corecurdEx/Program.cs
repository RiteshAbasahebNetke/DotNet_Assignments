using corecurdEx.Models;
using corecurdEx.Repositories.Classes;
using corecurdEx.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CustContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st)
    );
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IAreaRepo, AreaRepo>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.Run();
