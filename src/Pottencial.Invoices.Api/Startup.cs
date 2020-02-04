using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pottencial.Invoices.Api.Configuration;

namespace Pottencial.Invoices.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.ConfigureUseCases();
            services.ConfigureRepositories();
            services.ConfigureSwagger();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseSwagger()
               .UseSwaggerUI(c =>
               {
                   c.RoutePrefix = "api-docs";
                   c.SwaggerEndpoint($"../swagger/invoices/swagger.json", $"Invoices");
               });

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
