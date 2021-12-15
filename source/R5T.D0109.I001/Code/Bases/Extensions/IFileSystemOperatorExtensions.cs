using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using R5T.Magyar.IO;

using R5T.T0044;
using R5T.T0102;


namespace System
{
    public static class IFileSystemOperatorExtensions
    {
        public static ExtensionMethodBaseExtension[] LoadExtensionMethodBaseExtensionsFromJsonFile(this IFileSystemOperator _,
            string jsonFilePath)
        {
            var output = JsonFileHelper.LoadFromFile<ExtensionMethodBaseExtension[]>(jsonFilePath);
            return output;
        }

        public static void WriteToJsonFile(this IFileSystemOperator _,
            string jsonFilePath,
            IEnumerable<ExtensionMethodBaseExtension> extensionMethodBaseExtensions,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            JsonFileHelper.WriteToFile(jsonFilePath, extensionMethodBaseExtensions, overwrite: overwrite);
        }

        public static ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[] LoadExtensionMethodBaseExtensionToExtensionMethodBaseMappingsFromJsonFile(this IFileSystemOperator _,
            string jsonFilePath)
        {
            var output = JsonFileHelper.LoadFromFile<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping[]>(jsonFilePath);
            return output;
        }

        public static void WriteToJsonFile(this IFileSystemOperator _,
            string jsonFilePath,
            IEnumerable<ExtensionMethodBaseExtensionToExtensionMethodBaseMapping> mappings)
        {
            JsonFileHelper.WriteToFile(jsonFilePath, mappings);
        }

        public static ExtensionMethodBaseExtensionToProjectMapping[] LoadExtensionMethodBaseExtensionToProjectMappingsFromJsonFile(this IFileSystemOperator _,
            string jsonFilePath)
        {
            var output = JsonFileHelper.LoadFromFile<ExtensionMethodBaseExtensionToProjectMapping[]>(jsonFilePath);
            return output;
        }

        public static void WriteToJsonFile(this IFileSystemOperator _,
            string jsonFilePath,
            IEnumerable<ExtensionMethodBaseExtensionToProjectMapping> mappings)
        {
            JsonFileHelper.WriteToFile(jsonFilePath, mappings);
        }
    }
}
