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
    /// AudioDto
    /// </summary>
    [DataContract(Name = "AudioDto")]
    public partial class AudioDto : IEquatable<AudioDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudioDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDto" /> class.
        /// </summary>
        /// <param name="urlTemplate">urlTemplate.</param>
        /// <param name="format">format (required).</param>
        /// <param name="isLossless">isLossless.</param>
        public AudioDto(string urlTemplate = default(string), string format = default(string), bool isLossless = default(bool))
        {
            // to ensure "format" is required (not null)
            if (format == null)
            {
                throw new ArgumentNullException("format is a required property for AudioDto and cannot be null");
            }
            this.Format = format;
            this.UrlTemplate = urlTemplate;
            this.IsLossless = isLossless;
        }

        /// <summary>
        /// Gets or Sets UrlTemplate
        /// </summary>
        [DataMember(Name = "urlTemplate", EmitDefaultValue = false)]
        public string UrlTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets IsLossless
        /// </summary>
        [DataMember(Name = "isLossless", EmitDefaultValue = true)]
        public bool IsLossless { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudioDto {\n");
            sb.Append("  UrlTemplate: ").Append(UrlTemplate).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  IsLossless: ").Append(IsLossless).Append("\n");
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
            return this.Equals(input as AudioDto);
        }

        /// <summary>
        /// Returns true if AudioDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AudioDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudioDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UrlTemplate == input.UrlTemplate ||
                    (this.UrlTemplate != null &&
                    this.UrlTemplate.Equals(input.UrlTemplate))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.IsLossless == input.IsLossless ||
                    this.IsLossless.Equals(input.IsLossless)
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
                if (this.UrlTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UrlTemplate.GetHashCode();
                }
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsLossless.GetHashCode();
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
