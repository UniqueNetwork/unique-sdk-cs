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
    /// ChainPropertiesResponse
    /// </summary>
    [DataContract(Name = "ChainPropertiesResponse")]
    public partial class ChainPropertiesResponse : IEquatable<ChainPropertiesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainPropertiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChainPropertiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainPropertiesResponse" /> class.
        /// </summary>
        /// <param name="sS58Prefix">sS58Prefix (required).</param>
        /// <param name="token">token (required).</param>
        /// <param name="decimals">decimals (required).</param>
        /// <param name="wsUrl">wsUrl (required).</param>
        /// <param name="genesisHash">genesisHash (required).</param>
        public ChainPropertiesResponse(decimal sS58Prefix = default(decimal), string token = default(string), decimal decimals = default(decimal), string wsUrl = default(string), string genesisHash = default(string))
        {
            this.SS58Prefix = sS58Prefix;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for ChainPropertiesResponse and cannot be null");
            }
            this.Token = token;
            this.Decimals = decimals;
            // to ensure "wsUrl" is required (not null)
            if (wsUrl == null)
            {
                throw new ArgumentNullException("wsUrl is a required property for ChainPropertiesResponse and cannot be null");
            }
            this.WsUrl = wsUrl;
            // to ensure "genesisHash" is required (not null)
            if (genesisHash == null)
            {
                throw new ArgumentNullException("genesisHash is a required property for ChainPropertiesResponse and cannot be null");
            }
            this.GenesisHash = genesisHash;
        }

        /// <summary>
        /// Gets or Sets SS58Prefix
        /// </summary>
        [DataMember(Name = "SS58Prefix", IsRequired = true, EmitDefaultValue = true)]
        public decimal SS58Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [DataMember(Name = "decimals", IsRequired = true, EmitDefaultValue = true)]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Gets or Sets WsUrl
        /// </summary>
        [DataMember(Name = "wsUrl", IsRequired = true, EmitDefaultValue = true)]
        public string WsUrl { get; set; }

        /// <summary>
        /// Gets or Sets GenesisHash
        /// </summary>
        [DataMember(Name = "genesisHash", IsRequired = true, EmitDefaultValue = true)]
        public string GenesisHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChainPropertiesResponse {\n");
            sb.Append("  SS58Prefix: ").Append(SS58Prefix).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  WsUrl: ").Append(WsUrl).Append("\n");
            sb.Append("  GenesisHash: ").Append(GenesisHash).Append("\n");
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
            return this.Equals(input as ChainPropertiesResponse);
        }

        /// <summary>
        /// Returns true if ChainPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChainPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChainPropertiesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SS58Prefix == input.SS58Prefix ||
                    this.SS58Prefix.Equals(input.SS58Prefix)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Decimals == input.Decimals ||
                    this.Decimals.Equals(input.Decimals)
                ) && 
                (
                    this.WsUrl == input.WsUrl ||
                    (this.WsUrl != null &&
                    this.WsUrl.Equals(input.WsUrl))
                ) && 
                (
                    this.GenesisHash == input.GenesisHash ||
                    (this.GenesisHash != null &&
                    this.GenesisHash.Equals(input.GenesisHash))
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
                hashCode = (hashCode * 59) + this.SS58Prefix.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Decimals.GetHashCode();
                if (this.WsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WsUrl.GetHashCode();
                }
                if (this.GenesisHash != null)
                {
                    hashCode = (hashCode * 59) + this.GenesisHash.GetHashCode();
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
