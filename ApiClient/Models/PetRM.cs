/* 
 * API for Pet Project
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace PetApiClient
{
    /// <summary>
    /// PetRM
    /// </summary>
    [DataContract]
    public partial class PetRM :  IEquatable<PetRM>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetRM" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PetRM() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PetRM" /> class.
        /// </summary>
        /// <param name="OwnerId">OwnerId (required).</param>
        /// <param name="Firstname">Firstname (required).</param>
        /// <param name="Lastname">Lastname.</param>
        /// <param name="Birthday">Birthday (required).</param>
        /// <param name="Breed">Breed.</param>
        /// <param name="Color">Color.</param>
        public PetRM(int? OwnerId = default(int?), string Firstname = default(string), string Lastname = default(string), DateTime? Birthday = default(DateTime?), string Breed = default(string), string Color = default(string))
        {
            // to ensure "OwnerId" is required (not null)
            if (OwnerId == null)
            {
                throw new InvalidDataException("OwnerId is a required property for PetRM and cannot be null");
            }
            else
            {
                this.OwnerId = OwnerId;
            }
            // to ensure "Firstname" is required (not null)
            if (Firstname == null)
            {
                throw new InvalidDataException("Firstname is a required property for PetRM and cannot be null");
            }
            else
            {
                this.Firstname = Firstname;
            }
            // to ensure "Birthday" is required (not null)
            if (Birthday == null)
            {
                throw new InvalidDataException("Birthday is a required property for PetRM and cannot be null");
            }
            else
            {
                this.Birthday = Birthday;
            }
            this.Lastname = Lastname;
            this.Breed = Breed;
            this.Color = Color;
        }
        
        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name="OwnerId", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }
        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="Firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }
        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="Lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }
        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name="Birthday", EmitDefaultValue=false)]
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// Gets or Sets Breed
        /// </summary>
        [DataMember(Name="Breed", EmitDefaultValue=false)]
        public string Breed { get; set; }
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PetRM {\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Breed: ").Append(Breed).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PetRM);
        }

        /// <summary>
        /// Returns true if PetRM instances are equal
        /// </summary>
        /// <param name="other">Instance of PetRM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PetRM other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.Birthday == other.Birthday ||
                    this.Birthday != null &&
                    this.Birthday.Equals(other.Birthday)
                ) && 
                (
                    this.Breed == other.Breed ||
                    this.Breed != null &&
                    this.Breed.Equals(other.Breed)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.Firstname != null)
                    hash = hash * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hash = hash * 59 + this.Lastname.GetHashCode();
                if (this.Birthday != null)
                    hash = hash * 59 + this.Birthday.GetHashCode();
                if (this.Breed != null)
                    hash = hash * 59 + this.Breed.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                return hash;
            }
        }

    }

}
