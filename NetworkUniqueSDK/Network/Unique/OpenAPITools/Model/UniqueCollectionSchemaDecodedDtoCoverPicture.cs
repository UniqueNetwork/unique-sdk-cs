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
    /// UniqueCollectionSchemaDecodedDtoCoverPicture
    /// </summary>
    [JsonConverter(typeof(UniqueCollectionSchemaDecodedDtoCoverPictureJsonConverter))]
    [DataContract(Name = "UniqueCollectionSchemaDecodedDto_coverPicture")]
    public partial class UniqueCollectionSchemaDecodedDtoCoverPicture : AbstractOpenAPISchema, IEquatable<UniqueCollectionSchemaDecodedDtoCoverPicture>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueCollectionSchemaDecodedDtoCoverPicture" /> class
        /// with the <see cref="UniqueCollectionSchemaDecodedDtoCoverPictureOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UniqueCollectionSchemaDecodedDtoCoverPictureOneOf.</param>
        public UniqueCollectionSchemaDecodedDtoCoverPicture(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueCollectionSchemaDecodedDtoCoverPicture" /> class
        /// with the <see cref="UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1.</param>
        public UniqueCollectionSchemaDecodedDtoCoverPicture(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueCollectionSchemaDecodedDtoCoverPicture" /> class
        /// with the <see cref="UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2.</param>
        public UniqueCollectionSchemaDecodedDtoCoverPicture(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
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
                if (value.GetType() == typeof(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UniqueCollectionSchemaDecodedDtoCoverPictureOneOf, UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1, UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UniqueCollectionSchemaDecodedDtoCoverPictureOneOf`. If the actual instance is not `UniqueCollectionSchemaDecodedDtoCoverPictureOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UniqueCollectionSchemaDecodedDtoCoverPictureOneOf</returns>
        public UniqueCollectionSchemaDecodedDtoCoverPictureOneOf GetUniqueCollectionSchemaDecodedDtoCoverPictureOneOf()
        {
            return (UniqueCollectionSchemaDecodedDtoCoverPictureOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1`. If the actual instance is not `UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1</returns>
        public UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1 GetUniqueCollectionSchemaDecodedDtoCoverPictureOneOf1()
        {
            return (UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2`. If the actual instance is not `UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2</returns>
        public UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2 GetUniqueCollectionSchemaDecodedDtoCoverPictureOneOf2()
        {
            return (UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UniqueCollectionSchemaDecodedDtoCoverPicture {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UniqueCollectionSchemaDecodedDtoCoverPicture.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UniqueCollectionSchemaDecodedDtoCoverPicture
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UniqueCollectionSchemaDecodedDtoCoverPicture</returns>
        public static UniqueCollectionSchemaDecodedDtoCoverPicture FromJson(string jsonString)
        {
            UniqueCollectionSchemaDecodedDtoCoverPicture newUniqueCollectionSchemaDecodedDtoCoverPicture = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUniqueCollectionSchemaDecodedDtoCoverPicture;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newUniqueCollectionSchemaDecodedDtoCoverPicture = new UniqueCollectionSchemaDecodedDtoCoverPicture(JsonConvert.DeserializeObject<UniqueCollectionSchemaDecodedDtoCoverPictureOneOf>(jsonString, UniqueCollectionSchemaDecodedDtoCoverPicture.SerializerSettings));
                }
                else
                {
                    newUniqueCollectionSchemaDecodedDtoCoverPicture = new UniqueCollectionSchemaDecodedDtoCoverPicture(JsonConvert.DeserializeObject<UniqueCollectionSchemaDecodedDtoCoverPictureOneOf>(jsonString, UniqueCollectionSchemaDecodedDtoCoverPicture.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UniqueCollectionSchemaDecodedDtoCoverPictureOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UniqueCollectionSchemaDecodedDtoCoverPictureOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1).GetProperty("AdditionalProperties") == null)
                {
                    newUniqueCollectionSchemaDecodedDtoCoverPicture = new UniqueCollectionSchemaDecodedDtoCoverPicture(JsonConvert.DeserializeObject<UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1>(jsonString, UniqueCollectionSchemaDecodedDtoCoverPicture.SerializerSettings));
                }
                else
                {
                    newUniqueCollectionSchemaDecodedDtoCoverPicture = new UniqueCollectionSchemaDecodedDtoCoverPicture(JsonConvert.DeserializeObject<UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1>(jsonString, UniqueCollectionSchemaDecodedDtoCoverPicture.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UniqueCollectionSchemaDecodedDtoCoverPictureOneOf1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2).GetProperty("AdditionalProperties") == null)
                {
                    newUniqueCollectionSchemaDecodedDtoCoverPicture = new UniqueCollectionSchemaDecodedDtoCoverPicture(JsonConvert.DeserializeObject<UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2>(jsonString, UniqueCollectionSchemaDecodedDtoCoverPicture.SerializerSettings));
                }
                else
                {
                    newUniqueCollectionSchemaDecodedDtoCoverPicture = new UniqueCollectionSchemaDecodedDtoCoverPicture(JsonConvert.DeserializeObject<UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2>(jsonString, UniqueCollectionSchemaDecodedDtoCoverPicture.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UniqueCollectionSchemaDecodedDtoCoverPictureOneOf2: {1}", jsonString, exception.ToString()));
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
            return newUniqueCollectionSchemaDecodedDtoCoverPicture;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UniqueCollectionSchemaDecodedDtoCoverPicture);
        }

        /// <summary>
        /// Returns true if UniqueCollectionSchemaDecodedDtoCoverPicture instances are equal
        /// </summary>
        /// <param name="input">Instance of UniqueCollectionSchemaDecodedDtoCoverPicture to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UniqueCollectionSchemaDecodedDtoCoverPicture input)
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
    /// Custom JSON converter for UniqueCollectionSchemaDecodedDtoCoverPicture
    /// </summary>
    public class UniqueCollectionSchemaDecodedDtoCoverPictureJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UniqueCollectionSchemaDecodedDtoCoverPicture).GetMethod("ToJson").Invoke(value, null)));
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
                return UniqueCollectionSchemaDecodedDtoCoverPicture.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
