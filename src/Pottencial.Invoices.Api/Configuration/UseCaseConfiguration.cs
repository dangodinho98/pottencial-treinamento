using Microsoft.Extensions.DependencyInjection;
using Pottencial.Invoices.UseCases.Invoices.UseCases;

namespace Pottencial.Invoices.Api.Configuration
{
    public static class UseCaseConfiguration
    {
        public static void ConfigureUseCases(this IServiceCollection services)
        {
            services
            .AddScoped<CancelInvoiceUseCase>()
            .AddScoped<ChangeInvoiceUseCase>()
            .AddScoped<CreateInvoiceUseCase>()
            .AddScoped<GetInvoiceByNumberUseCase>()
            .AddScoped<GetInvoicesUseCase>()
            .AddScoped<SubmitInvoiceUseCase>();
        }
    }
}
