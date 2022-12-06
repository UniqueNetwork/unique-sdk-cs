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
    /// AddCollectionAdminBody
    /// </summary>
    [DataContract(Name = "AddCollectionAdminBody")]
    public partial class AddCollectionAdminBody : IEquatable<AddCollectionAdminBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCollectionAdminBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddCollectionAdminBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCollectionAdminBody" /> class.
        /// </summary>
        /// <param name="address">The ss-58 encoded address (required).</param>
        /// <param name="collectionId">collectionId (required).</param>
        /// <param name="newAdmin">The ss-58 encoded address (required).</param>
        public AddCollectionAdminBody(string address = default(string), decimal collectionId = default(decimal), string newAdmin = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for AddCollectionAdminBody and cannot be null");
            }
            this.Address = address;
            this.CollectionId = collectionId;
            // to ensure "newAdmin" is required (not null)
            if (newAdmin == null)
            {
                throw new ArgumentNullException("newAdmin is a required property for AddCollectionAdminBody and cannot be null");
            }
            this.NewAdmin = newAdmin;
        }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", IsRequired = true, EmitDefaultValue = true)]
        public decimal CollectionId { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "newAdmin", IsRequired = true, EmitDefaultValue = true)]
        public string NewAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddCollectionAdminBody {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  NewAdmin: ").Append(NewAdmin).Append("\n");
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
            return this.Equals(input as AddCollectionAdminBody);
        }

        /// <summary>
        /// Returns true if AddCollectionAdminBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AddCollectionAdminBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddCollectionAdminBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    this.CollectionId.Equals(input.CollectionId)
                ) && 
                (
                    this.NewAdmin == input.NewAdmin ||
                    (this.NewAdmin != null &&
                    this.NewAdmin.Equals(input.NewAdmin))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                if (this.NewAdmin != null)
                {
                    hashCode = (hashCode * 59) + this.NewAdmin.GetHashCode();
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
