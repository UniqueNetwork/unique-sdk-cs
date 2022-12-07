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
using OpenAPIDateConverter = Network.Unique.API.Client.OpenAPIDateConverter;

namespace Network.Unique.API.Model
{
    /// <summary>
    /// UnnestTokenBody
    /// </summary>
    [DataContract(Name = "UnnestTokenBody")]
    public partial class UnnestTokenBody : IEquatable<UnnestTokenBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnnestTokenBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenBody" /> class.
        /// </summary>
        /// <param name="address">The ss-58 encoded or Ethereum address (required).</param>
        /// <param name="nested">nested (required).</param>
        /// <param name="to">The ss-58 encoded or Ethereum address.</param>
        /// <param name="value">value (default to 1M).</param>
        public UnnestTokenBody(string address = default(string), NestTokenBodyNested nested = default(NestTokenBodyNested), string to = default(string), decimal value = 1M)
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for UnnestTokenBody and cannot be null");
            }
            this.Address = address;
            // to ensure "nested" is required (not null)
            if (nested == null)
            {
                throw new ArgumentNullException("nested is a required property for UnnestTokenBody and cannot be null");
            }
            this.Nested = nested;
            this.To = to;
            this.Value = value;
        }

        /// <summary>
        /// The ss-58 encoded or Ethereum address
        /// </summary>
        /// <value>The ss-58 encoded or Ethereum address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Nested
        /// </summary>
        [DataMember(Name = "nested", IsRequired = true, EmitDefaultValue = true)]
        public NestTokenBodyNested Nested { get; set; }

        /// <summary>
        /// The ss-58 encoded or Ethereum address
        /// </summary>
        /// <value>The ss-58 encoded or Ethereum address</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnnestTokenBody {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Nested: ").Append(Nested).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as UnnestTokenBody);
        }

        /// <summary>
        /// Returns true if UnnestTokenBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UnnestTokenBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnnestTokenBody input)
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
                    this.Nested == input.Nested ||
                    (this.Nested != null &&
                    this.Nested.Equals(input.Nested))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.Nested != null)
                {
                    hashCode = (hashCode * 59) + this.Nested.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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