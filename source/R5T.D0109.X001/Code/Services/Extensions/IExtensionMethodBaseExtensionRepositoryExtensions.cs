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

        public static async Task<Dictionary<Guid, Guid>> GetProjectIdentitiesForExtensionMethodBaseExtensions(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var hasProjectIdentityForExtensionMethodBaseExtension = await extensionMethodBaseExtensionRepository
                .HasProjectIdentitiesForExtensionMethodBaseExtensions(extensionMethodBaseExtensionIdentities);

            if (hasProjectIdentityForExtensionMethodBaseExtension.AnyNotFound())
            {
                throw new Exception("No project found for some extension method base extension identities.");
            }

            var output = hasProjectIdentityForExtensionMethodBaseExtension
                .ToDictionary(
                    x => x.Key,
                    x => x.Value.Result);

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

        public static async Task<Dictionary<Guid, WasFound<Guid>>> HasExtensionMethodBaseIdentitiesForExtensionMethodBaseExtensions(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var hasToExtensionMethodBaseMappings = await extensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMappingsByExtensionMethodBaseExtensionIdentity(extensionMethodBaseExtensionIdentities);

            var output = hasToExtensionMethodBaseMappings.ToDictionary(
                xPair => xPair.Key,
                xPair => WasFound.From(
                    xPair.Value.Exists,
                    xPair.Value.Result.ExtensionMethodBaseIdentity));

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

        public static async Task<Dictionary<Guid, WasFound<Guid>>> HasProjectIdentitiesForExtensionMethodBaseExtensions(this IExtensionMethodBaseExtensionRepository extensionMethodBaseExtensionRepository,
            IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var hasToProjectMappingsByExtensionMethodBaseExtensions = await extensionMethodBaseExtensionRepository.HasToProjectMappingsByExtensionMethodBaseExtension(extensionMethodBaseExtensionIdentities);

            var output = hasToProjectMappingsByExtensionMethodBaseExtensions
                .ToDictionary(
                    x => x.Key,
                    x => WasFound.From(
                        x.Value.Exists,
                        x.Value.Result.ProjectIdentity));

            return output;
        }
    }
}