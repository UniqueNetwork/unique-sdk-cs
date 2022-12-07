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
    /// AttributeSchemaDto
    /// </summary>
    [DataContract(Name = "AttributeSchemaDto")]
    public partial class AttributeSchemaDto : IEquatable<AttributeSchemaDto>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 1,

            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            [EnumMember(Value = "float")]
            Float = 2,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 3,

            /// <summary>
            /// Enum Timestamp for value: timestamp
            /// </summary>
            [EnumMember(Value = "timestamp")]
            Timestamp = 4,

            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 5,

            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 6,

            /// <summary>
            /// Enum IsoDate for value: isoDate
            /// </summary>
            [EnumMember(Value = "isoDate")]
            IsoDate = 7,

            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 8,

            /// <summary>
            /// Enum ColorRgba for value: colorRgba
            /// </summary>
            [EnumMember(Value = "colorRgba")]
            ColorRgba = 9

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttributeSchemaDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSchemaDto" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="optional">optional.</param>
        /// <param name="isArray">isArray.</param>
        /// <param name="type">type (required).</param>
        /// <param name="enumValues">enumValues.</param>
        public AttributeSchemaDto(DecodedAttributeDtoName name = default(DecodedAttributeDtoName), bool optional = default(bool), bool isArray = default(bool), TypeEnum type = default(TypeEnum), Dictionary<string, AttributeSchemaDtoEnumValuesValue> enumValues = default(Dictionary<string, AttributeSchemaDtoEnumValuesValue>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AttributeSchemaDto and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Optional = optional;
            this.IsArray = isArray;
            this.EnumValues = enumValues;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public DecodedAttributeDtoName Name { get; set; }

        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

        /// <summary>
        /// Gets or Sets IsArray
        /// </summary>
        [DataMember(Name = "isArray", EmitDefaultValue = true)]
        public bool IsArray { get; set; }

        /// <summary>
        /// Gets or Sets EnumValues
        /// </summary>
        [DataMember(Name = "enumValues", EmitDefaultValue = false)]
        public Dictionary<string, AttributeSchemaDtoEnumValuesValue> EnumValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttributeSchemaDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  IsArray: ").Append(IsArray).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EnumValues: ").Append(EnumValues).Append("\n");
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
            return this.Equals(input as AttributeSchemaDto);
        }

        /// <summary>
        /// Returns true if AttributeSchemaDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeSchemaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeSchemaDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Optional == input.Optional ||
                    this.Optional.Equals(input.Optional)
                ) && 
                (
                    this.IsArray == input.IsArray ||
                    this.IsArray.Equals(input.IsArray)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.EnumValues == input.EnumValues ||
                    this.EnumValues != null &&
                    input.EnumValues != null &&
                    this.EnumValues.SequenceEqual(input.EnumValues)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Optional.GetHashCode();
                hashCode = (hashCode * 59) + this.IsArray.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.EnumValues != null)
                {
                    hashCode = (hashCode * 59) + this.EnumValues.GetHashCode();
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