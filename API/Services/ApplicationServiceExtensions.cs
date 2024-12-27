using Application.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Services;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddEndpointsApiExplorer();
        services.AddDbContext<DataContext>(opt => 
        {
            opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        });
        services.AddAutoMapper(typeof(MappingProfiles).Assembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(MappingProfiles).Assembly));
        return services;
    }
}