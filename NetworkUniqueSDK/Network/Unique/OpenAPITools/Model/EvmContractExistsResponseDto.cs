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
    /// EvmContractExistsResponseDto
    /// </summary>
    [DataContract(Name = "EvmContractExistsResponseDto")]
    public partial class EvmContractExistsResponseDto : IEquatable<EvmContractExistsResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvmContractExistsResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvmContractExistsResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvmContractExistsResponseDto" /> class.
        /// </summary>
        /// <param name="exists">exists (required).</param>
        public EvmContractExistsResponseDto(bool exists = default(bool))
        {
            this.Exists = exists;
        }

        /// <summary>
        /// Gets or Sets Exists
        /// </summary>
        [DataMember(Name = "exists", IsRequired = true, EmitDefaultValue = true)]
        public bool Exists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EvmContractExistsResponseDto {\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
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
            return this.Equals(input as EvmContractExistsResponseDto);
        }

        /// <summary>
        /// Returns true if EvmContractExistsResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EvmContractExistsResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvmContractExistsResponseDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Exists == input.Exists ||
                    this.Exists.Equals(input.Exists)
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
                hashCode = (hashCode * 59) + this.Exists.GetHashCode();
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
