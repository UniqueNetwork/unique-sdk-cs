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
    /// CreateNewTokenMutationRequest
    /// </summary>
    [JsonConverter(typeof(CreateNewTokenMutationRequestJsonConverter))]
    [DataContract(Name = "createNewTokenMutation_request")]
    public partial class CreateNewTokenMutationRequest : AbstractOpenAPISchema, IEquatable<CreateNewTokenMutationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewTokenMutationRequest" /> class
        /// with the <see cref="CreateTokenBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CreateTokenBody.</param>
        public CreateNewTokenMutationRequest(CreateTokenBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewTokenMutationRequest" /> class
        /// with the <see cref="List{CreateTokenBody}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;CreateTokenBody&gt;.</param>
        public CreateNewTokenMutationRequest(List<CreateTokenBody> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewTokenMutationRequest" /> class
        /// with the <see cref="UnsignedTxPayloadBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UnsignedTxPayloadBody.</param>
        public CreateNewTokenMutationRequest(UnsignedTxPayloadBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewTokenMutationRequest" /> class
        /// with the <see cref="SubmitTxBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubmitTxBody.</param>
        public CreateNewTokenMutationRequest(SubmitTxBody actualInstance)
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
                if (value.GetType() == typeof(CreateTokenBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(List<CreateTokenBody>))
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
                    throw new ArgumentException("Invalid instance found. Must be the following types: CreateTokenBody, List<CreateTokenBody>, SubmitTxBody, UnsignedTxPayloadBody");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CreateTokenBody`. If the actual instance is not `CreateTokenBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CreateTokenBody</returns>
        public CreateTokenBody GetCreateTokenBody()
        {
            return (CreateTokenBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;CreateTokenBody&gt;`. If the actual instance is not `List&lt;CreateTokenBody&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;CreateTokenBody&gt;</returns>
        public List<CreateTokenBody> GetList()
        {
            return (List<CreateTokenBody>)this.ActualInstance;
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
            sb.Append("class CreateNewTokenMutationRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateNewTokenMutationRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateNewTokenMutationRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateNewTokenMutationRequest</returns>
        public static CreateNewTokenMutationRequest FromJson(string jsonString)
        {
            CreateNewTokenMutationRequest newCreateNewTokenMutationRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateNewTokenMutationRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CreateTokenBody).GetProperty("AdditionalProperties") == null)
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<CreateTokenBody>(jsonString, CreateNewTokenMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<CreateTokenBody>(jsonString, CreateNewTokenMutationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CreateTokenBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CreateTokenBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<CreateTokenBody>).GetProperty("AdditionalProperties") == null)
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<List<CreateTokenBody>>(jsonString, CreateNewTokenMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<List<CreateTokenBody>>(jsonString, CreateNewTokenMutationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<CreateTokenBody>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<CreateTokenBody>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubmitTxBody).GetProperty("AdditionalProperties") == null)
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<SubmitTxBody>(jsonString, CreateNewTokenMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<SubmitTxBody>(jsonString, CreateNewTokenMutationRequest.AdditionalPropertiesSerializerSettings));
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
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<UnsignedTxPayloadBody>(jsonString, CreateNewTokenMutationRequest.SerializerSettings));
                }
                else
                {
                    newCreateNewTokenMutationRequest = new CreateNewTokenMutationRequest(JsonConvert.DeserializeObject<UnsignedTxPayloadBody>(jsonString, CreateNewTokenMutationRequest.AdditionalPropertiesSerializerSettings));
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
            return newCreateNewTokenMutationRequest;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNewTokenMutationRequest);
        }

        /// <summary>
        /// Returns true if CreateNewTokenMutationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNewTokenMutationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNewTokenMutationRequest input)
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
    /// Custom JSON converter for CreateNewTokenMutationRequest
    /// </summary>
    public class CreateNewTokenMutationRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateNewTokenMutationRequest).GetMethod("ToJson").Invoke(value, null)));
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
                return CreateNewTokenMutationRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
