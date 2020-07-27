using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BVMinhArichitecture.Common.Configurations;
using BVMinhArichitecture.DL.DatabaseContexts;
using BVMinhArichitecture.DL.DatabseConnectors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BVMinhArichitecture.DL.Repositories;

namespace BVMinhArichitecture.UI
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
            GetConfiguration._configuration = Configuration;

            services.AddDbContext<MariaDatabaseContext>(options =>
                options.UseMySql(GetConfiguration.GetAppSettings("MariaDB", "ConnectionString")));

            services.AddTransient<IDatabaseContext, MongoDatabaseContext> (/*typeof(IDatabaseContext), typeof(MariaDatabaseContext)*/);

            services.AddTransient(typeof(IDatabaseConnector<>), typeof(MongoDatabaseConnector<>));

            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));

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
