using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Pottencial.Invoices.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services
           .AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("invoices", new OpenApiInfo { Title = "Invoices" });
                    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Pottencial.Invoices.Api.xml"), true);
                });
        }
    }
}
