using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        

        //services.AddLogging();
        //services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        // Add MediatR services and register services from the current assembly


        // Behaviors mediatr request pipeline
        //services.AddTransient(typeof(IPipelineBehavior<,>),
        //    typeof(PerformanceBehavior<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>),
        //    typeof(ValidationBehavior<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>),
        //    typeof(UnhandledExceptionBehavior<,>));


        //services.Configure<MailSettings>(config.GetSection("MailSettings"));
        //services.AddTransient<IDateTime, DateTimeService>();
        //services.AddTransient<IEmailService, EmailService>();
        //services.AddTransient<ICsvFileBuilder, CsvFileBuilderService>();

        // Redis

        //services.AddStackExchangeRedisCache(options =>
        //{
        //    options.Configuration = configuration.GetConnectionString("RedisConnection");
        //    var assemblyName = Assembly.GetExecutingAssembly().GetName();
        //    options.InstanceName = assemblyName.Name;
        //});


        return services;
    }
}
