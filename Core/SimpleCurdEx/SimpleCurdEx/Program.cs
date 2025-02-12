using Microsoft.EntityFrameworkCore;
using SimpleCurdEx.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string st = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(st)
    );

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
