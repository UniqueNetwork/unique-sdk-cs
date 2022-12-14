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
    /// TransferCollectionParsed
    /// </summary>
    [DataContract(Name = "TransferCollectionParsed")]
    public partial class TransferCollectionParsed : IEquatable<TransferCollectionParsed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCollectionParsed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferCollectionParsed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCollectionParsed" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId (required).</param>
        /// <param name="owner">The ss-58 encoded address (required).</param>
        public TransferCollectionParsed(decimal collectionId = default(decimal), string owner = default(string))
        {
            this.CollectionId = collectionId;
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new ArgumentNullException("owner is a required property for TransferCollectionParsed and cannot be null");
            }
            this.Owner = owner;
        }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", IsRequired = true, EmitDefaultValue = true)]
        public decimal CollectionId { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferCollectionParsed {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as TransferCollectionParsed);
        }

        /// <summary>
        /// Returns true if TransferCollectionParsed instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferCollectionParsed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferCollectionParsed input)
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
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
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
