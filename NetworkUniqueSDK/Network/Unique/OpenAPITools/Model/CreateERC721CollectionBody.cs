/*
 * Unique SDK
 *
 * Unique SDK HTTP API  <b>Main connection to wss://ws-opal.unique.network (<a target=\"_blank\" href=\"https://polkadot.js.org/apps/?rpc=wss://ws-opal.unique.network\">apps ↗</a>)</b>  Secondary substrate connection to wss://ws-relay-bench.unique.network  (<a target=\"_blank\" href=\"https://polkadot.js.org/apps/?rpc=wss://ws-relay-bench.unique.network\">apps ↗</a>). Go to <a href=\"/relay/swagger\">/relay/swagger</a>  Consumable OpenAPI specification - (<a target=\"_blank\" href=\"/swagger-json\">JSON ↗</a>) (<a target=\"_blank\" href=\"/swagger-yaml\">YAML ↗</a>)
 *
 * The version of the OpenAPI document: 0.6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CreateERC721CollectionBody
    /// </summary>
    [DataContract(Name = "CreateERC721CollectionBody")]
    public partial class CreateERC721CollectionBody : IEquatable<CreateERC721CollectionBody>, IValidatableObject
    {
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum NFT for value: NFT
            /// </summary>
            [EnumMember(Value = "NFT")]
            NFT = 1,

            /// <summary>
            /// Enum Fungible for value: Fungible
            /// </summary>
            [EnumMember(Value = "Fungible")]
            Fungible = 2,

            /// <summary>
            /// Enum ReFungible for value: ReFungible
            /// </summary>
            [EnumMember(Value = "ReFungible")]
            ReFungible = 3

        }


        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Defines MetaUpdatePermission
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetaUpdatePermissionEnum
        {
            /// <summary>
            /// Enum ItemOwner for value: ItemOwner
            /// </summary>
            [EnumMember(Value = "ItemOwner")]
            ItemOwner = 1,

            /// <summary>
            /// Enum Admin for value: Admin
            /// </summary>
            [EnumMember(Value = "Admin")]
            Admin = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }


        /// <summary>
        /// Gets or Sets MetaUpdatePermission
        /// </summary>
        [DataMember(Name = "metaUpdatePermission", EmitDefaultValue = false)]
        public MetaUpdatePermissionEnum? MetaUpdatePermission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateERC721CollectionBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateERC721CollectionBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateERC721CollectionBody" /> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="tokenPrefix">tokenPrefix (required).</param>
        /// <param name="sponsorship">sponsorship.</param>
        /// <param name="limits">limits.</param>
        /// <param name="metaUpdatePermission">metaUpdatePermission.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="address">The ss-58 encoded address (required).</param>
        /// <param name="baseURI">baseURI.</param>
        /// <param name="properties">properties.</param>
        /// <param name="tokenPropertyPermissions">tokenPropertyPermissions.</param>
        public CreateERC721CollectionBody(ModeEnum? mode = default(ModeEnum?), string name = default(string), string description = default(string), string tokenPrefix = default(string), CollectionSponsorship sponsorship = default(CollectionSponsorship), CollectionLimitsDto limits = default(CollectionLimitsDto), MetaUpdatePermissionEnum? metaUpdatePermission = default(MetaUpdatePermissionEnum?), CollectionPermissionsDto permissions = default(CollectionPermissionsDto), bool readOnly = default(bool), string address = default(string), string baseURI = default(string), List<CollectionProperty> properties = default(List<CollectionProperty>), List<PropertyKeyPermission> tokenPropertyPermissions = default(List<PropertyKeyPermission>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateERC721CollectionBody and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for CreateERC721CollectionBody and cannot be null");
            }
            this.Description = description;
            // to ensure "tokenPrefix" is required (not null)
            if (tokenPrefix == null)
            {
                throw new ArgumentNullException("tokenPrefix is a required property for CreateERC721CollectionBody and cannot be null");
            }
            this.TokenPrefix = tokenPrefix;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CreateERC721CollectionBody and cannot be null");
            }
            this.Address = address;
            this.Mode = mode;
            this.Sponsorship = sponsorship;
            this.Limits = limits;
            this.MetaUpdatePermission = metaUpdatePermission;
            this.Permissions = permissions;
            this.ReadOnly = readOnly;
            this.BaseURI = baseURI;
            this.Properties = properties;
            this.TokenPropertyPermissions = tokenPropertyPermissions;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets TokenPrefix
        /// </summary>
        [DataMember(Name = "tokenPrefix", IsRequired = true, EmitDefaultValue = true)]
        public string TokenPrefix { get; set; }

        /// <summary>
        /// Gets or Sets Sponsorship
        /// </summary>
        [DataMember(Name = "sponsorship", EmitDefaultValue = false)]
        public CollectionSponsorship Sponsorship { get; set; }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name = "limits", EmitDefaultValue = false)]
        public CollectionLimitsDto Limits { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public CollectionPermissionsDto Permissions { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets BaseURI
        /// </summary>
        [DataMember(Name = "baseURI", EmitDefaultValue = false)]
        public string BaseURI { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<CollectionProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets TokenPropertyPermissions
        /// </summary>
        [DataMember(Name = "tokenPropertyPermissions", EmitDefaultValue = false)]
        public List<PropertyKeyPermission> TokenPropertyPermissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateERC721CollectionBody {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TokenPrefix: ").Append(TokenPrefix).Append("\n");
            sb.Append("  Sponsorship: ").Append(Sponsorship).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  MetaUpdatePermission: ").Append(MetaUpdatePermission).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BaseURI: ").Append(BaseURI).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  TokenPropertyPermissions: ").Append(TokenPropertyPermissions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateERC721CollectionBody);
        }

        /// <summary>
        /// Returns true if CreateERC721CollectionBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateERC721CollectionBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateERC721CollectionBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TokenPrefix == input.TokenPrefix ||
                    (this.TokenPrefix != null &&
                    this.TokenPrefix.Equals(input.TokenPrefix))
                ) && 
                (
                    this.Sponsorship == input.Sponsorship ||
                    (this.Sponsorship != null &&
                    this.Sponsorship.Equals(input.Sponsorship))
                ) && 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
                ) && 
                (
                    this.MetaUpdatePermission == input.MetaUpdatePermission ||
                    this.MetaUpdatePermission.Equals(input.MetaUpdatePermission)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BaseURI == input.BaseURI ||
                    (this.BaseURI != null &&
                    this.BaseURI.Equals(input.BaseURI))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.TokenPropertyPermissions == input.TokenPropertyPermissions ||
                    this.TokenPropertyPermissions != null &&
                    input.TokenPropertyPermissions != null &&
                    this.TokenPropertyPermissions.SequenceEqual(input.TokenPropertyPermissions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.TokenPrefix != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPrefix.GetHashCode();
                }
                if (this.Sponsorship != null)
                {
                    hashCode = (hashCode * 59) + this.Sponsorship.GetHashCode();
                }
                if (this.Limits != null)
                {
                    hashCode = (hashCode * 59) + this.Limits.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MetaUpdatePermission.GetHashCode();
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReadOnly.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BaseURI != null)
                {
                    hashCode = (hashCode * 59) + this.BaseURI.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.TokenPropertyPermissions != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPropertyPermissions.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
