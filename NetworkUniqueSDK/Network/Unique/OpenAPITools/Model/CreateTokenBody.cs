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
    /// CreateTokenBody
    /// </summary>
    [DataContract(Name = "CreateTokenBody")]
    public partial class CreateTokenBody : IEquatable<CreateTokenBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTokenBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenBody" /> class.
        /// </summary>
        /// <param name="owner">The ss-58 encoded address.</param>
        /// <param name="data">data.</param>
        /// <param name="properties">properties.</param>
        /// <param name="address">The ss-58 encoded address (required).</param>
        /// <param name="collectionId">collectionId (required).</param>
        public CreateTokenBody(string owner = default(string), UniqueTokenToCreateDto data = default(UniqueTokenToCreateDto), List<TokenProperty> properties = default(List<TokenProperty>), string address = default(string), decimal collectionId = default(decimal))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CreateTokenBody and cannot be null");
            }
            this.Address = address;
            this.CollectionId = collectionId;
            this.Owner = owner;
            this.Data = data;
            this.Properties = properties;
        }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public UniqueTokenToCreateDto Data { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<TokenProperty> Properties { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTokenBody {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
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
            return this.Equals(input as CreateTokenBody);
        }

        /// <summary>
        /// Returns true if CreateTokenBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTokenBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTokenBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    this.CollectionId.Equals(input.CollectionId)
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
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
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
