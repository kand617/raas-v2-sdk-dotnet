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
    public class CreateOrderRequestModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountIdentifier;
        private double amount;
        private string customerIdentifier;
        private bool sendEmail;
        private string utid;
        private string campaign;
        private string emailSubject;
        private string externalRefID;
        private string message;
        private Models.NameEmailModel recipient;
        private Models.NameEmailModel sender;
        private string notes;

        /// <summary>
        /// Account Identifier
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier 
        { 
            get 
            {
                return this.accountIdentifier; 
            } 
            set 
            {
                this.accountIdentifier = value;
                onPropertyChanged("AccountIdentifier");
            }
        }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public double Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Customer Identifier
        /// </summary>
        [JsonProperty("customerIdentifier")]
        public string CustomerIdentifier 
        { 
            get 
            {
                return this.customerIdentifier; 
            } 
            set 
            {
                this.customerIdentifier = value;
                onPropertyChanged("CustomerIdentifier");
            }
        }

        /// <summary>
        /// Send Email
        /// </summary>
        [JsonProperty("sendEmail")]
        public bool SendEmail 
        { 
            get 
            {
                return this.sendEmail; 
            } 
            set 
            {
                this.sendEmail = value;
                onPropertyChanged("SendEmail");
            }
        }

        /// <summary>
        /// UTID
        /// </summary>
        [JsonProperty("utid")]
        public string Utid 
        { 
            get 
            {
                return this.utid; 
            } 
            set 
            {
                this.utid = value;
                onPropertyChanged("Utid");
            }
        }

        /// <summary>
        /// Campaign
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign 
        { 
            get 
            {
                return this.campaign; 
            } 
            set 
            {
                this.campaign = value;
                onPropertyChanged("Campaign");
            }
        }

        /// <summary>
        /// Email Subject
        /// </summary>
        [JsonProperty("emailSubject")]
        public string EmailSubject 
        { 
            get 
            {
                return this.emailSubject; 
            } 
            set 
            {
                this.emailSubject = value;
                onPropertyChanged("EmailSubject");
            }
        }

        /// <summary>
        /// External Reference ID
        /// </summary>
        [JsonProperty("externalRefID")]
        public string ExternalRefID 
        { 
            get 
            {
                return this.externalRefID; 
            } 
            set 
            {
                this.externalRefID = value;
                onPropertyChanged("ExternalRefID");
            }
        }

        /// <summary>
        /// Email Message
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient")]
        public Models.NameEmailModel Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// Sender
        /// </summary>
        [JsonProperty("sender")]
        public Models.NameEmailModel Sender 
        { 
            get 
            {
                return this.sender; 
            } 
            set 
            {
                this.sender = value;
                onPropertyChanged("Sender");
            }
        }

        /// <summary>
        /// Notes
        /// </summary>
        [JsonProperty("notes")]
        public string Notes 
        { 
            get 
            {
                return this.notes; 
            } 
            set 
            {
                this.notes = value;
                onPropertyChanged("Notes");
            }
        }
    }
} 