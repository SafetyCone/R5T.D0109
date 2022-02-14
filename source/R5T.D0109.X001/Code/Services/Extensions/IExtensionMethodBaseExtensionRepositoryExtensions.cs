using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.D0109;
using R5T.T0102;


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

        public static async Task<Guid> GetExtensionMethodBaseIdentityForExtensionMethodBaseExtension(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            Guid extensionMethodBaseExtensionIdentity)
        {
            var hasExtensionMethodBaseIdentityForExtensionMethodBaseExtension = await extensionMethodBaseExtensionRepository
                .HasExtensionMethodBaseIdentityForExtensionMethodBaseExtension(extensionMethodBaseExtensionIdentity);

            if(!hasExtensionMethodBaseIdentityForExtensionMethodBaseExtension)
            {
                throw new Exception($"No extension method base found for extension method base extension identity '{extensionMethodBaseExtensionIdentity}'.");
            }

            var output = hasExtensionMethodBaseIdentityForExtensionMethodBaseExtension.Result;
            return output;
        }

        public static async Task<Guid> GetProjectIdentityForExtensionMethodBaseExtension(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            Guid extensionMethodBaseExtensionIdentity)
        {
            var hasProjectIdentityForExtensionMethodBaseExtension = await extensionMethodBaseExtensionRepository
                .HasProjectIdentityForExtensionMethodBaseExtension(extensionMethodBaseExtensionIdentity);

            if (!hasProjectIdentityForExtensionMethodBaseExtension)
            {
                throw new Exception($"No project found for extension method base extension identity '{extensionMethodBaseExtensionIdentity}'.");
            }

            var output = hasProjectIdentityForExtensionMethodBaseExtension.Result;
            return output;
        }

        public static async Task<WasFound<Guid>> HasExtensionMethodBaseIdentityForExtensionMethodBaseExtension(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            Guid extensionMethodBaseExtensionIdentity)
        {
            var hasToExtensionMethodBaseMapping = await extensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMappingByExtensionMethodBaseExtensionIdentity(extensionMethodBaseExtensionIdentity);
            if(!hasToExtensionMethodBaseMapping)
            {
                return WasFound.NotFound<Guid>();
            }

            var output = WasFound.From(hasToExtensionMethodBaseMapping.Result.ExtensionMethodBaseIdentity);
            return output;
        }

        public static async Task<WasFound<Guid>> HasProjectIdentityForExtensionMethodBaseExtension(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            Guid extensionMethodBaseExtensionIdentity)
        {
            var hasToProjectMapping = await extensionMethodBaseExtensionRepository.HasToProjectMappingByExtensionMethodBaseExtension(extensionMethodBaseExtensionIdentity);
            if (!hasToProjectMapping)
            {
                return WasFound.NotFound<Guid>();
            }

            var output = WasFound.From(hasToProjectMapping.Result.ProjectIdentity);
            return output;
        }
    }
}