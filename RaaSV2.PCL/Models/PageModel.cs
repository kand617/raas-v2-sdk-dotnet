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
    public class PageModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int number;
        private int elementsPerBlock;
        private int resultCount;
        private int totalCount;

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("number")]
        public int Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// Elements per page
        /// </summary>
        [JsonProperty("elementsPerBlock")]
        public int ElementsPerBlock 
        { 
            get 
            {
                return this.elementsPerBlock; 
            } 
            set 
            {
                this.elementsPerBlock = value;
                onPropertyChanged("ElementsPerBlock");
            }
        }

        /// <summary>
        /// Result Count
        /// </summary>
        [JsonProperty("resultCount")]
        public int ResultCount 
        { 
            get 
            {
                return this.resultCount; 
            } 
            set 
            {
                this.resultCount = value;
                onPropertyChanged("ResultCount");
            }
        }

        /// <summary>
        /// Total Count
        /// </summary>
        [JsonProperty("totalCount")]
        public int TotalCount 
        { 
            get 
            {
                return this.totalCount; 
            } 
            set 
            {
                this.totalCount = value;
                onPropertyChanged("TotalCount");
            }
        }
    }
} 