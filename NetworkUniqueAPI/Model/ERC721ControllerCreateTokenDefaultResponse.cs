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
    /// ERC721ControllerCreateTokenDefaultResponse
    /// </summary>
    [JsonConverter(typeof(ERC721ControllerCreateTokenDefaultResponseJsonConverter))]
    [DataContract(Name = "ERC721Controller_createToken_default_response")]
    public partial class ERC721ControllerCreateTokenDefaultResponse : AbstractOpenAPISchema, IEquatable<ERC721ControllerCreateTokenDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ERC721ControllerCreateTokenDefaultResponse" /> class
        /// with the <see cref="UnsignedTxPayloadResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnsignedTxPayloadResponse.</param>
        public ERC721ControllerCreateTokenDefaultResponse(UnsignedTxPayloadResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ERC721ControllerCreateTokenDefaultResponse" /> class
        /// with the <see cref="SignResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SignResponse.</param>
        public ERC721ControllerCreateTokenDefaultResponse(SignResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ERC721ControllerCreateTokenDefaultResponse" /> class
        /// with the <see cref="SubmitResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubmitResponse.</param>
        public ERC721ControllerCreateTokenDefaultResponse(SubmitResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ERC721ControllerCreateTokenDefaultResponse" /> class
        /// with the <see cref="CreateERC721TokenResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CreateERC721TokenResponse.</param>
        public ERC721ControllerCreateTokenDefaultResponse(CreateERC721TokenResponse actualInstance)
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
                if (value.GetType() == typeof(CreateERC721TokenResponse))
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
                else if (value.GetType() == typeof(UnsignedTxPayloadResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CreateERC721TokenResponse, SignResponse, SubmitResponse, UnsignedTxPayloadResponse");
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
        /// Get the actual instance of `CreateERC721TokenResponse`. If the actual instance is not `CreateERC721TokenResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CreateERC721TokenResponse</returns>
        public CreateERC721TokenResponse GetCreateERC721TokenResponse()
        {
            return (CreateERC721TokenResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ERC721ControllerCreateTokenDefaultResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ERC721ControllerCreateTokenDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ERC721ControllerCreateTokenDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ERC721ControllerCreateTokenDefaultResponse</returns>
        public static ERC721ControllerCreateTokenDefaultResponse FromJson(string jsonString)
        {
            ERC721ControllerCreateTokenDefaultResponse newERC721ControllerCreateTokenDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newERC721ControllerCreateTokenDefaultResponse;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CreateERC721TokenResponse).GetProperty("AdditionalProperties") == null)
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<CreateERC721TokenResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<CreateERC721TokenResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CreateERC721TokenResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CreateERC721TokenResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SignResponse).GetProperty("AdditionalProperties") == null)
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<SignResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<SignResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
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
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<SubmitResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<SubmitResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
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
                if (typeof(UnsignedTxPayloadResponse).GetProperty("AdditionalProperties") == null)
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<UnsignedTxPayloadResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.SerializerSettings));
                }
                else
                {
                    newERC721ControllerCreateTokenDefaultResponse = new ERC721ControllerCreateTokenDefaultResponse(JsonConvert.DeserializeObject<UnsignedTxPayloadResponse>(jsonString, ERC721ControllerCreateTokenDefaultResponse.AdditionalPropertiesSerializerSettings));
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
            return newERC721ControllerCreateTokenDefaultResponse;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ERC721ControllerCreateTokenDefaultResponse);
        }

        /// <summary>
        /// Returns true if ERC721ControllerCreateTokenDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ERC721ControllerCreateTokenDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ERC721ControllerCreateTokenDefaultResponse input)
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
    /// Custom JSON converter for ERC721ControllerCreateTokenDefaultResponse
    /// </summary>
    public class ERC721ControllerCreateTokenDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ERC721ControllerCreateTokenDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return ERC721ControllerCreateTokenDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
