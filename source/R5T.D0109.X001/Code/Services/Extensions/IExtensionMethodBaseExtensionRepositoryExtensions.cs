using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0102;

using R5T.D0109;


namespace System
{
    public static class IExtensionMethodBaseExtensionRepositoryExtensions
    {
        public static async Task<Dictionary<Guid, bool>> DeleteToProjectMappings(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> mappings)
        {
            var embExtensionIdentities = mappings.Select(xMapping => xMapping.ExtensionMethodBaseExtensionIdentity);

            var output = await extensionMethodBaseExtensionRepository.DeleteToProjectMappings(embExtensionIdentities);
            return output;
        }

        public static async Task<Dictionary<Guid, bool>> DeleteToExtensionMethodBaseMappings(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings)
        {
            var embExtensionIdentities = mappings.Select(xMapping => xMapping.ExtensionMethodBaseExtensionIdentity);

            var output = await extensionMethodBaseExtensionRepository.DeleteToExtensionMethodBaseMappings(embExtensionIdentities);
            return output;
        }

        public static async Task<Dictionary<Guid, bool>> DeleteExtensionMethodBaseExtensions(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions)
        {
            extensionMethodBaseExtensions.VerifyAllIdentitiesAreSet();

            var embExtensionIdentities = extensionMethodBaseExtensions.Select(xEmbExtension => xEmbExtension.Identity);

            var output = await extensionMethodBaseExtensionRepository.DeleteExtensionMethodBaseExtensions(embExtensionIdentities);
            return output;
        }
    }
}