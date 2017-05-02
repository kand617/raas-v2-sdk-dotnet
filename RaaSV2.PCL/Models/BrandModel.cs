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
    public class BrandModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string brandKey;
        private string brandName;
        private string disclaimer;
        private string description;
        private string shortDescription;
        private string terms;
        private DateTime createdDate;
        private DateTime lastUpdateDate;
        private Dictionary<string, string> imageUrls;
        private string status;
        private List<Models.ItemModel> items;

        /// <summary>
        /// Brand Key
        /// </summary>
        [JsonProperty("brandKey")]
        public string BrandKey 
        { 
            get 
            {
                return this.brandKey; 
            } 
            set 
            {
                this.brandKey = value;
                onPropertyChanged("BrandKey");
            }
        }

        /// <summary>
        /// Brand Name
        /// </summary>
        [JsonProperty("brandName")]
        public string BrandName 
        { 
            get 
            {
                return this.brandName; 
            } 
            set 
            {
                this.brandName = value;
                onPropertyChanged("BrandName");
            }
        }

        /// <summary>
        /// Disclaimer
        /// </summary>
        [JsonProperty("disclaimer")]
        public string Disclaimer 
        { 
            get 
            {
                return this.disclaimer; 
            } 
            set 
            {
                this.disclaimer = value;
                onPropertyChanged("Disclaimer");
            }
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Short Description
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription 
        { 
            get 
            {
                return this.shortDescription; 
            } 
            set 
            {
                this.shortDescription = value;
                onPropertyChanged("ShortDescription");
            }
        }

        /// <summary>
        /// Terms
        /// </summary>
        [JsonProperty("terms")]
        public string Terms 
        { 
            get 
            {
                return this.terms; 
            } 
            set 
            {
                this.terms = value;
                onPropertyChanged("Terms");
            }
        }

        /// <summary>
        /// Date Created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate")]
        public DateTime CreatedDate 
        { 
            get 
            {
                return this.createdDate; 
            } 
            set 
            {
                this.createdDate = value;
                onPropertyChanged("CreatedDate");
            }
        }

        /// <summary>
        /// Last Updated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdateDate")]
        public DateTime LastUpdateDate 
        { 
            get 
            {
                return this.lastUpdateDate; 
            } 
            set 
            {
                this.lastUpdateDate = value;
                onPropertyChanged("LastUpdateDate");
            }
        }

        /// <summary>
        /// Image URLs
        /// </summary>
        [JsonProperty("imageUrls")]
        public Dictionary<string, string> ImageUrls 
        { 
            get 
            {
                return this.imageUrls; 
            } 
            set 
            {
                this.imageUrls = value;
                onPropertyChanged("ImageUrls");
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.ItemModel> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }
    }
} 