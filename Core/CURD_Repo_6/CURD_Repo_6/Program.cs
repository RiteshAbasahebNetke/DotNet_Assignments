using CURD_Repo_6.Models;
using CURD_Repo_6.Repositories.Classes;
using CURD_Repo_6.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string sc = builder.Configuration.GetConnectionString("scon");
builder.Services.AddDbContextPool<Context>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(sc)
    );
builder.Services.AddScoped<IBookRepo, BookRepo>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
