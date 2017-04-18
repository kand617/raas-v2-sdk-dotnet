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
    public class ExchangeRateModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime lastModifiedDate;
        private string rewardCurrency;
        private string baseCurrency;
        private double baseFx;

        /// <summary>
        /// Last Modified
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate")]
        public DateTime LastModifiedDate 
        { 
            get 
            {
                return this.lastModifiedDate; 
            } 
            set 
            {
                this.lastModifiedDate = value;
                onPropertyChanged("LastModifiedDate");
            }
        }

        /// <summary>
        /// Reward Currency
        /// </summary>
        [JsonProperty("rewardCurrency")]
        public string RewardCurrency 
        { 
            get 
            {
                return this.rewardCurrency; 
            } 
            set 
            {
                this.rewardCurrency = value;
                onPropertyChanged("RewardCurrency");
            }
        }

        /// <summary>
        /// Base Currency
        /// </summary>
        [JsonProperty("baseCurrency")]
        public string BaseCurrency 
        { 
            get 
            {
                return this.baseCurrency; 
            } 
            set 
            {
                this.baseCurrency = value;
                onPropertyChanged("BaseCurrency");
            }
        }

        /// <summary>
        /// Exchange Rate
        /// </summary>
        [JsonProperty("baseFx")]
        public double BaseFx 
        { 
            get 
            {
                return this.baseFx; 
            } 
            set 
            {
                this.baseFx = value;
                onPropertyChanged("BaseFx");
            }
        }
    }
} 