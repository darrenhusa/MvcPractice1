using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MvcPractice1.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MvcPractice1
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get;  }

        public void ConfigureServices(IServiceCollection services)
        {
            string conString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(conString));
            services.AddTransient<IItemRepository, EfItemRepository>();
            //services.AddTransient<IItemRepository, FakeItemRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Item}/{action=Index}/");
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
