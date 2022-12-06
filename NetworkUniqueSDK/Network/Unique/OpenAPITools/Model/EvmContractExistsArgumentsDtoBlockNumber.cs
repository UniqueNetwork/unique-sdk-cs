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
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EvmContractExistsArgumentsDtoBlockNumber
    /// </summary>
    [JsonConverter(typeof(EvmContractExistsArgumentsDtoBlockNumberJsonConverter))]
    [DataContract(Name = "EvmContractExistsArgumentsDto_blockNumber")]
    public partial class EvmContractExistsArgumentsDtoBlockNumber : AbstractOpenAPISchema, IEquatable<EvmContractExistsArgumentsDtoBlockNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvmContractExistsArgumentsDtoBlockNumber" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public EvmContractExistsArgumentsDtoBlockNumber(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvmContractExistsArgumentsDtoBlockNumber" /> class
        /// with the <see cref="decimal" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of decimal.</param>
        public EvmContractExistsArgumentsDtoBlockNumber(decimal actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(decimal))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: decimal, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `decimal`. If the actual instance is not `decimal`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of decimal</returns>
        public decimal GetDecimal()
        {
            return (decimal)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvmContractExistsArgumentsDtoBlockNumber {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, EvmContractExistsArgumentsDtoBlockNumber.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of EvmContractExistsArgumentsDtoBlockNumber
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of EvmContractExistsArgumentsDtoBlockNumber</returns>
        public static EvmContractExistsArgumentsDtoBlockNumber FromJson(string jsonString)
        {
            EvmContractExistsArgumentsDtoBlockNumber newEvmContractExistsArgumentsDtoBlockNumber = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newEvmContractExistsArgumentsDtoBlockNumber;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(decimal).GetProperty("AdditionalProperties") == null)
                {
                    newEvmContractExistsArgumentsDtoBlockNumber = new EvmContractExistsArgumentsDtoBlockNumber(JsonConvert.DeserializeObject<decimal>(jsonString, EvmContractExistsArgumentsDtoBlockNumber.SerializerSettings));
                }
                else
                {
                    newEvmContractExistsArgumentsDtoBlockNumber = new EvmContractExistsArgumentsDtoBlockNumber(JsonConvert.DeserializeObject<decimal>(jsonString, EvmContractExistsArgumentsDtoBlockNumber.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("decimal");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into decimal: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newEvmContractExistsArgumentsDtoBlockNumber = new EvmContractExistsArgumentsDtoBlockNumber(JsonConvert.DeserializeObject<string>(jsonString, EvmContractExistsArgumentsDtoBlockNumber.SerializerSettings));
                }
                else
                {
                    newEvmContractExistsArgumentsDtoBlockNumber = new EvmContractExistsArgumentsDtoBlockNumber(JsonConvert.DeserializeObject<string>(jsonString, EvmContractExistsArgumentsDtoBlockNumber.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newEvmContractExistsArgumentsDtoBlockNumber;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EvmContractExistsArgumentsDtoBlockNumber);
        }

        /// <summary>
        /// Returns true if EvmContractExistsArgumentsDtoBlockNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of EvmContractExistsArgumentsDtoBlockNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvmContractExistsArgumentsDtoBlockNumber input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for EvmContractExistsArgumentsDtoBlockNumber
    /// </summary>
    public class EvmContractExistsArgumentsDtoBlockNumberJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(EvmContractExistsArgumentsDtoBlockNumber).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return EvmContractExistsArgumentsDtoBlockNumber.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
