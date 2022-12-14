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
    /// AllBalancesResponse
    /// </summary>
    [DataContract(Name = "AllBalancesResponse")]
    public partial class AllBalancesResponse : IEquatable<AllBalancesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllBalancesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllBalancesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllBalancesResponse" /> class.
        /// </summary>
        /// <param name="availableBalance">availableBalance (required).</param>
        /// <param name="lockedBalance">lockedBalance (required).</param>
        /// <param name="freeBalance">freeBalance (required).</param>
        /// <param name="address">The ss-58 encoded address (required).</param>
        public AllBalancesResponse(BalanceResponse availableBalance = default(BalanceResponse), BalanceResponse lockedBalance = default(BalanceResponse), BalanceResponse freeBalance = default(BalanceResponse), string address = default(string))
        {
            // to ensure "availableBalance" is required (not null)
            if (availableBalance == null)
            {
                throw new ArgumentNullException("availableBalance is a required property for AllBalancesResponse and cannot be null");
            }
            this.AvailableBalance = availableBalance;
            // to ensure "lockedBalance" is required (not null)
            if (lockedBalance == null)
            {
                throw new ArgumentNullException("lockedBalance is a required property for AllBalancesResponse and cannot be null");
            }
            this.LockedBalance = lockedBalance;
            // to ensure "freeBalance" is required (not null)
            if (freeBalance == null)
            {
                throw new ArgumentNullException("freeBalance is a required property for AllBalancesResponse and cannot be null");
            }
            this.FreeBalance = freeBalance;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for AllBalancesResponse and cannot be null");
            }
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets AvailableBalance
        /// </summary>
        [DataMember(Name = "availableBalance", IsRequired = true, EmitDefaultValue = true)]
        public BalanceResponse AvailableBalance { get; set; }

        /// <summary>
        /// Gets or Sets LockedBalance
        /// </summary>
        [DataMember(Name = "lockedBalance", IsRequired = true, EmitDefaultValue = true)]
        public BalanceResponse LockedBalance { get; set; }

        /// <summary>
        /// Gets or Sets FreeBalance
        /// </summary>
        [DataMember(Name = "freeBalance", IsRequired = true, EmitDefaultValue = true)]
        public BalanceResponse FreeBalance { get; set; }

        /// <summary>
        /// The ss-58 encoded address
        /// </summary>
        /// <value>The ss-58 encoded address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AllBalancesResponse {\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  LockedBalance: ").Append(LockedBalance).Append("\n");
            sb.Append("  FreeBalance: ").Append(FreeBalance).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as AllBalancesResponse);
        }

        /// <summary>
        /// Returns true if AllBalancesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AllBalancesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllBalancesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
                ) && 
                (
                    this.LockedBalance == input.LockedBalance ||
                    (this.LockedBalance != null &&
                    this.LockedBalance.Equals(input.LockedBalance))
                ) && 
                (
                    this.FreeBalance == input.FreeBalance ||
                    (this.FreeBalance != null &&
                    this.FreeBalance.Equals(input.FreeBalance))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.AvailableBalance != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableBalance.GetHashCode();
                }
                if (this.LockedBalance != null)
                {
                    hashCode = (hashCode * 59) + this.LockedBalance.GetHashCode();
                }
                if (this.FreeBalance != null)
                {
                    hashCode = (hashCode * 59) + this.FreeBalance.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
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
