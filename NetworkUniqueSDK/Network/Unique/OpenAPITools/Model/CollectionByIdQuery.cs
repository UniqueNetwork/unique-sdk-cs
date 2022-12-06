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
    /// CollectionByIdQuery
    /// </summary>
    [DataContract(Name = "CollectionByIdQuery")]
    public partial class CollectionByIdQuery : IEquatable<CollectionByIdQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionByIdQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionByIdQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionByIdQuery" /> class.
        /// </summary>
        /// <param name="at">Hash of execution block.</param>
        /// <param name="collectionId">collectionId (required).</param>
        public CollectionByIdQuery(string at = default(string), TokenIdQueryCollectionId collectionId = default(TokenIdQueryCollectionId))
        {
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for CollectionByIdQuery and cannot be null");
            }
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
        public TokenIdQueryCollectionId CollectionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionByIdQuery {\n");
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
            return this.Equals(input as CollectionByIdQuery);
        }

        /// <summary>
        /// Returns true if CollectionByIdQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionByIdQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionByIdQuery input)
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
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
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
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
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
