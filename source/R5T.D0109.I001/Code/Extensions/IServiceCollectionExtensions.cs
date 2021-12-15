using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0109.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Forwards the <see cref="IFileBasedExtensionMethodBaseExtensionRepository"/> service to <see cref="IExtensionMethodBaseExtensionRepository"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection ForwardToIExtensionMethodBaseExtensionRepository(this IServiceCollection services,
            IServiceAction<IFileBasedExtensionMethodBaseExtensionRepository> fileBasedExtensionMethodBaseExtensionRepositoryAction)
        {
            services
                .Run(fileBasedExtensionMethodBaseExtensionRepositoryAction)
                .AddSingleton<IExtensionMethodBaseExtensionRepository>(sp => sp.GetRequiredService<IFileBasedExtensionMethodBaseExtensionRepository>());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="FileBasedExtensionMethodBaseExtensionRepository"/> implementation of <see cref="IFileBasedExtensionMethodBaseExtensionRepository"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddFileBasedExtensionMethodBaseExtensionRepository(this IServiceCollection services,
            IServiceAction<IExtensionMethodBaseExtensionRepositoryFilePathsProvider> extensionMethodBaseExtensionRepositoryFilePathsProviderAction)
        {
            services
                .Run(extensionMethodBaseExtensionRepositoryFilePathsProviderAction)
                .AddSingleton<IFileBasedExtensionMethodBaseExtensionRepository, FileBasedExtensionMethodBaseExtensionRepository>();

            return services;
        }
    }
}