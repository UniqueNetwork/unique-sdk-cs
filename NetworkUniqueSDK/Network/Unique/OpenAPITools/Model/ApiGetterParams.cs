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

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ApiGetterParams
    /// </summary>
    [DataContract(Name = "ApiGetterParams")]
    public partial class ApiGetterParams : IEquatable<ApiGetterParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiGetterParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiGetterParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiGetterParams" /> class.
        /// </summary>
        /// <param name="endpoint">endpoint (required).</param>
        /// <param name="module">module (required).</param>
        /// <param name="method">method (required).</param>
        public ApiGetterParams(string endpoint = default(string), string module = default(string), string method = default(string))
        {
            // to ensure "endpoint" is required (not null)
            if (endpoint == null)
            {
                throw new ArgumentNullException("endpoint is a required property for ApiGetterParams and cannot be null");
            }
            this.Endpoint = endpoint;
            // to ensure "module" is required (not null)
            if (module == null)
            {
                throw new ArgumentNullException("module is a required property for ApiGetterParams and cannot be null");
            }
            this.Module = module;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for ApiGetterParams and cannot be null");
            }
            this.Method = method;
        }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", IsRequired = true, EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name = "module", IsRequired = true, EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiGetterParams {\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as ApiGetterParams);
        }

        /// <summary>
        /// Returns true if ApiGetterParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiGetterParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiGetterParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                if (this.Module != null)
                {
                    hashCode = (hashCode * 59) + this.Module.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
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