using Microsoft.EntityFrameworkCore;
using ViewCompEx.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string str = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<VContext>(
    opt=>opt.UseSqlServer(str)
    );
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
