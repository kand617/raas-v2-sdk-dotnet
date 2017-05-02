/*
 * RaaSV2.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TangoCard.RaaSv2;
using TangoCard.RaaSv2.Utilities;


namespace TangoCard.RaaSv2.Models
{
    public class NameEmailModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string email;
        private string firstName;
        private string lastName;

        /// <summary>
        /// Email Address
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// First Name
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Last Name
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName 
        { 
            get 
            {
                return this.lastName; 
            } 
            set 
            {
                this.lastName = value;
                onPropertyChanged("LastName");
            }
        }
    }
} 