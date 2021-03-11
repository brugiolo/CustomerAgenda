using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Services;
using CustomerAgenda.Data.Context;
using CustomerAgenda.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerAgenda.Api.Configurations
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<CustomerAgendaContext>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IPhoneContactRepository, PhoneContactRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IPhoneContactService, PhoneContactService>();

            services.AddSwaggerGen();

            return services;
        }
    }
}
