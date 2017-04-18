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
    public class GetOrdersResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.PageModel page;
        private List<Models.OrderModel> orders;

        /// <summary>
        /// Pagination information
        /// </summary>
        [JsonProperty("page")]
        public Models.PageModel Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }

        /// <summary>
        /// An array of orders
        /// </summary>
        [JsonProperty("orders")]
        public List<Models.OrderModel> Orders 
        { 
            get 
            {
                return this.orders; 
            } 
            set 
            {
                this.orders = value;
                onPropertyChanged("Orders");
            }
        }
    }
} 