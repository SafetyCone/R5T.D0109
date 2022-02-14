using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;
using R5T.T0102;


namespace R5T.D0109
{
    [ServiceDefinitionMarker]
    public interface IExtensionMethodBaseExtensionRepository : IServiceDefinition
    {
        #region Extension Method Base Extensions

        Task AddExtensionMethodBaseExtension(ExtensionMethodBaseExtension extensionMethodBaseExtension);

        Task AddExtensionMethodBaseExtensions(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions);

        Task<WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtension(ExtensionMethodBaseExtension extensionMethodBaseExtension);

        /// <summary>
        /// Identity is unique.
        /// </summary>
        Task<WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtension(Guid identity);

        // (can be added later)
        ///// <summary>
        ///// Namespaced, typed, parameterized method name is not unique. (There might be multiple projects with the same namespaced type name, unfortunately.)
        ///// </summary>
        //Task<ExtensionMethodBaseExtension[]> HasExtensionMethodBaseExtensionsByNamespacedTypedParameterizedMethodName(string namespacedTypedParameterizedMethodName);

        ///// <summary>
        ///// Code file path is not unique. (There will definitely be multiple extension method base extension methods defined in a single code file.)
        ///// </summary>
        //Task<ExtensionMethodBaseExtension[]> HasExtensionMethodBaseExtensionsByCodeFilePath(string codeFilePath);

        /// <summary>
        /// The combination of namespaced, typed, parameterized method name and code file path is unique. (There cannot be two identically namespaced named types in the same compilation unit, and a file cannot be broken into multiple compilation units. Further, there cannot be two identically parameterized methods in the same type.)
        /// </summary>
        Task<WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtension(string namespacedTypedParameterizedMethodName, string codeFilePath);

        Task<ExtensionMethodBaseExtension[]> GetAllExtensionMethodBaseExtensions();
        Task<string[]> GetAllDistinctExtensionMethodBaseExtensionCodeFilePaths();

        // No update.

        Task<bool> DeleteExtensionMethodBaseExtension(Guid extensionMethodBaseExtensionIdentity);

        Task<Dictionary<Guid, bool>> DeleteExtensionMethodBaseExtensions(IEnumerable<Guid> extensionMethodBaseExtensionIdentities);

        // (can be added later)
        //Task<bool> DeleteExtensionMethodBaseExtension(string namespacedTypedParameterizedMethodName, string codeFilePath);

        Task ClearAllExtensionMethodBaseExtensions();

        #endregion

        #region Ignored Extension Method Bases (mamespaced type names)

        Task AddIgnoredExtensionMethodBase(string namespacedTypeName);

        Task AddIgnoredExtensionMethodBase(IEnumerable<string> namespacedTypeNames);

        Task<WasFound<string>> HasIgnoredExtensionMethodBase(string namespacedTypeName);

        Task<string[]> GetAllIgnoredExtensionMethodBaseNamespacedTypeNames();

        // No update.

        // (can be added later)
        //Task<bool> DeleteIgnoredExtensionMethodBaseExtension(string namespacedTypedParameterizedMethodName);

        #endregion

        #region Duplicate Extension Method Base Extensions (Namespaced, Typed, Parameterized Method Names)

        Task AddDuplicateExtensionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection);

        Task AddDuplicateExtensionMethodBaseExtensionSelections(
            IEnumerable<ExtensionMethodBaseExtensionNameSelection> extensionMethodBaseExtensionNameSelections);

        Task<WasFound<ExtensionMethodBaseExtensionNameSelection>> HasDuplicateExetnsionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection);

        // (can be added later)
        //Task<WasFound>

        Task<ExtensionMethodBaseExtensionNameSelection[]> GetAllDuplicateExtensionMethodBaseExtensionSelections();

        // No updates. (can be added later)

        // No deletions. (can be added later)

        Task ClearAllDuplicateExtensionMethodBaseExtensionSelections();

        #endregion

        #region Selected Extension Method Base Extensions

        Task AddExtensionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection);

        Task AddExtensionMethodBaseExtensionSelections(IEnumerable<ExtensionMethodBaseExtensionNameSelection> extensionMethodBaseExtensionNameSelections);

        Task<WasFound<ExtensionMethodBaseExtensionNameSelection>> HasExtensionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection);

        // (can be added later)
        ///// <summary>
        ///// Extension method base extension namespaced, typed, parameterized method name is unique in the list of extension method base name selections.
        ///// </summary>
        //Task<WasFound<ExtensionMethodBaseExtensionNameSelection>> HasExtensionMethodBaseExtensionSelection(string namespacedTypedParameterizedMethodName);

        //Task<WasFound<ExtensionMethodBaseExtensionNameSelection>> HasExtensionMethodBaseExtensionSelection(Guid extensionMethodBaseExtensionIdentity);

        Task<ExtensionMethodBaseExtensionNameSelection[]> GetAllExtensionMethodBaseExtensionSelections();

        // No updates. (can be added later)

        Task<bool> DeleteExtensionMethodBaseNameSelection(string extensionMethodBaseNamespacedTypedParameterizedMethodName);

        Task<Dictionary<string, bool>> DeleteExtensionMethodBaseNameSelections(IEnumerable<string> extensionMethodBaseNamespacedTypedParameterizedMethodNames);

        Task ClearAllExtensionMethodBaseExtensionSelections();

        #endregion

        #region To Project Mappings

        Task AddToProjectMapping(ExtensionMethodBaseExtensionToProjectMapping toProjectMapping);

        Task AddToProjectMappings(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> toProjectMappings);

        Task<WasFound<ExtensionMethodBaseExtensionToProjectMapping>> HasToProjectMapping(ExtensionMethodBaseExtensionToProjectMapping toProjectMappings);

        /// <summary>
        /// Extension method base extension identity is unique. (Assume the same extension method base extension cannot be in multiple projects, which is not technically correct. For example, multiple project files can exist in the same project directory, covering the same code file. But make the assumption.)
        /// </summary>
        Task<WasFound<ExtensionMethodBaseExtensionToProjectMapping>> HasToProjectMappingByExtensionMethodBaseExtension(Guid extensionMethodBaseExtensionIdentity);

        /// <summary>
        /// Project identity is not unique. (There can be multiple extension method bases in a single project.)
        /// </summary>
        Task<ExtensionMethodBaseExtensionToProjectMapping[]> HasToProjectMappingsByProject(Guid projectIdentity);

        /// <summary>
        /// The pair of extension method base extension identity and project identity is unique.
        /// </summary>
        Task<WasFound<ExtensionMethodBaseExtensionToProjectMapping>> HasToProjectMapping(Guid extensionMethodBaseExtensionIdentity, Guid projectIdentity);

        Task<bool> DeleteToProjectMapping(Guid extensionMethodBaseExtensionIdentity);

        Task<Dictionary<Guid, bool>> DeleteToProjectMappings(IEnumerable<Guid> extensionMethodBaseExtensionIdentities);

        Task<ExtensionMethodBaseExtensionToProjectMapping[]> GetAllToProjectMappings();

        Task ClearAllToProjectMappings();

        #endregion

        #region To Extension Method Base Mappings

        Task AddToExtensionMethodBaseMapping(ExtensionMethodBaseExtensionToExtensionMethodBaseMapping mapping);

        Task AddToExtensionMethodBaseMappings(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings);

        Task<WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>> HasToExtensionMethodBaseMapping(ExtensionMethodBaseExtensionToExtensionMethodBaseMapping mapping);

        /// <summary>
        /// Extension method base extension identity is unique.
        /// </summary>
        Task<WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>> HasToExtensionMethodBaseMappingByExtensionMethodBaseExtensionIdentity(
            Guid extensionMethodBaseExtensionIdentity);

        /// <summary>
        /// Extension method base identity is not unique. (There can, of course, be multiple extension method base extensions for an extension method base.)
        /// </summary>
        Task<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[]> HasToExtensionMethodBaseMappingsByExtensionMethodBaseIdentity(Guid extensionMethodBaseIdentity);

        /// <summary>
        /// The pair of extension method base extension identity and extension method base identity is unique.
        /// </summary>
        Task<WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>> HasToExtensionMethodBaseMapping(Guid extensionMethodBaseExtensionIdentity, Guid extensionMethodBaseIdentity);

        Task<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[]> GetAllToExtensionMethodBaseMappings();

        Task<bool> DeleteToExtensionMethodBaseMapping(Guid extensionMethodBaseExtensionIdentity);

        Task<Dictionary<Guid, bool>> DeleteToExtensionMethodBaseMappings(IEnumerable<Guid> extensionMethodBaseExtensionIdentities);

        Task ClearAllToExtensionMethodBaseMappings();

        #endregion
    }
}