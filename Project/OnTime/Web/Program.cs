using Entity;
using Entity.Repositories.Classes;
using Entity.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();


string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt=>opt.UseLazyLoadingProxies().UseSqlServer(st)
    );

builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<IStateRepo, StateRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();

var app = builder.Build();
app.UseSession();
app.UseStaticFiles();

app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
         );
app.MapDefaultControllerRoute();
app.Run();
