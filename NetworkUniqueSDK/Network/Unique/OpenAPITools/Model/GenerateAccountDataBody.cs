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
    /// GenerateAccountDataBody
    /// </summary>
    [DataContract(Name = "GenerateAccountDataBody")]
    public partial class GenerateAccountDataBody : IEquatable<GenerateAccountDataBody>, IValidatableObject
    {
        /// <summary>
        /// Signature: ed25519, sr25519 implementation using Schnorr signatures. ECDSA signatures on the secp256k1 curve
        /// </summary>
        /// <value>Signature: ed25519, sr25519 implementation using Schnorr signatures. ECDSA signatures on the secp256k1 curve</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PairTypeEnum
        {
            /// <summary>
            /// Enum Sr25519 for value: sr25519
            /// </summary>
            [EnumMember(Value = "sr25519")]
            Sr25519 = 1,

            /// <summary>
            /// Enum Ed25519 for value: ed25519
            /// </summary>
            [EnumMember(Value = "ed25519")]
            Ed25519 = 2,

            /// <summary>
            /// Enum Ecdsa for value: ecdsa
            /// </summary>
            [EnumMember(Value = "ecdsa")]
            Ecdsa = 3,

            /// <summary>
            /// Enum Ethereum for value: ethereum
            /// </summary>
            [EnumMember(Value = "ethereum")]
            Ethereum = 4

        }


        /// <summary>
        /// Signature: ed25519, sr25519 implementation using Schnorr signatures. ECDSA signatures on the secp256k1 curve
        /// </summary>
        /// <value>Signature: ed25519, sr25519 implementation using Schnorr signatures. ECDSA signatures on the secp256k1 curve</value>
        [DataMember(Name = "pairType", EmitDefaultValue = false)]
        public PairTypeEnum? PairType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAccountDataBody" /> class.
        /// </summary>
        /// <param name="pairType">Signature: ed25519, sr25519 implementation using Schnorr signatures. ECDSA signatures on the secp256k1 curve.</param>
        /// <param name="meta">A metadata argument that contains account information (that may be obtained from the json file of an account backup).</param>
        public GenerateAccountDataBody(PairTypeEnum? pairType = default(PairTypeEnum?), Object meta = default(Object))
        {
            this.PairType = pairType;
            this.Meta = meta;
        }

        /// <summary>
        /// A metadata argument that contains account information (that may be obtained from the json file of an account backup)
        /// </summary>
        /// <value>A metadata argument that contains account information (that may be obtained from the json file of an account backup)</value>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Object Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateAccountDataBody {\n");
            sb.Append("  PairType: ").Append(PairType).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as GenerateAccountDataBody);
        }

        /// <summary>
        /// Returns true if GenerateAccountDataBody instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateAccountDataBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateAccountDataBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PairType == input.PairType ||
                    this.PairType.Equals(input.PairType)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                hashCode = (hashCode * 59) + this.PairType.GetHashCode();
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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
