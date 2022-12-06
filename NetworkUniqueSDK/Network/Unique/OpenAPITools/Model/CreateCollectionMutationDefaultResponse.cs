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
    /// CreateCollectionMutationDefaultResponse
    /// </summary>
    [JsonConverter(typeof(CreateCollectionMutationDefaultResponseJsonConverter))]
    [DataContract(Name = "createCollectionMutation_default_response")]
    public partial class CreateCollectionMutationDefaultResponse : AbstractOpenAPISchema, IEquatable<CreateCollectionMutationDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationDefaultResponse" /> class
        /// with the <see cref="UnsignedTxPayloadResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnsignedTxPayloadResponse.</param>
        public CreateCollectionMutationDefaultResponse(UnsignedTxPayloadResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationDefaultResponse" /> class
        /// with the <see cref="SignResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SignResponse.</param>
        public CreateCollectionMutationDefaultResponse(SignResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationDefaultResponse" /> class
        /// with the <see cref="SubmitResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubmitResponse.</param>
        public CreateCollectionMutationDefaultResponse(SubmitResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationDefaultResponse" /> class
        /// with the <see cref="CreateCollectionResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CreateCollectionResponse.</param>
        public CreateCollectionMutationDefaultResponse(CreateCollectionResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationDefaultResponse" /> class
        /// with the <see cref="BuildBatchPayloadsResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BuildBatchPayloadsResponse.</param>
        public CreateCollectionMutationDefaultResponse(BuildBatchPayloadsResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationDefaultResponse" /> class
        /// with the <see cref="FeeBodyResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FeeBodyResponse.</param>
        public CreateCollectionMutationDefaultResponse(FeeBodyResponse actualInstance)
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
                else if (value.GetType() == typeof(CreateCollectionResponse))
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
                else if (value.GetType() == typeof(UnsignedTxPayloadResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BuildBatchPayloadsResponse, CreateCollectionResponse, FeeBodyResponse, SignResponse, SubmitResponse, UnsignedTxPayloadResponse");
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
        /// Get the actual instance of `CreateCollectionResponse`. If the actual instance is not `CreateCollectionResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CreateCollectionResponse</returns>
        public CreateCollectionResponse GetCreateCollectionResponse()
        {
            return (CreateCollectionResponse)this.ActualInstance;
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
            sb.Append("class CreateCollectionMutationDefaultResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateCollectionMutationDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateCollectionMutationDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateCollectionMutationDefaultResponse</returns>
        public static CreateCollectionMutationDefaultResponse FromJson(string jsonString)
        {
            CreateCollectionMutationDefaultResponse newCreateCollectionMutationDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateCollectionMutationDefaultResponse;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BuildBatchPayloadsResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<BuildBatchPayloadsResponse>(jsonString, CreateCollectionMutationDefaultResponse.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<BuildBatchPayloadsResponse>(jsonString, CreateCollectionMutationDefaultResponse.AdditionalPropertiesSerializerSettings));
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
                if (typeof(CreateCollectionResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<CreateCollectionResponse>(jsonString, CreateCollectionMutationDefaultResponse.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<CreateCollectionResponse>(jsonString, CreateCollectionMutationDefaultResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CreateCollectionResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CreateCollectionResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FeeBodyResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<FeeBodyResponse>(jsonString, CreateCollectionMutationDefaultResponse.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<FeeBodyResponse>(jsonString, CreateCollectionMutationDefaultResponse.AdditionalPropertiesSerializerSettings));
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
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<SignResponse>(jsonString, CreateCollectionMutationDefaultResponse.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<SignResponse>(jsonString, CreateCollectionMutationDefaultResponse.AdditionalPropertiesSerializerSettings));
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
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<SubmitResponse>(jsonString, CreateCollectionMutationDefaultResponse.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<SubmitResponse>(jsonString, CreateCollectionMutationDefaultResponse.AdditionalPropertiesSerializerSettings));
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
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<UnsignedTxPayloadResponse>(jsonString, CreateCollectionMutationDefaultResponse.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationDefaultResponse = new CreateCollectionMutationDefaultResponse(JsonConvert.DeserializeObject<UnsignedTxPayloadResponse>(jsonString, CreateCollectionMutationDefaultResponse.AdditionalPropertiesSerializerSettings));
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
            return newCreateCollectionMutationDefaultResponse;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCollectionMutationDefaultResponse);
        }

        /// <summary>
        /// Returns true if CreateCollectionMutationDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollectionMutationDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollectionMutationDefaultResponse input)
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
    /// Custom JSON converter for CreateCollectionMutationDefaultResponse
    /// </summary>
    public class CreateCollectionMutationDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateCollectionMutationDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return CreateCollectionMutationDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
