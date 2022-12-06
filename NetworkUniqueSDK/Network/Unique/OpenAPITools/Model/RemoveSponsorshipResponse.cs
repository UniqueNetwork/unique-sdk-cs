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
    /// RemoveSponsorshipResponse
    /// </summary>
    [DataContract(Name = "RemoveSponsorshipResponse")]
    public partial class RemoveSponsorshipResponse : IEquatable<RemoveSponsorshipResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSponsorshipResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoveSponsorshipResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSponsorshipResponse" /> class.
        /// </summary>
        /// <param name="isError">isError (required).</param>
        /// <param name="fee">fee.</param>
        /// <param name="parsed">parsed (required).</param>
        public RemoveSponsorshipResponse(bool isError = default(bool), FeeResponse fee = default(FeeResponse), RemoveSponsorshipParsed parsed = default(RemoveSponsorshipParsed))
        {
            this.IsError = isError;
            // to ensure "parsed" is required (not null)
            if (parsed == null)
            {
                throw new ArgumentNullException("parsed is a required property for RemoveSponsorshipResponse and cannot be null");
            }
            this.Parsed = parsed;
            this.Fee = fee;
        }

        /// <summary>
        /// Gets or Sets IsError
        /// </summary>
        [DataMember(Name = "isError", IsRequired = true, EmitDefaultValue = true)]
        public bool IsError { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public FeeResponse Fee { get; set; }

        /// <summary>
        /// Gets or Sets Parsed
        /// </summary>
        [DataMember(Name = "parsed", IsRequired = true, EmitDefaultValue = true)]
        public RemoveSponsorshipParsed Parsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RemoveSponsorshipResponse {\n");
            sb.Append("  IsError: ").Append(IsError).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Parsed: ").Append(Parsed).Append("\n");
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
            return this.Equals(input as RemoveSponsorshipResponse);
        }

        /// <summary>
        /// Returns true if RemoveSponsorshipResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveSponsorshipResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveSponsorshipResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsError == input.IsError ||
                    this.IsError.Equals(input.IsError)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Parsed == input.Parsed ||
                    (this.Parsed != null &&
                    this.Parsed.Equals(input.Parsed))
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
                hashCode = (hashCode * 59) + this.IsError.GetHashCode();
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.Parsed != null)
                {
                    hashCode = (hashCode * 59) + this.Parsed.GetHashCode();
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
