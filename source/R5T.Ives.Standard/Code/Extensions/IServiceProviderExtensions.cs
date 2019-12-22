using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.Ives.Standard
{
    public static class IServiceProviderExtensions
    {
        public static string GetConfigurationName(this IServiceProvider serviceProvider)
        {
            var configurationNameProvider = serviceProvider.GetRequiredService<IConfigurationNameProvider>();

            var configurationName = configurationNameProvider.GetConfigurationName();
            return configurationName;
        }
    }
}
