using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia.Extensions;


namespace R5T.Ives.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static string GetConfigurationName(this IServiceCollection services)
        {
            var intermediateServiceProvider = services.BuildIntermediateServiceProvider();

            var configurationName = intermediateServiceProvider.GetConfigurationName();
            return configurationName;
        }
    }
}
