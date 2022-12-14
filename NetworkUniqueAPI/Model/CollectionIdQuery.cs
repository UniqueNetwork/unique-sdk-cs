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
    /// CollectionIdQuery
    /// </summary>
    [DataContract(Name = "CollectionIdQuery")]
    public partial class CollectionIdQuery : IEquatable<CollectionIdQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionIdQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionIdQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionIdQuery" /> class.
        /// </summary>
        /// <param name="at">Hash of execution block.</param>
        /// <param name="collectionId">collectionId (required).</param>
        public CollectionIdQuery(string at = default(string), decimal collectionId = default(decimal))
        {
            this.CollectionId = collectionId;
            this.At = at;
        }

        /// <summary>
        /// Hash of execution block
        /// </summary>
        /// <value>Hash of execution block</value>
        [DataMember(Name = "at", EmitDefaultValue = false)]
        public string At { get; set; }

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
            sb.Append("class CollectionIdQuery {\n");
            sb.Append("  At: ").Append(At).Append("\n");
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
            return this.Equals(input as CollectionIdQuery);
        }

        /// <summary>
        /// Returns true if CollectionIdQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionIdQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionIdQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
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
                if (this.At != null)
                {
                    hashCode = (hashCode * 59) + this.At.GetHashCode();
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
