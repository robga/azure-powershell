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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing certificate reissue request.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ReissueCertificateOrderRequest : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the ReissueCertificateOrderRequest
        /// class.
        /// </summary>
        public ReissueCertificateOrderRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReissueCertificateOrderRequest
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="keySize">Certificate Key Size.</param>
        /// <param name="delayExistingRevokeInHours">Delay in hours to revoke
        /// existing certificate after the new certificate is issued.</param>
        /// <param name="csr">Csr to be used for re-key operation.</param>
        /// <param name="isPrivateKeyExternal">Should we change the ASC type
        /// (from managed private key to external private key and vice
        /// versa).</param>
        public ReissueCertificateOrderRequest(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), int? keySize = default(int?), int? delayExistingRevokeInHours = default(int?), string csr = default(string), bool? isPrivateKeyExternal = default(bool?))
            : base(id, name, kind, type)
        {
            KeySize = keySize;
            DelayExistingRevokeInHours = delayExistingRevokeInHours;
            Csr = csr;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate Key Size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keySize")]
        public int? KeySize { get; set; }

        /// <summary>
        /// Gets or sets delay in hours to revoke existing certificate after
        /// the new certificate is issued.
        /// </summary>
        [JsonProperty(PropertyName = "properties.delayExistingRevokeInHours")]
        public int? DelayExistingRevokeInHours { get; set; }

        /// <summary>
        /// Gets or sets csr to be used for re-key operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.csr")]
        public string Csr { get; set; }

        /// <summary>
        /// Gets or sets should we change the ASC type (from managed private
        /// key to external private key and vice versa).
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPrivateKeyExternal")]
        public bool? IsPrivateKeyExternal { get; set; }

    }
}
