using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Headhunter.Models;
using System;

namespace Headhunter
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string con = "Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(con));
            services.AddSession();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseCors(p =>
            {
                p.AllowAnyOrigin();
                p.AllowAnyMethod();
                p.AllowAnyHeader();
            });

            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=User}/{action=Get}/{id?}");
            });
        }
    }
}
