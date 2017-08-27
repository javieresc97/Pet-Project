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


namespace PetApiClient{
    /// <summary>
    /// Pet
    /// </summary>
    [DataContract]
    public partial class Pet :  IEquatable<Pet>
    {        
        /// <summary>
        /// Gets or Sets IdPet
        /// </summary>
        [DataMember(Name="idPet", EmitDefaultValue=false)]
        public int? IdPet { get; set; }
        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }
        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        public string Fullname
        {
            get
            {
                return $"{Firstname} {Lastname}".Trim();
            }
        }

        /// <summary>
        /// Gets or Sets IdOwner
        /// </summary>
        [DataMember(Name="idOwner", EmitDefaultValue=false)]
        public int? IdOwner { get; set; }
        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name="birthday", EmitDefaultValue=false)]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Gets or Sets Breed
        /// </summary>
        [DataMember(Name="breed", EmitDefaultValue=false)]
        public string Breed { get; set; }
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// Gets or Sets Diseases
        /// </summary>
        [DataMember(Name="Diseases", EmitDefaultValue=false)]
        public List<Disease> Diseases { get; set; }
        /// <summary>
        /// Gets or Sets Vaccinations
        /// </summary>
        [DataMember(Name="Vaccinations", EmitDefaultValue=false)]
        public List<Vaccination> Vaccinations { get; set; }
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public Owner Owner { get; set; }

        [JsonIgnore]
        public IEnumerable<ClinicHistory> Histories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pet {\n");
            sb.Append("  IdPet: ").Append(IdPet).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  IdOwner: ").Append(IdOwner).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Breed: ").Append(Breed).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Diseases: ").Append(Diseases).Append("\n");
            sb.Append("  Vaccinations: ").Append(Vaccinations).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(obj as Pet);
        }

        /// <summary>
        /// Returns true if Pet instances are equal
        /// </summary>
        /// <param name="other">Instance of Pet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPet == other.IdPet ||
                    this.IdPet != null &&
                    this.IdPet.Equals(other.IdPet)
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
                    this.IdOwner == other.IdOwner ||
                    this.IdOwner != null &&
                    this.IdOwner.Equals(other.IdOwner)
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
                ) && 
                (
                    this.Diseases == other.Diseases ||
                    this.Diseases != null &&
                    this.Diseases.SequenceEqual(other.Diseases)
                ) && 
                (
                    this.Vaccinations == other.Vaccinations ||
                    this.Vaccinations != null &&
                    this.Vaccinations.SequenceEqual(other.Vaccinations)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
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
                if (this.IdPet != null)
                    hash = hash * 59 + this.IdPet.GetHashCode();
                if (this.Firstname != null)
                    hash = hash * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hash = hash * 59 + this.Lastname.GetHashCode();
                if (this.IdOwner != null)
                    hash = hash * 59 + this.IdOwner.GetHashCode();
                if (this.Birthday != null)
                    hash = hash * 59 + this.Birthday.GetHashCode();
                if (this.Breed != null)
                    hash = hash * 59 + this.Breed.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Diseases != null)
                    hash = hash * 59 + this.Diseases.GetHashCode();
                if (this.Vaccinations != null)
                    hash = hash * 59 + this.Vaccinations.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                return hash;
            }
        }

    }

}
