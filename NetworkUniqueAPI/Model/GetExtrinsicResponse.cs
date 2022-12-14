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
    /// GetExtrinsicResponse
    /// </summary>
    [DataContract(Name = "GetExtrinsicResponse")]
    public partial class GetExtrinsicResponse : IEquatable<GetExtrinsicResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtrinsicResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtrinsicResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtrinsicResponse" /> class.
        /// </summary>
        /// <param name="section">section (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="events">events (required).</param>
        /// <param name="args">args (required).</param>
        /// <param name="nonce">nonce (required).</param>
        /// <param name="signer">signer (required).</param>
        public GetExtrinsicResponse(string section = default(string), string method = default(string), List<Object> events = default(List<Object>), List<Object> args = default(List<Object>), decimal nonce = default(decimal), string signer = default(string))
        {
            // to ensure "section" is required (not null)
            if (section == null)
            {
                throw new ArgumentNullException("section is a required property for GetExtrinsicResponse and cannot be null");
            }
            this.Section = section;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for GetExtrinsicResponse and cannot be null");
            }
            this.Method = method;
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for GetExtrinsicResponse and cannot be null");
            }
            this.Events = events;
            // to ensure "args" is required (not null)
            if (args == null)
            {
                throw new ArgumentNullException("args is a required property for GetExtrinsicResponse and cannot be null");
            }
            this.Args = args;
            this.Nonce = nonce;
            // to ensure "signer" is required (not null)
            if (signer == null)
            {
                throw new ArgumentNullException("signer is a required property for GetExtrinsicResponse and cannot be null");
            }
            this.Signer = signer;
        }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name = "section", IsRequired = true, EmitDefaultValue = true)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> Events { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name = "args", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> Args { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public decimal Nonce { get; set; }

        /// <summary>
        /// Gets or Sets Signer
        /// </summary>
        [DataMember(Name = "signer", IsRequired = true, EmitDefaultValue = true)]
        public string Signer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetExtrinsicResponse {\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
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
            return this.Equals(input as GetExtrinsicResponse);
        }

        /// <summary>
        /// Returns true if GetExtrinsicResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtrinsicResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtrinsicResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.Signer == input.Signer ||
                    (this.Signer != null &&
                    this.Signer.Equals(input.Signer))
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
                if (this.Section != null)
                {
                    hashCode = (hashCode * 59) + this.Section.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.Args != null)
                {
                    hashCode = (hashCode * 59) + this.Args.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.Signer != null)
                {
                    hashCode = (hashCode * 59) + this.Signer.GetHashCode();
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
