using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recruitment.API.Infrastructure.Repository;
using CommandQuery.AspNetCore;
using CommandQuery.DependencyInjection;
using Recruitment.Contracts.Models;

namespace Recruitment.API
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
            services
                 .AddControllers(options => options.Conventions.Add(new CommandQueryControllerModelConvention()))
                 .ConfigureApplicationPartManager(manager =>
                 {
                     manager.FeatureProviders.Add(new CommandControllerFeatureProvider(typeof(Contract).Assembly));
                   //  manager.FeatureProviders.Add(new QueryControllerFeatureProvider(typeof(ContractQuery).Assembly));


                 });
            // Add commands and queries
            services.AddCommands(typeof(ContractCommandHandler).Assembly, typeof(Contract).Assembly);
          //  services.AddQueries(typeof(ContractCommandHandler).Assembly, typeof(ContractQuery).Assembly);        
            services.AddTransient<ICultureService, CultureService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Recruiment API", Version = "v1" });
            });

            services.AddScoped<IHealthRepo, HealthRepo>();
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Recruiment API");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
