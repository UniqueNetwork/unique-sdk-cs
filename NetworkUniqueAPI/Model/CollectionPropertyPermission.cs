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
    /// CollectionPropertyPermission
    /// </summary>
    [DataContract(Name = "CollectionPropertyPermission")]
    public partial class CollectionPropertyPermission : IEquatable<CollectionPropertyPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionPropertyPermission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionPropertyPermission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionPropertyPermission" /> class.
        /// </summary>
        /// <param name="mutable">mutable (required).</param>
        /// <param name="collectionAdmin">collectionAdmin (required).</param>
        /// <param name="tokenOwner">tokenOwner (required).</param>
        public CollectionPropertyPermission(bool mutable = default(bool), bool collectionAdmin = default(bool), bool tokenOwner = default(bool))
        {
            this.Mutable = mutable;
            this.CollectionAdmin = collectionAdmin;
            this.TokenOwner = tokenOwner;
        }

        /// <summary>
        /// Gets or Sets Mutable
        /// </summary>
        [DataMember(Name = "mutable", IsRequired = true, EmitDefaultValue = true)]
        public bool Mutable { get; set; }

        /// <summary>
        /// Gets or Sets CollectionAdmin
        /// </summary>
        [DataMember(Name = "collectionAdmin", IsRequired = true, EmitDefaultValue = true)]
        public bool CollectionAdmin { get; set; }

        /// <summary>
        /// Gets or Sets TokenOwner
        /// </summary>
        [DataMember(Name = "tokenOwner", IsRequired = true, EmitDefaultValue = true)]
        public bool TokenOwner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionPropertyPermission {\n");
            sb.Append("  Mutable: ").Append(Mutable).Append("\n");
            sb.Append("  CollectionAdmin: ").Append(CollectionAdmin).Append("\n");
            sb.Append("  TokenOwner: ").Append(TokenOwner).Append("\n");
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
            return this.Equals(input as CollectionPropertyPermission);
        }

        /// <summary>
        /// Returns true if CollectionPropertyPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionPropertyPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionPropertyPermission input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mutable == input.Mutable ||
                    this.Mutable.Equals(input.Mutable)
                ) && 
                (
                    this.CollectionAdmin == input.CollectionAdmin ||
                    this.CollectionAdmin.Equals(input.CollectionAdmin)
                ) && 
                (
                    this.TokenOwner == input.TokenOwner ||
                    this.TokenOwner.Equals(input.TokenOwner)
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
                hashCode = (hashCode * 59) + this.Mutable.GetHashCode();
                hashCode = (hashCode * 59) + this.CollectionAdmin.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenOwner.GetHashCode();
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