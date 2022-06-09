using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0109.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Forwards the <see cref="IFileBasedExtensionMethodBaseExtensionRepository"/> service to <see cref="IExtensionMethodBaseExtensionRepository"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExtensionMethodBaseExtensionRepository> ForwardToIExtensionMethodBaseExtensionRepositoryAction(this IServiceAction _,
            IServiceAction<IFileBasedExtensionMethodBaseExtensionRepository> fileBasedExtensionMethodBaseExtensionRepositoryAction)
        {
            var serviceAction = _.New<IExtensionMethodBaseExtensionRepository>(services => services.ForwardToIExtensionMethodBaseExtensionRepository(
                fileBasedExtensionMethodBaseExtensionRepositoryAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="FileBasedExtensionMethodBaseExtensionRepository"/> implementation of <see cref="IFileBasedExtensionMethodBaseExtensionRepository"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IFileBasedExtensionMethodBaseExtensionRepository> AddFileBasedExtensionMethodBaseExtensionRepositoryAction(this IServiceAction _,
            IServiceAction<IExtensionMethodBaseExtensionRepositoryFilePathsProvider> extensionMethodBaseExtensionRepositoryFilePathsProviderAction)
        {
            var serviceAction = _.New<IFileBasedExtensionMethodBaseExtensionRepository>(services => services.AddFileBasedExtensionMethodBaseExtensionRepository(
                extensionMethodBaseExtensionRepositoryFilePathsProviderAction));

            return serviceAction;
        }
    }
}
