using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pottencial.Invoices.Repositories.Invoices.Context;
using Pottencial.Invoices.Repositories.Invoices.Repositories;

namespace Pottencial.Invoices.Api.Configuration
{
    public static class RepositoryConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services
                   .AddScoped<InvoiceRepository>()
                   .AddDbContext<InvoiceDbContext>(options => options.UseInMemoryDatabase("Invoices"));
        }
    }
}
