using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PlesnaSkola.WebAPI.Filters;
using PlesnaSkola.WebAPI.Models;
using PlesnaSkola.WebAPI.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace PlesnaSkola.WebAPI
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
#pragma warning disable CS0618 // Type or member is obsolete
            services.AddAutoMapper();
#pragma warning restore CS0618 // Type or member is obsolete

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IPravdanjaService, PravdanjaService>();
            services.AddScoped<IUplateService, UplateService>();
            services.AddScoped<IMuzikaService, MuzikaService>();
            services.AddScoped<IObavijestiService, ObavijestiService>();
            services.AddScoped<IRadioniceService, RadioniceService>();
            services.AddScoped<ITreninziService, TreninziService>();
            services.AddScoped<IRasporediService, RasporediService>();
            services.AddScoped<IGrupeService, GrupeService>();
            services.AddScoped<IKoreografijeService, KoreografijeService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "PlesnaSkola API v1", Version = "v1" });
            });

            var connection = Configuration.GetConnectionString("localDB");
            services.AddDbContext<PlesnaSkolaContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "PlesnaSkola API v1");
            });

            app.UseMvc();
        }
    }
}
