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
    /// BalanceTransferBody
    /// </summary>
    [DataContract(Name = "BalanceTransferBody")]
    public partial class BalanceTransferBody : IEquatable<BalanceTransferBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceTransferBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferBody" /> class.
        /// </summary>
        /// <param name="address">The ss-58 encoded address (required).</param>
        /// <param name="destination">The ss-58 encoded address (required).</param>
        /// <param name="amount">amount (required).</param>
        public BalanceTransferBody(string address = default(string), string destination = default(string), decimal amount = default(decimal))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for BalanceTransferBody and cannot be null");
            }
            this.Address = address;
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new ArgumentNullException("destination is a required property for BalanceTransferBody and cannot be null");
            }
            this.Destination = destination;
            this.Amount = amount;
        }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "destination", IsRequired = true, EmitDefaultValue = true)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceTransferBody {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as BalanceTransferBody);
        }

        /// <summary>
        /// Returns true if BalanceTransferBody instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceTransferBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceTransferBody input)
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
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
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
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
