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
using System.Reflection;

namespace Network.Unique.API.Model
{
    /// <summary>
    /// UnnestTokenDefaultResponse
    /// </summary>
    [JsonConverter(typeof(UnnestTokenDefaultResponseJsonConverter))]
    [DataContract(Name = "unnestToken_default_response")]
    public partial class UnnestTokenDefaultResponse : AbstractOpenAPISchema, IEquatable<UnnestTokenDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenDefaultResponse" /> class
        /// with the <see cref="UnsignedTxPayloadResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnsignedTxPayloadResponse.</param>
        public UnnestTokenDefaultResponse(UnsignedTxPayloadResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenDefaultResponse" /> class
        /// with the <see cref="SignResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SignResponse.</param>
        public UnnestTokenDefaultResponse(SignResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenDefaultResponse" /> class
        /// with the <see cref="SubmitResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubmitResponse.</param>
        public UnnestTokenDefaultResponse(SubmitResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenDefaultResponse" /> class
        /// with the <see cref="UnnestTokenResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnnestTokenResponse.</param>
        public UnnestTokenDefaultResponse(UnnestTokenResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenDefaultResponse" /> class
        /// with the <see cref="BuildBatchPayloadsResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BuildBatchPayloadsResponse.</param>
        public UnnestTokenDefaultResponse(BuildBatchPayloadsResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnnestTokenDefaultResponse" /> class
        /// with the <see cref="FeeBodyResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FeeBodyResponse.</param>
        public UnnestTokenDefaultResponse(FeeBodyResponse actualInstance)
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
                if (value.GetType() == typeof(BuildBatchPayloadsResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FeeBodyResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SignResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SubmitResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UnnestTokenResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UnsignedTxPayloadResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BuildBatchPayloadsResponse, FeeBodyResponse, SignResponse, SubmitResponse, UnnestTokenResponse, UnsignedTxPayloadResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UnsignedTxPayloadResponse`. If the actual instance is not `UnsignedTxPayloadResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UnsignedTxPayloadResponse</returns>
        public UnsignedTxPayloadResponse GetUnsignedTxPayloadResponse()
        {
            return (UnsignedTxPayloadResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SignResponse`. If the actual instance is not `SignResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SignResponse</returns>
        public SignResponse GetSignResponse()
        {
            return (SignResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SubmitResponse`. If the actual instance is not `SubmitResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubmitResponse</returns>
        public SubmitResponse GetSubmitResponse()
        {
            return (SubmitResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UnnestTokenResponse`. If the actual instance is not `UnnestTokenResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UnnestTokenResponse</returns>
        public UnnestTokenResponse GetUnnestTokenResponse()
        {
            return (UnnestTokenResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `BuildBatchPayloadsResponse`. If the actual instance is not `BuildBatchPayloadsResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BuildBatchPayloadsResponse</returns>
        public BuildBatchPayloadsResponse GetBuildBatchPayloadsResponse()
        {
            return (BuildBatchPayloadsResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `FeeBodyResponse`. If the actual instance is not `FeeBodyResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of FeeBodyResponse</returns>
        public FeeBodyResponse GetFeeBodyResponse()
        {
            return (FeeBodyResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnnestTokenDefaultResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UnnestTokenDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UnnestTokenDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UnnestTokenDefaultResponse</returns>
        public static UnnestTokenDefaultResponse FromJson(string jsonString)
        {
            UnnestTokenDefaultResponse newUnnestTokenDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUnnestTokenDefaultResponse;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BuildBatchPayloadsResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<BuildBatchPayloadsResponse>(jsonString, UnnestTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<BuildBatchPayloadsResponse>(jsonString, UnnestTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("BuildBatchPayloadsResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BuildBatchPayloadsResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FeeBodyResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<FeeBodyResponse>(jsonString, UnnestTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<FeeBodyResponse>(jsonString, UnnestTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FeeBodyResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FeeBodyResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SignResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<SignResponse>(jsonString, UnnestTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<SignResponse>(jsonString, UnnestTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SignResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SignResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubmitResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<SubmitResponse>(jsonString, UnnestTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<SubmitResponse>(jsonString, UnnestTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubmitResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubmitResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UnnestTokenResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<UnnestTokenResponse>(jsonString, UnnestTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<UnnestTokenResponse>(jsonString, UnnestTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UnnestTokenResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UnnestTokenResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UnsignedTxPayloadResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<UnsignedTxPayloadResponse>(jsonString, UnnestTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newUnnestTokenDefaultResponse = new UnnestTokenDefaultResponse(JsonConvert.DeserializeObject<UnsignedTxPayloadResponse>(jsonString, UnnestTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UnsignedTxPayloadResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UnsignedTxPayloadResponse: {1}", jsonString, exception.ToString()));
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
            return newUnnestTokenDefaultResponse;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnnestTokenDefaultResponse);
        }

        /// <summary>
        /// Returns true if UnnestTokenDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UnnestTokenDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnnestTokenDefaultResponse input)
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
    /// Custom JSON converter for UnnestTokenDefaultResponse
    /// </summary>
    public class UnnestTokenDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UnnestTokenDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return UnnestTokenDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
