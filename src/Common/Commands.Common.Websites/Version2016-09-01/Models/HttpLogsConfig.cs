// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Http logs configuration.
    /// </summary>
    public partial class HttpLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the HttpLogsConfig class.
        /// </summary>
        public HttpLogsConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpLogsConfig class.
        /// </summary>
        /// <param name="fileSystem">Http logs to file system
        /// configuration.</param>
        /// <param name="azureBlobStorage">Http logs to azure blob storage
        /// configuration.</param>
        public HttpLogsConfig(FileSystemHttpLogsConfig fileSystem = default(FileSystemHttpLogsConfig), AzureBlobStorageHttpLogsConfig azureBlobStorage = default(AzureBlobStorageHttpLogsConfig))
        {
            FileSystem = fileSystem;
            AzureBlobStorage = azureBlobStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets http logs to file system configuration.
        /// </summary>
        [JsonProperty(PropertyName = "fileSystem")]
        public FileSystemHttpLogsConfig FileSystem { get; set; }

        /// <summary>
        /// Gets or sets http logs to azure blob storage configuration.
        /// </summary>
        [JsonProperty(PropertyName = "azureBlobStorage")]
        public AzureBlobStorageHttpLogsConfig AzureBlobStorage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileSystem != null)
            {
                FileSystem.Validate();
            }
        }
    }
}
