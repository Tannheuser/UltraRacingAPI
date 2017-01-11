using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using UltraRacing.Core.Models;
using UltraRacing.Web.Models.DataServices;
using UltraRacing.Web.Models.DataServices.Abstract;

namespace UltraRacing.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IRacesService, RacesService>();
            services.AddTransient<RacingSeeder>();
            services.AddEntityFrameworkSqlite().AddDbContext<RacingContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, RacingSeeder seeder)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.ApplicationServices.GetService<RacingContext>().Database.Migrate();
            seeder.Seed();
//            app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}