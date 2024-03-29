using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation.DependancyInjection.Application.Abstractions;
using Presentation.DependancyInjection.Application.Abstractions.DTO;
using Presentation.DependancyInjection.Implementations;
using Presentation.DependancyInjection.Model;
using Presentation.DependancyInjection.Repository.Abstractions;
using Presentation.DependancyInjection.Repository.Implementations.Db;

namespace WebHost
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
            services.AddControllers();
            services.AddControllersWithViews();

            var config = new MapperConfiguration(x => x.CreateMap<PersonDTO, Person>().ReverseMap());
            services.AddAutoMapper(typeof(MapperProfile));

            #region Add the service for the dependancy injection
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPersonRepository, PersonDbRepository>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
