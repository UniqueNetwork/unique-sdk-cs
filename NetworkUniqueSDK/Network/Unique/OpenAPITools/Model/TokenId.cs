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
    /// TokenId
    /// </summary>
    [DataContract(Name = "TokenId")]
    public partial class TokenId : IEquatable<TokenId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenId" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId (required).</param>
        /// <param name="tokenId">tokenId (required).</param>
        public TokenId(decimal collectionId = default(decimal), decimal tokenId = default(decimal))
        {
            this.CollectionId = collectionId;
            this._TokenId = tokenId;
        }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", IsRequired = true, EmitDefaultValue = true)]
        public decimal CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets _TokenId
        /// </summary>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public decimal _TokenId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenId {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  _TokenId: ").Append(_TokenId).Append("\n");
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
            return this.Equals(input as TokenId);
        }

        /// <summary>
        /// Returns true if TokenId instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenId input)
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
                    this._TokenId == input._TokenId ||
                    this._TokenId.Equals(input._TokenId)
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
                hashCode = (hashCode * 59) + this._TokenId.GetHashCode();
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
