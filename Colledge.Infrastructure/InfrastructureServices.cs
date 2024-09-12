using Colledge.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Infrastructure;

public static class InfrastructureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
    {

        if (configuration["ASPNETCORE_ENVIRONMENT"] == "Production")
        {
            services.AddDbContext<ColledgeContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("MSSQL")
                )
            );
        }
        else
        {
            services.AddDbContext<ColledgeContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("PostgreSQL")
                )
            ).AddLogging(); ;
        }

        return services;
    }
}
