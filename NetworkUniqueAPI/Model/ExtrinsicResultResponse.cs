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
    /// ExtrinsicResultResponse
    /// </summary>
    [DataContract(Name = "ExtrinsicResultResponse")]
    public partial class ExtrinsicResultResponse : IEquatable<ExtrinsicResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrinsicResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtrinsicResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrinsicResultResponse" /> class.
        /// </summary>
        /// <param name="isCompleted">isCompleted (required).</param>
        /// <param name="blockHash">blockHash (required).</param>
        /// <param name="blockIndex">blockIndex (required).</param>
        /// <param name="error">error (required).</param>
        /// <param name="events">events (required).</param>
        /// <param name="parsed">parsed.</param>
        /// <param name="fee">fee.</param>
        /// <param name="callbackUrl">callbackUrl (required).</param>
        public ExtrinsicResultResponse(bool isCompleted = default(bool), string blockHash = default(string), decimal blockIndex = default(decimal), Object error = default(Object), List<ExtrinsicResultEvent> events = default(List<ExtrinsicResultEvent>), Object parsed = default(Object), FeeResponse fee = default(FeeResponse), string callbackUrl = default(string))
        {
            this.IsCompleted = isCompleted;
            // to ensure "blockHash" is required (not null)
            if (blockHash == null)
            {
                throw new ArgumentNullException("blockHash is a required property for ExtrinsicResultResponse and cannot be null");
            }
            this.BlockHash = blockHash;
            this.BlockIndex = blockIndex;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for ExtrinsicResultResponse and cannot be null");
            }
            this.Error = error;
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for ExtrinsicResultResponse and cannot be null");
            }
            this.Events = events;
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for ExtrinsicResultResponse and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.Parsed = parsed;
            this.Fee = fee;
        }

        /// <summary>
        /// Gets or Sets IsCompleted
        /// </summary>
        [DataMember(Name = "isCompleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Gets or Sets BlockHash
        /// </summary>
        [DataMember(Name = "blockHash", IsRequired = true, EmitDefaultValue = true)]
        public string BlockHash { get; set; }

        /// <summary>
        /// Gets or Sets BlockIndex
        /// </summary>
        [DataMember(Name = "blockIndex", IsRequired = true, EmitDefaultValue = true)]
        public decimal BlockIndex { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public Object Error { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<ExtrinsicResultEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets Parsed
        /// </summary>
        [DataMember(Name = "parsed", EmitDefaultValue = false)]
        public Object Parsed { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public FeeResponse Fee { get; set; }

        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtrinsicResultResponse {\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  BlockIndex: ").Append(BlockIndex).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Parsed: ").Append(Parsed).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as ExtrinsicResultResponse);
        }

        /// <summary>
        /// Returns true if ExtrinsicResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtrinsicResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtrinsicResultResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsCompleted == input.IsCompleted ||
                    this.IsCompleted.Equals(input.IsCompleted)
                ) && 
                (
                    this.BlockHash == input.BlockHash ||
                    (this.BlockHash != null &&
                    this.BlockHash.Equals(input.BlockHash))
                ) && 
                (
                    this.BlockIndex == input.BlockIndex ||
                    this.BlockIndex.Equals(input.BlockIndex)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Parsed == input.Parsed ||
                    (this.Parsed != null &&
                    this.Parsed.Equals(input.Parsed))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
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
                hashCode = (hashCode * 59) + this.IsCompleted.GetHashCode();
                if (this.BlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.BlockHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BlockIndex.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.Parsed != null)
                {
                    hashCode = (hashCode * 59) + this.Parsed.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
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
