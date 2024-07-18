var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapGet("/", (context) => context.Response.WriteAsync("Your running application is under development"));
}
else if (app.Environment.IsProduction())
{
    app.MapGet("/", (context) => context.Response.WriteAsync("Your running application is in production"));
}
else if (app.Environment.IsStaging())
{
    app.MapGet("/", (context) => context.Response.WriteAsync("Your running application in staging"));
}
else if (app.Environment.IsEnvironment("UAT"))
{
    app.MapGet("/", (context) => context.Response.WriteAsync("Your running application in UAT Mode!!"));
}
app.MapDefaultControllerRoute();
app.Run();
