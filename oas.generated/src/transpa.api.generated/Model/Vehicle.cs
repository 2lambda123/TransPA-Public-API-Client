/*
 * TransPA Public API
 *
 * # This API exposes functionality in Visma TransPA. ## Authentication The API can be tested without authentication against the mock server in the **Servers** pulldown list. To test against the actual backend you have to register a user on the *Visma Developer Portal* and request access to the API along with the required scopes. The scopes required are documented under each endpoint. For more information about *Visma Developer Portal* see <https://developer.visma.com>. <br/> <br/>  Authentication uses OAuth tokens from *Visma Connect*. Authorization is done on tenant level, so one OAuth token is needed per tenant.<br/> <br/> The scope `transpaapi:api` grants basic access to the API and is required for all routes. Additional scopes might be required and are described inside each route description. <br/> ## Details All monetary amounts are in the organizations local currency unless otherwise specified. <br/> <br/> ```[Not Ready]``` This is an endpoint where development has not completed and is therefore subject to change. 
 *
 * The version of the OpenAPI document: 0.1.17
 * Contact: utveckling.transpa@visma.com
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
using OpenAPIDateConverter = transpa.api.generated.Client.OpenAPIDateConverter;

namespace transpa.api.generated.Model
{
    /// <summary>
    /// Vehicle
    /// </summary>
    [DataContract(Name = "vehicle")]
    public partial class Vehicle : IEquatable<Vehicle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Vehicle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="registrationNumber">The registrationNumber must be unique (required).</param>
        /// <param name="externalId">Currently only allows int64 as string (Was previously named VehicleNumber) (required).</param>
        /// <param name="isActive">isActive (required).</param>
        /// <param name="costDistributionCode">Currently only allows int64 as string.</param>
        /// <param name="trafficAreaId">trafficAreaId.</param>
        /// <param name="stationPlaceId">stationPlaceId.</param>
        /// <param name="vehicleGroupId">vehicleGroupId.</param>
        public Vehicle(string id = default(string), string registrationNumber = default(string), string externalId = default(string), bool isActive = default(bool), string costDistributionCode = default(string), long? trafficAreaId = default(long?), long? stationPlaceId = default(long?), long? vehicleGroupId = default(long?))
        {
            // to ensure "registrationNumber" is required (not null)
            if (registrationNumber == null) {
                throw new ArgumentNullException("registrationNumber is a required property for Vehicle and cannot be null");
            }
            this.RegistrationNumber = registrationNumber;
            // to ensure "externalId" is required (not null)
            if (externalId == null) {
                throw new ArgumentNullException("externalId is a required property for Vehicle and cannot be null");
            }
            this.ExternalId = externalId;
            this.IsActive = isActive;
            this.Id = id;
            this.CostDistributionCode = costDistributionCode;
            this.TrafficAreaId = trafficAreaId;
            this.StationPlaceId = stationPlaceId;
            this.VehicleGroupId = vehicleGroupId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The registrationNumber must be unique
        /// </summary>
        /// <value>The registrationNumber must be unique</value>
        [DataMember(Name = "registrationNumber", IsRequired = true, EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Currently only allows int64 as string (Was previously named VehicleNumber)
        /// </summary>
        /// <value>Currently only allows int64 as string (Was previously named VehicleNumber)</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Currently only allows int64 as string
        /// </summary>
        /// <value>Currently only allows int64 as string</value>
        [DataMember(Name = "costDistributionCode", EmitDefaultValue = true)]
        public string CostDistributionCode { get; set; }

        /// <summary>
        /// Gets or Sets TrafficAreaId
        /// </summary>
        [DataMember(Name = "trafficAreaId", EmitDefaultValue = true)]
        public long? TrafficAreaId { get; set; }

        /// <summary>
        /// Gets or Sets StationPlaceId
        /// </summary>
        [DataMember(Name = "stationPlaceId", EmitDefaultValue = true)]
        public long? StationPlaceId { get; set; }

        /// <summary>
        /// Gets or Sets VehicleGroupId
        /// </summary>
        [DataMember(Name = "vehicleGroupId", EmitDefaultValue = true)]
        public long? VehicleGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vehicle {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  CostDistributionCode: ").Append(CostDistributionCode).Append("\n");
            sb.Append("  TrafficAreaId: ").Append(TrafficAreaId).Append("\n");
            sb.Append("  StationPlaceId: ").Append(StationPlaceId).Append("\n");
            sb.Append("  VehicleGroupId: ").Append(VehicleGroupId).Append("\n");
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
            return this.Equals(input as Vehicle);
        }

        /// <summary>
        /// Returns true if Vehicle instances are equal
        /// </summary>
        /// <param name="input">Instance of Vehicle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vehicle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.CostDistributionCode == input.CostDistributionCode ||
                    (this.CostDistributionCode != null &&
                    this.CostDistributionCode.Equals(input.CostDistributionCode))
                ) && 
                (
                    this.TrafficAreaId == input.TrafficAreaId ||
                    (this.TrafficAreaId != null &&
                    this.TrafficAreaId.Equals(input.TrafficAreaId))
                ) && 
                (
                    this.StationPlaceId == input.StationPlaceId ||
                    (this.StationPlaceId != null &&
                    this.StationPlaceId.Equals(input.StationPlaceId))
                ) && 
                (
                    this.VehicleGroupId == input.VehicleGroupId ||
                    (this.VehicleGroupId != null &&
                    this.VehicleGroupId.Equals(input.VehicleGroupId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.CostDistributionCode != null)
                    hashCode = hashCode * 59 + this.CostDistributionCode.GetHashCode();
                if (this.TrafficAreaId != null)
                    hashCode = hashCode * 59 + this.TrafficAreaId.GetHashCode();
                if (this.StationPlaceId != null)
                    hashCode = hashCode * 59 + this.StationPlaceId.GetHashCode();
                if (this.VehicleGroupId != null)
                    hashCode = hashCode * 59 + this.VehicleGroupId.GetHashCode();
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
