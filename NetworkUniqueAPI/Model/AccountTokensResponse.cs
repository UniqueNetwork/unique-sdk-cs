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
    /// AccountTokensResponse
    /// </summary>
    [DataContract(Name = "AccountTokensResponse")]
    public partial class AccountTokensResponse : IEquatable<AccountTokensResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokensResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountTokensResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokensResponse" /> class.
        /// </summary>
        /// <param name="tokens">tokens (required).</param>
        public AccountTokensResponse(List<TokenId> tokens = default(List<TokenId>))
        {
            // to ensure "tokens" is required (not null)
            if (tokens == null)
            {
                throw new ArgumentNullException("tokens is a required property for AccountTokensResponse and cannot be null");
            }
            this.Tokens = tokens;
        }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name = "tokens", IsRequired = true, EmitDefaultValue = true)]
        public List<TokenId> Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountTokensResponse {\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(input as AccountTokensResponse);
        }

        /// <summary>
        /// Returns true if AccountTokensResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountTokensResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTokensResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    input.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
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
                if (this.Tokens != null)
                {
                    hashCode = (hashCode * 59) + this.Tokens.GetHashCode();
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
