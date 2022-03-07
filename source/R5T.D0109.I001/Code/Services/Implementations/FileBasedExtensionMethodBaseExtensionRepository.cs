using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;
using R5T.T0102;


namespace R5T.D0109.I001
{
    [ServiceImplementationMarker]
    public partial class FileBasedExtensionMethodBaseExtensionRepository : IFileBasedExtensionMethodBaseExtensionRepository, IServiceImplementation
    {
        #region Static

        private static WasFound<ExtensionMethodBaseExtensionToProjectMapping> HasToProjectMapping(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> mappings,
            ExtensionMethodBaseExtensionToProjectMapping mapping)
        {
            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMapping(mappings,
                mapping.ExtensionMethodBaseExtensionIdentity,
                mapping.ProjectIdentity);

            return output;
        }

        private static Dictionary<ExtensionMethodBaseExtensionToProjectMapping, WasFound<ExtensionMethodBaseExtensionToProjectMapping>>
            HasToProjectMappings(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> mappings,
            IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> newMappings)
        {
            var output = Instances.Operation.GetWasFoundByValue(
                mappings,
                newMappings,
                FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMapping);

            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> HasToExtensionMethodBaseMapping(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings,
            ExtensionMethodBaseExtensionToExtensionMethodBaseMapping mapping)
        {
            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMapping(mappings,
               mapping.ExtensionMethodBaseExtensionIdentity,
               mapping.ExtensionMethodBaseIdentity);

            return output;
        }

        private static Dictionary<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping, WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>>
            HasToExtensionMethodBaseMappings(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings,
            IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> newMappings)
        {
            var output = Instances.Operation.GetWasFoundByValue(
                mappings,
                newMappings,
                FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMapping);

            return output;
        }

        private static WasFound<ExtensionMethodBaseExtension> HasExtensionMethodBaseExtension(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions,
            ExtensionMethodBaseExtension extensionMethodBaseExtension)
        {
            var output = extensionMethodBaseExtensions.FindSingleByIdentityOrThenNameAndFilePath(extensionMethodBaseExtension);
            return output;
        }

        private static Dictionary<ExtensionMethodBaseExtension, WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtensions(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions,
            IEnumerable<ExtensionMethodBaseExtension> newExtensionMethodBaseExtensions)
        {
            var output = Instances.Operation.GetWasFoundByValue<ExtensionMethodBaseExtension>(
                extensionMethodBaseExtensions,
                newExtensionMethodBaseExtensions,
                FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtension);

            return output;
        }

        private static ExtensionMethodBaseExtensionToProjectMapping[] HasToProjectMappingsByProject(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> toProjectMappings,
            Guid projectIdentity)
        {
            var output = toProjectMappings.FindArrayByExternalIdentity(projectIdentity);
            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionToProjectMapping> HasToProjectMappingByExtensionMethodBaseExtension(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> toProjectMappings,
            Guid extensionMethodBaseExtensionIdentity)
        {
            var output = toProjectMappings.FindSingleByLocalIdentity(extensionMethodBaseExtensionIdentity);
            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionToProjectMapping> HasToProjectMapping(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> mappings,
            Guid extensionMethodBaseExtensionIdentity, Guid projectIdentity)
        {
            var output = mappings.FindSingleByIdentities(extensionMethodBaseExtensionIdentity, projectIdentity);
            return output;
        }

        private static ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[] HasToExtensionMethodBaseMappingsByExtensionMethodBaseIdentity(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings,
            Guid extensionMethodBaseIdentity)
        {
            var output = mappings.FindArrayByExternalIdentity(extensionMethodBaseIdentity);
            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> HasToExtensionMethodBaseMappingByExtensionMethodBaseExtensionIdentity(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings,
            Guid extensionMethodBaseExtensionIdentity)
        {
            var output = mappings.FindSingleByLocalIdentity(extensionMethodBaseExtensionIdentity);
            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> HasToExtensionMethodBaseMapping(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings,
            Guid extensionMethodBaseExtensionIdentity, Guid extensionMethodBaseIdentity)
        {
            var output = mappings.FindSingleByIdentities(
                extensionMethodBaseExtensionIdentity,
                extensionMethodBaseIdentity);

            return output;
        }

        private static WasFound<string> HasIgnoredExtensionMethodBase(IEnumerable<string> ignoredExtensionMethodBaseNamespacedTypeNames,
            string namespacedTypeName)
        {
            var output = ignoredExtensionMethodBaseNamespacedTypeNames.FindSingleByValue(namespacedTypeName);
            return output;
        }

        private static Dictionary<string, WasFound<string>> HasIgnoredExtensionMethodBaseNamespacedTypeNames(IEnumerable<string> ignoredExtensionMethodBaseNamespacedTypeNames,
            IEnumerable<string> namespacedTypeNames)
        {
            var output = Instances.Operation.GetWasFoundByValue(
                ignoredExtensionMethodBaseNamespacedTypeNames,
                namespacedTypeNames,
                FileBasedExtensionMethodBaseExtensionRepository.HasIgnoredExtensionMethodBase);

            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionNameSelection> HasExtensionMethodBaseExtensionNameSelection(IEnumerable<ExtensionMethodBaseExtensionNameSelection> extensionMethodBaseExtensionNameSelections,
            ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection)
        {
            var output = extensionMethodBaseExtensionNameSelections.FindSingleByNameAndIdentity(extensionMethodBaseExtensionNameSelection);
            return output;
        }

        private static Dictionary<ExtensionMethodBaseExtensionNameSelection, WasFound<ExtensionMethodBaseExtensionNameSelection>>
            HasExtensionMethodBaseExtensionNameSelections(IEnumerable<ExtensionMethodBaseExtensionNameSelection> extensionMethodBaseExtensionNameSelections,
            IEnumerable<ExtensionMethodBaseExtensionNameSelection> newExtensionMethodBaseExtensionNameSelections)
        {
            var output = Instances.Operation.GetWasFoundByValue<ExtensionMethodBaseExtensionNameSelection>(
                extensionMethodBaseExtensionNameSelections,
                newExtensionMethodBaseExtensionNameSelections,
                FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtensionNameSelection);

            return output;
        }

        private static WasFound<ExtensionMethodBaseExtension> HasExtensionMethodBaseExtension(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions,
            string namespacedTypedParameterizedMethodName, string codeFilePath)
        {
            var output = extensionMethodBaseExtensions.FindSingleByNameAndFilePath(
                namespacedTypedParameterizedMethodName,
                codeFilePath);

            return output;
        }

        private static WasFound<ExtensionMethodBaseExtensionNameSelection> HasDuplicateExtensionMethodBaseExtensionSelection(IEnumerable<ExtensionMethodBaseExtensionNameSelection> duplicateExtensionMethodBaseExtensionNameSelections,
            ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection)
        {
            var output = duplicateExtensionMethodBaseExtensionNameSelections.FindSingleByNameAndIdentity(extensionMethodBaseExtensionNameSelection);
            return output;
        }

        private static WasFound<ExtensionMethodBaseExtension> HasExtensionMethodBaseExtension(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions, Guid identity)
        {
            var output = extensionMethodBaseExtensions.FindSingleByIdentity(identity);
            return output;
        }

        #endregion

        //public List<ExtensionMethodBaseExtension> ExtensionMethodBaseExtensions { get; } = new List<ExtensionMethodBaseExtension>();
        //public List<ExtensionMethodBaseExtensionNameSelection> ExtensionMethodBaseExtensionSelections { get; } = new List<ExtensionMethodBaseExtensionNameSelection>();
        //public List<string> IgnoredExtensionMethodBaseExtensions { get; } = new List<string>();
        //public List<ExtensionMethodBaseExtensionNameSelection> DuplicateExtensionMethodBaseExtensionNameSelections { get; } = new List<ExtensionMethodBaseExtensionNameSelection>();
        //public List<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> ToExtensionMethodBaseMappings { get; } = new List<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>();
        //public List<ExtensionMethodBaseExtensionToProjectMapping> ToProjectMappings { get; } = new List<ExtensionMethodBaseExtensionToProjectMapping>();

        private IExtensionMethodBaseExtensionRepositoryFilePathsProvider ExtensionMethodBaseExtensionRepositoryFilePathsProvider { get; }


        public FileBasedExtensionMethodBaseExtensionRepository(
            IExtensionMethodBaseExtensionRepositoryFilePathsProvider extensionMethodBaseExtensionRepositoryFilePathsProvider)
        {
            this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider = extensionMethodBaseExtensionRepositoryFilePathsProvider;
        }

        //private bool IsEmpty()
        //{
        //    var output = true
        //        && this.ExtensionMethodBaseExtensions.None()
        //        && this.ExtensionMethodBaseExtensionSelections.None()
        //        && this.IgnoredExtensionMethodBaseExtensions.None()
        //        && this.DuplicateExtensionMethodBaseExtensionNameSelections.None()
        //        && this.ToExtensionMethodBaseMappings.None()
        //        && this.ToProjectMappings.None()
        //        ;

        //    return output;
        //}

        //public void ClearAll()
        //{
        //    this.ExtensionMethodBaseExtensions.Clear();
        //    this.ExtensionMethodBaseExtensionSelections.Clear();
        //    this.IgnoredExtensionMethodBaseExtensions.Clear();
        //    this.DuplicateExtensionMethodBaseExtensionNameSelections.Clear();
        //    this.ToExtensionMethodBaseMappings.Clear();
        //    this.ToProjectMappings.Clear();
        //}

        ///// <summary>
        ///// If the repository is not empty, empties it.
        ///// </summary>
        //public void EnsureIsEmpty()
        //{
        //    var isEmpty = this.IsEmpty();
        //    if (!isEmpty)
        //    {
        //        this.ClearAll();
        //    }
        //}

        ///// <summary>
        ///// Throws an exception if the repository is not empty.
        ///// </summary>
        //public void VerifyIsEmpty()
        //{
        //    var isEmpty = this.IsEmpty();
        //    if (!isEmpty)
        //    {
        //        throw new Exception("Repository is not empty.");
        //    }
        //}

        #region Files Load/Save

        private async Task SaveExtensionMethodBaseExtensions(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions)
        {
            var listingJsonFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetExtensionMethodBaseExtensionsListingJsonFilePath();

            Instances.FileSystemOperator.WriteToJsonFile(
                listingJsonFilePath,
                extensionMethodBaseExtensions
                    .OrderAlphabetically(x => x.NamespacedTypedParameterizedMethodName));
        }

        private async Task<ExtensionMethodBaseExtension[]> LoadExtensionMethodBaseExtensions()
        {
            // Extension method base extensions.
            var listingJsonFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetExtensionMethodBaseExtensionsListingJsonFilePath();

            var extensionMethodBaseExtensions = Instances.FileSystemOperator.FileExists(listingJsonFilePath)
                ? Instances.FileSystemOperator.LoadExtensionMethodBaseExtensionsFromJsonFile(listingJsonFilePath)
                : Array.Empty<ExtensionMethodBaseExtension>()
                ;

            return extensionMethodBaseExtensions;
        }

        private async Task<string[]> LoadIgnoredExtenionMethodBaseNamespacedTypeNames()
        {
            var ignoredExtensionMethodBaseNamesTextFilepath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetIgnoredExtensionMethodBaseNamesTextFilePath();

            var ignoredNames = Instances.FileSystemOperator.FileExists(ignoredExtensionMethodBaseNamesTextFilepath)
                ? await Instances.IgnoredValuesOperator.LoadIgnoredValues(ignoredExtensionMethodBaseNamesTextFilepath)
                : new HashSet<string>()
                ;

            var output = ignoredNames.ToArray();
            return output;
        }

        private async Task SaveIgnoredExtenionMethodBaseNamespacedTypeNames(IEnumerable<string> ignoredExtenionMethodBaseNamespacedTypeNames)
        {
            var ignoredNamesTextFilepath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetIgnoredExtensionMethodBaseNamesTextFilePath();

            await Instances.IgnoredValuesOperator.SaveIgnoredValues(
                ignoredNamesTextFilepath,
                ignoredExtenionMethodBaseNamespacedTypeNames
                    .OrderAlphabetically());
        }

        private async Task<ExtensionMethodBaseExtensionNameSelection[]> LoadDuplicateExtensionMethodBaseExtensionNameSelections()
        {
            var duplicateNameSelectionsTextFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetDuplicateExtensionMethodBaseExtensionNamesTextFilePath();

            // File is formatted as {extension method base extension namespaced, typed, parameterized method name}| {identity}, which while inconvenient for human analysis, is required since code file path is not unique. (TODO: provide some other file export of this data.)
            var duplicateSelectionValues = Instances.FileSystemOperator.FileExists(duplicateNameSelectionsTextFilePath)
                ? await Instances.DuplicateValuesOperator.LoadDuplicateValueSelections(duplicateNameSelectionsTextFilePath)
                : new Dictionary<string, string>()
                ;

            var duplicateSelections = duplicateSelectionValues
                .Select(xPair => new ExtensionMethodBaseExtensionNameSelection
                {
                    ExtensionMethodBaseExtensionIdentity = Instances.GuidOperator.FromStringStandard(xPair.Value),
                    ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName = xPair.Key
                })
                .ToArray()
                ;

            return duplicateSelections;
        }

        private async Task SaveDuplicateExtensionMethodBaseExtensionNameSelections(IEnumerable<ExtensionMethodBaseExtensionNameSelection> duplicateExtensionMethodBaseExtensionNameSelections)
        {
            var duplicateNameSelectionsTextFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetDuplicateExtensionMethodBaseExtensionNamesTextFilePath();

            // File is formatted as {extension method base extension namespaced, typed, parameterized method name}| {identity}, which while inconvenient for human analysis, is required since code file path is not unique. (TODO: provide some other file export of this data.)
            var duplicateSelections = duplicateExtensionMethodBaseExtensionNameSelections
                .OrderAlphabetically(x => x.ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName)
                .ToDictionary(
                    x => x.ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName,
                    x => Instances.GuidOperator.ToStringStandard(x.ExtensionMethodBaseExtensionIdentity));

            await Instances.DuplicateValuesOperator.SaveDuplicateValueSelections(
                duplicateNameSelectionsTextFilePath,
                duplicateSelections);
        }

        private async Task<ExtensionMethodBaseExtensionNameSelection[]> LoadExtensionMethodBaseExtensionNameSelections()
        {
            var nameSelectionsTextFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetExtensionMethodBaseExtensionSelectionsTextFilePath();

            // File is formatted as {extension method base extension namespaced, typed, parameterized method name}| {identity}, which while inconvenient for human analysis, is required since code file path is not unique. (TODO: provide some other file export of this data.)
            var selectionValues = Instances.FileSystemOperator.FileExists(nameSelectionsTextFilePath)
                ? await Instances.DuplicateValuesOperator.LoadDuplicateValueSelections(nameSelectionsTextFilePath)
                : new Dictionary<string, string>()
                ;

            var selections = selectionValues
                .Select(xPair => new ExtensionMethodBaseExtensionNameSelection
                {
                    ExtensionMethodBaseExtensionIdentity = Instances.GuidOperator.FromStringStandard(xPair.Value),
                    ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName = xPair.Key
                })
                .ToArray()
                ;

            return selections;
        }

        private async Task SaveExtensionMethodBaseExtensionSelections(IEnumerable<ExtensionMethodBaseExtensionNameSelection> extensionMethodBaseExtensionNameSelections)
        {
            var nameSelectionsTextFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetExtensionMethodBaseExtensionSelectionsTextFilePath();

            // File is formatted as {extension method base extension namespaced, typed, parameterized method name}| {identity}, which while inconvenient for human analysis, is required since code file path is not unique. (TODO: provide some other file export of this data.)
            var selections = extensionMethodBaseExtensionNameSelections
                .OrderAlphabetically(x => x.ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName)
                .ToDictionary(
                    x => x.ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName,
                    x => Instances.GuidOperator.ToStringStandard(x.ExtensionMethodBaseExtensionIdentity));

            await Instances.DuplicateValuesOperator.SaveDuplicateValueSelections(
                nameSelectionsTextFilePath,
                selections);
        }

        private async Task<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[]> LoadToExtensionMethodBaseMappings()
        {
            var toExtensionMethodBaseMappingsJsonFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetToExtensionMethodBaseMappingsJsonFilePath();

            var toExtensionMethodBaseMappings = Instances.FileSystemOperator.FileExists(toExtensionMethodBaseMappingsJsonFilePath)
                ? Instances.FileSystemOperator.LoadExtensionMethodBaseExtensionToExtensionMethodBaseMappingsFromJsonFile(toExtensionMethodBaseMappingsJsonFilePath)
                : Array.Empty<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>()
                ;

            return toExtensionMethodBaseMappings;
        }

        private async Task SaveToExtensionMethodBaseMappings(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> toExtensionMethodBaseMappings)
        {
            var toExtensionMethodBaseMappingsJsonFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetToExtensionMethodBaseMappingsJsonFilePath();

            Instances.FileSystemOperator.WriteToJsonFile(
                toExtensionMethodBaseMappingsJsonFilePath,
                toExtensionMethodBaseMappings);
        }

        private async Task<ExtensionMethodBaseExtensionToProjectMapping[]> LoadToProjectMappings()
        {
            var toProjectMappingsJsonFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetToProjectMappingsJsonFilePath();

            var toProjectMappings = Instances.FileSystemOperator.FileExists(toProjectMappingsJsonFilePath)
                ? Instances.FileSystemOperator.LoadExtensionMethodBaseExtensionToProjectMappingsFromJsonFile(toProjectMappingsJsonFilePath)
                : Array.Empty<ExtensionMethodBaseExtensionToProjectMapping>()
                ;

            return toProjectMappings;
        }

        private async Task SaveToProjectMappings(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> toProjectMappings)
        {
            var toProjectMappingsJsonFilePath = await this.ExtensionMethodBaseExtensionRepositoryFilePathsProvider.GetToProjectMappingsJsonFilePath();

            Instances.FileSystemOperator.WriteToJsonFile(
                toProjectMappingsJsonFilePath,
                toProjectMappings);
        }

        #endregion

        public async Task AddExtensionMethodBaseExtension(ExtensionMethodBaseExtension extensionMethodBaseExtension)
        {
            extensionMethodBaseExtension.SetIdentityIfNotSet();

            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtension(extensionMethodBaseExtensions, extensionMethodBaseExtension);
            if (wasFound)
            {
                throw new Exception("Extension method base extension already exists.");
            }

            // Else, modify and save.
            var modifiedExtensionMethodBaseExtensions = extensionMethodBaseExtensions.Append(extensionMethodBaseExtension);

            await this.SaveExtensionMethodBaseExtensions(modifiedExtensionMethodBaseExtensions);
        }

        public async Task AddExtensionMethodBaseExtensions(IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions)
        {
            extensionMethodBaseExtensions.SetIdentitiesIfNotSet();

            var currentExtensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var wasFoundByExtensionMethodBaseExtension = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtensions(
                currentExtensionMethodBaseExtensions,
                extensionMethodBaseExtensions);

            var anyWereFound = wasFoundByExtensionMethodBaseExtension.AnyWereFound();
            if (anyWereFound)
            {
                throw new Exception("Some extension method base extensions already exist.");
            }

            // Else, modify and save.
            var modifiedExtensionMethodBaseExtensions = currentExtensionMethodBaseExtensions.AppendRange(extensionMethodBaseExtensions);

            await this.SaveExtensionMethodBaseExtensions(modifiedExtensionMethodBaseExtensions);
        }

        public async Task<WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtension(ExtensionMethodBaseExtension extensionMethodBaseExtension)
        {
            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtension(extensionMethodBaseExtensions, extensionMethodBaseExtension);
            return output;
        }

        public async Task<WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtension(Guid identity)
        {
            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtension(extensionMethodBaseExtensions, identity);
            return output;
        }

        public async Task<WasFound<ExtensionMethodBaseExtension>> HasExtensionMethodBaseExtension(string namespacedTypedParameterizedMethodName, string codeFilePath)
        {
            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtension(extensionMethodBaseExtensions,
                namespacedTypedParameterizedMethodName, codeFilePath);

            return output;
        }

        public async Task<ExtensionMethodBaseExtension[]> GetAllExtensionMethodBaseExtensions()
        {
            var output = await this.LoadExtensionMethodBaseExtensions();
            return output;
        }

        public async Task<string[]> GetAllDistinctExtensionMethodBaseExtensionCodeFilePaths()
        {
            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var output = extensionMethodBaseExtensions
                .Select(x => x.CodeFilePath)
                .ToArray();

            return output;
        }

        public async Task<bool> DeleteExtensionMethodBaseExtension(Guid identity)
        {
            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtension(
                extensionMethodBaseExtensions,
                identity);
            if (wasFound)
            {
                var modifiedExtensionMethodBaseExtensions = extensionMethodBaseExtensions
                    .ExceptWhere(Instances.Predicate.IdentityIs<ExtensionMethodBaseExtension>(identity))
                    ;

                await this.SaveExtensionMethodBaseExtensions(modifiedExtensionMethodBaseExtensions);
            }

            return wasFound;
        }

        public async Task<Dictionary<Guid, bool>> DeleteExtensionMethodBaseExtensions(IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var extensionMethodBaseExtensions = await this.LoadExtensionMethodBaseExtensions();

            var output = new Dictionary<Guid, bool>();

            var modifiedExtensionMethodBaseExtensions = extensionMethodBaseExtensions
                .ExceptWhere(Instances.Predicate.IdentityIs<ExtensionMethodBaseExtension>(
                    extensionMethodBaseExtensionIdentities,
                    output));

            await this.SaveExtensionMethodBaseExtensions(modifiedExtensionMethodBaseExtensions);

            return output;

        }

        public async Task AddIgnoredExtensionMethodBase(string namespacedTypeName)
        {
            var ignoredExtenionMethodBaseNamespacedTypeNames = await this.LoadIgnoredExtenionMethodBaseNamespacedTypeNames();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasIgnoredExtensionMethodBase(
                ignoredExtenionMethodBaseNamespacedTypeNames,
                namespacedTypeName);
            if (wasFound)
            {
                throw new Exception("Ignored extension method base namespaced type name already exists.");
            }

            // Else, modify and save.
            var modifiedIgnoredExtenionMethodBaseNamespacedTypeNames = ignoredExtenionMethodBaseNamespacedTypeNames.Append(
                namespacedTypeName);

            await this.SaveIgnoredExtenionMethodBaseNamespacedTypeNames(modifiedIgnoredExtenionMethodBaseNamespacedTypeNames);
        }

        public async Task AddIgnoredExtensionMethodBase(IEnumerable<string> namespacedTypeNames)
        {
            var ignoredExtenionMethodBaseNamespacedTypeNames = await this.LoadIgnoredExtenionMethodBaseNamespacedTypeNames();

            var wasFoundByName = FileBasedExtensionMethodBaseExtensionRepository.HasIgnoredExtensionMethodBaseNamespacedTypeNames(
                ignoredExtenionMethodBaseNamespacedTypeNames,
                namespacedTypeNames);

            var anyWereFound = wasFoundByName.AnyWereFound();
            if (anyWereFound)
            {
                throw new Exception("Some ignored extension method base namespaced type names already exist.");
            }

            // Else, modify and save.
            var modifiedIgnoredExtenionMethodBaseNamespacedTypeNames = ignoredExtenionMethodBaseNamespacedTypeNames.AppendRange(
                namespacedTypeNames);

            await this.SaveIgnoredExtenionMethodBaseNamespacedTypeNames(modifiedIgnoredExtenionMethodBaseNamespacedTypeNames);
        }

        public async Task<WasFound<string>> HasIgnoredExtensionMethodBase(string namespacedTypeName)
        {
            var ignoredExtenionMethodBaseNamespacedTypeNames = await this.LoadIgnoredExtenionMethodBaseNamespacedTypeNames();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasIgnoredExtensionMethodBase(ignoredExtenionMethodBaseNamespacedTypeNames,
                namespacedTypeName);

            return output;
        }

        public async Task<string[]> GetAllIgnoredExtensionMethodBaseNamespacedTypeNames()
        {
            var output = await this.LoadIgnoredExtenionMethodBaseNamespacedTypeNames();
            return output;
        }

        public async Task AddDuplicateExtensionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection)
        {
            var duplicateExtensionMethodBaseExtensionNameSelections = await this.LoadDuplicateExtensionMethodBaseExtensionNameSelections();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasDuplicateExtensionMethodBaseExtensionSelection(
                duplicateExtensionMethodBaseExtensionNameSelections,
                extensionMethodBaseExtensionNameSelection);
            if (wasFound)
            {
                throw new Exception("Duplicate extension method base extension name selection already exists.");
            }

            // Else, modify and save.
            var modifiedDuplicateExtensionMethodBaseExtensionNameSelections = duplicateExtensionMethodBaseExtensionNameSelections.Append(extensionMethodBaseExtensionNameSelection);

            await this.SaveDuplicateExtensionMethodBaseExtensionNameSelections(modifiedDuplicateExtensionMethodBaseExtensionNameSelections);
        }

        public async Task AddDuplicateExtensionMethodBaseExtensionSelections(IEnumerable<ExtensionMethodBaseExtensionNameSelection> extensionMethodBaseExtensionNameSelections)
        {
            var duplicateExtensionMethodBaseExtensionNameSelections = await this.LoadDuplicateExtensionMethodBaseExtensionNameSelections();

            var wasFoundByNameSelection = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtensionNameSelections(
                duplicateExtensionMethodBaseExtensionNameSelections,
                extensionMethodBaseExtensionNameSelections);

            var anyWereFound = wasFoundByNameSelection.AnyWereFound();
            if (anyWereFound)
            {
                throw new Exception("Some duplicate extension method base extension name selections already exist.");
            }

            // Else, modify and save.
            var modifiedDuplicateExtensionMethodBaseExtensionNameSelections = duplicateExtensionMethodBaseExtensionNameSelections.AppendRange(extensionMethodBaseExtensionNameSelections);

            await this.SaveDuplicateExtensionMethodBaseExtensionNameSelections(modifiedDuplicateExtensionMethodBaseExtensionNameSelections);
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionNameSelection>> HasDuplicateExetnsionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection)
        {
            var duplicateExtensionMethodBaseExtensionNameSelections = await this.LoadDuplicateExtensionMethodBaseExtensionNameSelections();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasDuplicateExtensionMethodBaseExtensionSelection(duplicateExtensionMethodBaseExtensionNameSelections,
                extensionMethodBaseExtensionNameSelection);

            return output;
        }

        public async Task<ExtensionMethodBaseExtensionNameSelection[]> GetAllDuplicateExtensionMethodBaseExtensionSelections()
        {
            var output = await this.LoadDuplicateExtensionMethodBaseExtensionNameSelections();
            return output;
        }

        public async Task ClearAllDuplicateExtensionMethodBaseExtensionSelections()
        {
            // Overwrite with empty.
            await this.SaveDuplicateExtensionMethodBaseExtensionNameSelections(EnumerableHelper.Empty<ExtensionMethodBaseExtensionNameSelection>());
        }

        public async Task AddExtensionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection)
        {
            var extensionMethodBaseExtensionNameSelections = await this.LoadExtensionMethodBaseExtensionNameSelections();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtensionNameSelection(
                extensionMethodBaseExtensionNameSelections,
                extensionMethodBaseExtensionNameSelection);
            if (wasFound)
            {
                throw new Exception("Extension method base extension selection already exists.");
            }

            // Else, modify and save.
            var modifiedExtensionMethodBaseExtensionNameSelections = extensionMethodBaseExtensionNameSelections.Append(extensionMethodBaseExtensionNameSelection);

            await this.SaveExtensionMethodBaseExtensionSelections(modifiedExtensionMethodBaseExtensionNameSelections);
        }

        public async Task AddExtensionMethodBaseExtensionSelections(IEnumerable<ExtensionMethodBaseExtensionNameSelection> newExtensionMethodBaseExtensionNameSelections)
        {
            var extensionMethodBaseExtensionNameSelections = await this.LoadExtensionMethodBaseExtensionNameSelections();

            var wasFoundByNameSelection = FileBasedExtensionMethodBaseExtensionRepository.HasExtensionMethodBaseExtensionNameSelections(
                extensionMethodBaseExtensionNameSelections,
                newExtensionMethodBaseExtensionNameSelections);

            var anyWereFound = wasFoundByNameSelection.AnyWereFound();
            if (anyWereFound)
            {
                throw new Exception("Some extension method base extension name selections already exist.");
            }

            // Else, modify and save.
            var modifiedExtensionMethodBaseExtensionNameSelections = extensionMethodBaseExtensionNameSelections.AppendRange(extensionMethodBaseExtensionNameSelections);

            await this.SaveExtensionMethodBaseExtensionSelections(modifiedExtensionMethodBaseExtensionNameSelections);
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionNameSelection>> HasExtensionMethodBaseExtensionSelection(ExtensionMethodBaseExtensionNameSelection extensionMethodBaseExtensionNameSelection)
        {
            var extensionMethodBaseExtensionNameSelections = await this.LoadExtensionMethodBaseExtensionNameSelections();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasDuplicateExtensionMethodBaseExtensionSelection(extensionMethodBaseExtensionNameSelections,
                extensionMethodBaseExtensionNameSelection);

            return output;
        }

        public async Task<ExtensionMethodBaseExtensionNameSelection[]> GetAllExtensionMethodBaseExtensionSelections()
        {
            var output = await this.LoadExtensionMethodBaseExtensionNameSelections();
            return output;
        }

        public async Task<bool> DeleteExtensionMethodBaseNameSelection(string extensionMethodBaseNamespacedTypedParameterizedMethodName)
        {
            var extensionMethodBaseExtensionNameSelections = await this.LoadExtensionMethodBaseExtensionNameSelections();

            var wasFound = extensionMethodBaseExtensionNameSelections.FindSingleByName(extensionMethodBaseNamespacedTypedParameterizedMethodName);
            if (wasFound)
            {
                var modifiedExtensionMethodBaseExtensionNameSelections = extensionMethodBaseExtensionNameSelections
                    .ExceptWhere(Instances.Predicate.NameIs<ExtensionMethodBaseExtensionNameSelection>(extensionMethodBaseNamespacedTypedParameterizedMethodName))
                    ;

                await this.SaveExtensionMethodBaseExtensionSelections(modifiedExtensionMethodBaseExtensionNameSelections);
            }

            return wasFound;
        }

        public async Task<Dictionary<string, bool>> DeleteExtensionMethodBaseNameSelections(IEnumerable<string> extensionMethodBaseNamespacedTypedParameterizedMethodNames)
        {
            var extensionMethodBaseExtensionNameSelections = await this.LoadExtensionMethodBaseExtensionNameSelections();

            var output = new Dictionary<string, bool>();

            var modifiedExtensionMethodBaseExtensionNameSelections = extensionMethodBaseExtensionNameSelections
                .ExceptWhere(Instances.Predicate.NameIs<ExtensionMethodBaseExtensionNameSelection>(
                    extensionMethodBaseNamespacedTypedParameterizedMethodNames,
                    output));

            await this.SaveExtensionMethodBaseExtensionSelections(modifiedExtensionMethodBaseExtensionNameSelections);

            return output;
        }

        public async Task ClearAllExtensionMethodBaseExtensionSelections()
        {
            // Overwrite with empty.
            await this.SaveExtensionMethodBaseExtensionSelections(EnumerableHelper.Empty<ExtensionMethodBaseExtensionNameSelection>());
        }

        public async Task AddToProjectMapping(ExtensionMethodBaseExtensionToProjectMapping mapping)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMapping(
                toProjectMappings,
                mapping);
            if (wasFound)
            {
                throw new Exception("To project mapping already exists.");
            }

            // Else, modify and save.
            var modifiedToProjectMappings = toProjectMappings.Append(mapping);

            await this.SaveToProjectMappings(modifiedToProjectMappings);
        }

        public async Task AddToProjectMappings(IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> newToProjectMappings)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var wasFoundByToProjectMapping = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMappings(
                toProjectMappings,
                newToProjectMappings);

            var anyWereFound = wasFoundByToProjectMapping.AnyWereFound();
            if (anyWereFound)
            {
                throw new Exception("Some to-project mappings already exist.");
            }

            // Else, modify and save.
            var modifiedToProjectMappings = toProjectMappings.AppendRange(newToProjectMappings);

            await this.SaveToProjectMappings(modifiedToProjectMappings);
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionToProjectMapping>> HasToProjectMapping(ExtensionMethodBaseExtensionToProjectMapping mapping)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMapping(toProjectMappings, mapping);
            return output;
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionToProjectMapping>> HasToProjectMappingByExtensionMethodBaseExtension(Guid extensionMethodBaseExtensionIdentity)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMappingByExtensionMethodBaseExtension(toProjectMappings,
                extensionMethodBaseExtensionIdentity);

            return output;
        }

        public async Task<Dictionary<Guid, WasFound<ExtensionMethodBaseExtensionToProjectMapping>>> HasToProjectMappingsByExtensionMethodBaseExtension(IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var output = toProjectMappings.FindDictionaryByLocalIdentity(extensionMethodBaseExtensionIdentities);
            return output;
        }

        public async Task<ExtensionMethodBaseExtensionToProjectMapping[]> HasToProjectMappingsByProject(Guid projectIdentity)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMappingsByProject(toProjectMappings, projectIdentity);
            return output;
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionToProjectMapping>> HasToProjectMapping(Guid extensionMethodBaseExtensionIdentity, Guid projectIdentity)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToProjectMapping(toProjectMappings,
                extensionMethodBaseExtensionIdentity,
                projectIdentity);

            return output;
        }

        public async Task<ExtensionMethodBaseExtensionToProjectMapping[]> GetAllToProjectMappings()
        {
            var output = await this.LoadToProjectMappings();
            return output;
        }

        public async Task<bool> DeleteToProjectMapping(Guid extensionMethodBaseExtensionIdentity)
        {
            var toProjectMappings = await this.LoadToProjectMappings();

            var wasFound = toProjectMappings.FindSingleByLocalIdentity(extensionMethodBaseExtensionIdentity);
            if (wasFound)
            {
                var modifiedToProjectMappings = toProjectMappings
                    .ExceptWhere(Instances.Predicate.LocalIdentityIs<ExtensionMethodBaseExtensionToProjectMapping>(extensionMethodBaseExtensionIdentity))
                    ;

                await this.SaveToProjectMappings(modifiedToProjectMappings);
            }

            return wasFound;
        }

        public async Task<Dictionary<Guid, bool>> DeleteToProjectMappings(IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var toExtensionMethodBaseMappings = await this.LoadToProjectMappings();

            var output = new Dictionary<Guid, bool>();

            var modifiedToExtensionMethodBaseMappings = toExtensionMethodBaseMappings
                .ExceptWhere(Instances.Predicate.LocalIdentityIs<ExtensionMethodBaseExtensionToProjectMapping>(
                    extensionMethodBaseExtensionIdentities,
                    output));

            await this.SaveToProjectMappings(modifiedToExtensionMethodBaseMappings);

            return output;
        }

        public async Task ClearAllToProjectMappings()
        {
            // Overwrite with empty.
            await this.SaveToProjectMappings(EnumerableHelper.Empty<ExtensionMethodBaseExtensionToProjectMapping>());
        }

        public async Task AddToExtensionMethodBaseMapping(ExtensionMethodBaseExtensionToExtensionMethodBaseMapping mapping)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var wasFound = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMapping(toExtensionMethodBaseMappings,
                mapping);
            if (wasFound)
            {
                throw new Exception("To extension method base mapping already exists.");
            }

            // Else, modify and save.
            var modifiedToExtensionMethodBaseMappings = toExtensionMethodBaseMappings.Append(mapping);

            await this.SaveToExtensionMethodBaseMappings(modifiedToExtensionMethodBaseMappings);
        }

        public async Task AddToExtensionMethodBaseMappings(IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var wasFoundByToExtensionMethodBaseMappings = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMappings(
                toExtensionMethodBaseMappings,
                mappings);

            var anyWereFound = wasFoundByToExtensionMethodBaseMappings.AnyWereFound();
            if (anyWereFound)
            {
                throw new Exception("Some to-extension method base mappings already exist.");
            }

            // Else, modify and save.
            var modifiedToExtensionMethodBaseMappings = toExtensionMethodBaseMappings.AppendRange(mappings);

            await this.SaveToExtensionMethodBaseMappings(modifiedToExtensionMethodBaseMappings);
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>> HasToExtensionMethodBaseMapping(ExtensionMethodBaseExtensionToExtensionMethodBaseMapping mapping)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMapping(toExtensionMethodBaseMappings, mapping);
            return output;
        }

        public async Task<Dictionary<Guid, WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>>> HasToExtensionMethodBaseMappingsByExtensionMethodBaseExtensionIdentity(
            IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var output = toExtensionMethodBaseMappings.FindDictionaryByLocalIdentity(extensionMethodBaseExtensionIdentities);
            return output;
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>> HasToExtensionMethodBaseMappingByExtensionMethodBaseExtensionIdentity(Guid extensionMethodBaseExtensionIdentity)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMappingByExtensionMethodBaseExtensionIdentity(toExtensionMethodBaseMappings,
                extensionMethodBaseExtensionIdentity);

            return output;
        }

        public async Task<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[]> HasToExtensionMethodBaseMappingsByExtensionMethodBaseIdentity(Guid extensionMethodBaseIdentity)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMappingsByExtensionMethodBaseIdentity(toExtensionMethodBaseMappings,
                extensionMethodBaseIdentity);

            return output;
        }

        public async Task<WasFound<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>> HasToExtensionMethodBaseMapping(Guid extensionMethodBaseExtensionIdentity, Guid extensionMethodBaseIdentity)
        {
            var mappings = await this.LoadToExtensionMethodBaseMappings();

            var output = FileBasedExtensionMethodBaseExtensionRepository.HasToExtensionMethodBaseMapping(mappings,
                extensionMethodBaseExtensionIdentity,
                extensionMethodBaseIdentity);

            return output;
        }

        public async Task<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[]> GetAllToExtensionMethodBaseMappings()
        {
            var output = await this.LoadToExtensionMethodBaseMappings();
            return output;
        }

        public async Task<bool> DeleteToExtensionMethodBaseMapping(Guid extensionMethodBaseExtensionIdentity)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var wasFound = toExtensionMethodBaseMappings.FindSingleByLocalIdentity(extensionMethodBaseExtensionIdentity);
            if(wasFound)
            {
                var modifiedToExtensionMethodBaseMappings = toExtensionMethodBaseMappings
                    .ExceptWhere(Instances.Predicate.LocalIdentityIs<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>(extensionMethodBaseExtensionIdentity))
                    ;

                await this.SaveToExtensionMethodBaseMappings(modifiedToExtensionMethodBaseMappings);
            }

            return wasFound;
        }

        public async Task<Dictionary<Guid, bool>> DeleteToExtensionMethodBaseMappings(IEnumerable<Guid> extensionMethodBaseExtensionIdentities)
        {
            var toExtensionMethodBaseMappings = await this.LoadToExtensionMethodBaseMappings();

            var output = new Dictionary<Guid, bool>();

            var modifiedToExtensionMethodBaseMappings = toExtensionMethodBaseMappings
                .ExceptWhere(Instances.Predicate.LocalIdentityIs<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>(
                    extensionMethodBaseExtensionIdentities,
                    output));

            await this.SaveToExtensionMethodBaseMappings(modifiedToExtensionMethodBaseMappings);

            return output;
        }

        public async Task ClearAllToExtensionMethodBaseMappings()
        {
            // Overwrite with empty.
            await this.SaveToExtensionMethodBaseMappings(EnumerableHelper.Empty<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping>());
        }

        public async Task ClearAllExtensionMethodBaseExtensions()
        {
            // Overwrite with empty.
            await this.SaveExtensionMethodBaseExtensions(EnumerableHelper.Empty<ExtensionMethodBaseExtension>());
        }
    }
}