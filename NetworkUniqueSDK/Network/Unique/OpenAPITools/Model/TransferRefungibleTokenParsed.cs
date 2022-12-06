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
    /// TransferRefungibleTokenParsed
    /// </summary>
    [DataContract(Name = "TransferRefungibleTokenParsed")]
    public partial class TransferRefungibleTokenParsed : IEquatable<TransferRefungibleTokenParsed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRefungibleTokenParsed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferRefungibleTokenParsed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRefungibleTokenParsed" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId (required).</param>
        /// <param name="tokenId">tokenId (required).</param>
        /// <param name="from">The ss-58 encoded address (required).</param>
        /// <param name="to">The ss-58 encoded address (required).</param>
        /// <param name="amount">amount (required).</param>
        public TransferRefungibleTokenParsed(decimal collectionId = default(decimal), decimal tokenId = default(decimal), string from = default(string), string to = default(string), decimal amount = default(decimal))
        {
            this.CollectionId = collectionId;
            this.TokenId = tokenId;
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for TransferRefungibleTokenParsed and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for TransferRefungibleTokenParsed and cannot be null");
            }
            this.To = to;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", IsRequired = true, EmitDefaultValue = true)]
        public decimal CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public decimal TokenId { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

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
            sb.Append("class TransferRefungibleTokenParsed {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as TransferRefungibleTokenParsed);
        }

        /// <summary>
        /// Returns true if TransferRefungibleTokenParsed instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRefungibleTokenParsed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRefungibleTokenParsed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionId == input.CollectionId ||
                    this.CollectionId.Equals(input.CollectionId)
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    this.TokenId.Equals(input.TokenId)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
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
