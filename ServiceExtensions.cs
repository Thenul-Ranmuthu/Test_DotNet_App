using API.Services.Impl;
using API.Services.Interfaces;

namespace API;

public static class ServiceExtentions
{
    public static IServiceCollection AddApplicationServices(IServiceCollection services)
    {
        services.AddScoped<IProductsService, ProductsServiceImpl>();

        return services;
    }
}