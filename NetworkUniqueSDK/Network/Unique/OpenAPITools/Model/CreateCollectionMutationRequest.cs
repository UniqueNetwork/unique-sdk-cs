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
    /// CreateCollectionMutationRequest
    /// </summary>
    [JsonConverter(typeof(CreateCollectionMutationRequestJsonConverter))]
    [DataContract(Name = "createCollectionMutation_request")]
    public partial class CreateCollectionMutationRequest : AbstractOpenAPISchema, IEquatable<CreateCollectionMutationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationRequest" /> class
        /// with the <see cref="CreateCollectionBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CreateCollectionBody.</param>
        public CreateCollectionMutationRequest(CreateCollectionBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationRequest" /> class
        /// with the <see cref="List{CreateCollectionBody}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;CreateCollectionBody&gt;.</param>
        public CreateCollectionMutationRequest(List<CreateCollectionBody> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationRequest" /> class
        /// with the <see cref="UnsignedTxPayloadBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnsignedTxPayloadBody.</param>
        public CreateCollectionMutationRequest(UnsignedTxPayloadBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionMutationRequest" /> class
        /// with the <see cref="SubmitTxBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubmitTxBody.</param>
        public CreateCollectionMutationRequest(SubmitTxBody actualInstance)
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
                if (value.GetType() == typeof(CreateCollectionBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(List<CreateCollectionBody>))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SubmitTxBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UnsignedTxPayloadBody))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CreateCollectionBody, List<CreateCollectionBody>, SubmitTxBody, UnsignedTxPayloadBody");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CreateCollectionBody`. If the actual instance is not `CreateCollectionBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CreateCollectionBody</returns>
        public CreateCollectionBody GetCreateCollectionBody()
        {
            return (CreateCollectionBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;CreateCollectionBody&gt;`. If the actual instance is not `List&lt;CreateCollectionBody&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;CreateCollectionBody&gt;</returns>
        public List<CreateCollectionBody> GetList()
        {
            return (List<CreateCollectionBody>)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UnsignedTxPayloadBody`. If the actual instance is not `UnsignedTxPayloadBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UnsignedTxPayloadBody</returns>
        public UnsignedTxPayloadBody GetUnsignedTxPayloadBody()
        {
            return (UnsignedTxPayloadBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SubmitTxBody`. If the actual instance is not `SubmitTxBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubmitTxBody</returns>
        public SubmitTxBody GetSubmitTxBody()
        {
            return (SubmitTxBody)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollectionMutationRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateCollectionMutationRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateCollectionMutationRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateCollectionMutationRequest</returns>
        public static CreateCollectionMutationRequest FromJson(string jsonString)
        {
            CreateCollectionMutationRequest newCreateCollectionMutationRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateCollectionMutationRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CreateCollectionBody).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<CreateCollectionBody>(jsonString, CreateCollectionMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<CreateCollectionBody>(jsonString, CreateCollectionMutationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CreateCollectionBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CreateCollectionBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<CreateCollectionBody>).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<List<CreateCollectionBody>>(jsonString, CreateCollectionMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<List<CreateCollectionBody>>(jsonString, CreateCollectionMutationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<CreateCollectionBody>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<CreateCollectionBody>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubmitTxBody).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<SubmitTxBody>(jsonString, CreateCollectionMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<SubmitTxBody>(jsonString, CreateCollectionMutationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubmitTxBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubmitTxBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UnsignedTxPayloadBody).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<UnsignedTxPayloadBody>(jsonString, CreateCollectionMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateCollectionMutationRequest = new CreateCollectionMutationRequest(JsonConvert.DeserializeObject<UnsignedTxPayloadBody>(jsonString, CreateCollectionMutationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UnsignedTxPayloadBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UnsignedTxPayloadBody: {1}", jsonString, exception.ToString()));
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
            return newCreateCollectionMutationRequest;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCollectionMutationRequest);
        }

        /// <summary>
        /// Returns true if CreateCollectionMutationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollectionMutationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollectionMutationRequest input)
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
    /// Custom JSON converter for CreateCollectionMutationRequest
    /// </summary>
    public class CreateCollectionMutationRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateCollectionMutationRequest).GetMethod("ToJson").Invoke(value, null)));
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
                return CreateCollectionMutationRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
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