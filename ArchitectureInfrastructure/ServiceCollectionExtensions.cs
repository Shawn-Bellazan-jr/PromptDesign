
using Architecture.Application.Services;
using Architecture.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplica5tionServices<T>(this IServiceCollection services)
        {
            services.AddSingleton<IDataService<T>, IDataService<T>>();
            services.AddTransient<BaseViewModel<T>>();

            return services;
        }
    }
}
