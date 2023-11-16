using GY_MiddleWare.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GY_MiddleWare
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //          CUSTOM M�DDLEWARE

            app.UseHello();

            //          USE METODU

            //app.Use(async (context, task) =>
            //{
            //    Console.WriteLine("Start Use Middleware");
            //    await task.Invoke();
            //    Console.WriteLine("Stop Use Middleware");
            //});
            //app.Run(async c =>
            //{
            //    Console.WriteLine("Start Run middleware");
            //});

            //app.Map("/weatherforecast", builder => 
            //{
            //    builder.Run(async c => await c.Response.WriteAsync("Run middleware tetiklendi"));
            //});


            //          MAPWHEN METODU

            //app.MapWhen(c => c.Request.Method == "GET", builder =>
            //{
            //    app.Use(async (context, task) =>
            //    {
            //        Console.WriteLine("Start Use Middleware");
            //        await task.Invoke();
            //        Console.WriteLine("Stop Use Middleware");
            //    });
            //});


            //          MAP METODU

            //app.Map("/home", builder =>
            //{
            //    builder.Use(async (context, task) =>
            //    {
            //        Console.WriteLine("Start Use Middleware");
            //        await task.Invoke();
            //        Console.WriteLine("Stop Use Middleware");
            //    });
            //});

            //          RUN METODU

            //app.Run(async c => { await c.Response.WriteAsync("Middleware 1"); });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();



            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
