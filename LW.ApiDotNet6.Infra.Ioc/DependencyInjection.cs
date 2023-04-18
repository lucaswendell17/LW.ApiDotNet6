

using LW.ApiDotNet6.Application.Mappings;
using LW.ApiDotNet6.Application.Services;
using LW.ApiDotNet6.Application.Services.Interfaces;
using LW.ApiDotNet6.Domain.Repositories;
using LW.ApiDotNet6.Infra.Data.Context;
using LW.ApiDotNet6.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace LW.ApiDotNet6.Infra.Ioc;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(DomainToDtoMapping));
        services.AddScoped<IPersonService, PersonService>();
        services.AddScoped<IProductService, ProductService>();
        return services;
    }
}
