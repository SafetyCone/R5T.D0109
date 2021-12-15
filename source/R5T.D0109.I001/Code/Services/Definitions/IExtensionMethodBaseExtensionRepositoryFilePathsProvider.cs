using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0109.I001
{
    [ServiceDefinitionMarker]
    public interface IExtensionMethodBaseExtensionRepositoryFilePathsProvider : IServiceDefinition
    {
        Task<string> GetExtensionMethodBaseExtensionsListingJsonFilePath();
        Task<string> GetExtensionMethodBaseExtensionSelectionsTextFilePath();
        Task<string> GetIgnoredExtensionMethodBaseNamesTextFilePath();
        Task<string> GetDuplicateExtensionMethodBaseExtensionNamesTextFilePath();
        Task<string> GetToProjectMappingsJsonFilePath();
        Task<string> GetToExtensionMethodBaseMappingsJsonFilePath();
    }
}
