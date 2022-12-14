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
    /// PropertyPermissionsQuery
    /// </summary>
    [DataContract(Name = "PropertyPermissionsQuery")]
    public partial class PropertyPermissionsQuery : IEquatable<PropertyPermissionsQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyPermissionsQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyPermissionsQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyPermissionsQuery" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId (required).</param>
        /// <param name="propertyKeys">propertyKeys.</param>
        /// <param name="at">Hash of execution block.</param>
        public PropertyPermissionsQuery(decimal collectionId = default(decimal), List<string> propertyKeys = default(List<string>), string at = default(string))
        {
            this.CollectionId = collectionId;
            this.PropertyKeys = propertyKeys;
            this.At = at;
        }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", IsRequired = true, EmitDefaultValue = true)]
        public decimal CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets PropertyKeys
        /// </summary>
        [DataMember(Name = "propertyKeys", EmitDefaultValue = false)]
        public List<string> PropertyKeys { get; set; }

        /// <summary>
        /// Hash of execution block
        /// </summary>
        /// <value>Hash of execution block</value>
        [DataMember(Name = "at", EmitDefaultValue = false)]
        public string At { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyPermissionsQuery {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  PropertyKeys: ").Append(PropertyKeys).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
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
            return this.Equals(input as PropertyPermissionsQuery);
        }

        /// <summary>
        /// Returns true if PropertyPermissionsQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyPermissionsQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyPermissionsQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionId == input.CollectionId ||
                    this.CollectionId.Equals(input.CollectionId)
                ) && 
                (
                    this.PropertyKeys == input.PropertyKeys ||
                    this.PropertyKeys != null &&
                    input.PropertyKeys != null &&
                    this.PropertyKeys.SequenceEqual(input.PropertyKeys)
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
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
                hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                if (this.PropertyKeys != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyKeys.GetHashCode();
                }
                if (this.At != null)
                {
                    hashCode = (hashCode * 59) + this.At.GetHashCode();
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
