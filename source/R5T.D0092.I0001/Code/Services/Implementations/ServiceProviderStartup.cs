using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.A0002;using R5T.T0064;


namespace R5T.D0092.I0001
{[ServiceImplementationMarker]
    public class ServiceProviderStartup : IServiceProviderStartup,IServiceImplementation
    {
        public Task ConfigureConfiguration(IConfigurationBuilder configurationBuilder)
        {
            // No configuration.

            return Task.CompletedTask;
        }

        public Task ConfigureServices(IServiceCollection services)
        {
            var serviceActions = Instances.ServiceAction.AddA0002ServiceActions();

            services
                .Run(serviceActions.AppSettingsFilePathProvider)
                .Run(serviceActions.EnvironmentVariableProviderAction)
                .Run(serviceActions.StringlyTypedPathOperatorAction)
                ;

            return Task.CompletedTask;
        }
    }
}
