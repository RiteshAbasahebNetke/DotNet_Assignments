using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MiddlewareEx
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Run((context) =>
            //{
            //    return context.Response.WriteAsync("Welcome To Middleware..!");
            //});

            //app.Run((SampleMiddleware) =>
            //{
            //    return SampleMiddleware.Response.WriteAsync("Welcome to here");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request in First Middleware");
            //    await next();
            //    await context.Response.WriteAsync("Response in First Middleware");
            //});

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("Request in Second Middleware");
            //    await next();
            //    await Context.Response.WriteAsync("Response in Second Middleware");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request in Third Middleware");
            //    await next();
            //    await context.Response.WriteAsync("Response in Third Middleware");
            //});

            //app.Run((context) => {

            //    return context.Response.WriteAsync("Last Middleware using Run!");
            //});
        }
        public Task SampleMiddleware(HttpContext cntx)
        {
            return cntx.Response.WriteAsync("Welcome To Sample Middleware");
        }
    }
}
