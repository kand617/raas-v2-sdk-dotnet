/*
 * RaaSV2.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using TangoCard.RaaSv2.Controllers;
using TangoCard.RaaSv2.Http.Client;

namespace TangoCard.RaaSv2
{
    public partial class RaaSV2Client
    {

        /// <summary>
        /// Singleton access to Accounts controller
        /// </summary>
        public AccountsController Accounts
        {
            get
            {
                return AccountsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Orders controller
        /// </summary>
        public OrdersController Orders
        {
            get
            {
                return OrdersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Catalog controller
        /// </summary>
        public CatalogController Catalog
        {
            get
            {
                return CatalogController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ExchangeRates controller
        /// </summary>
        public ExchangeRatesController ExchangeRates
        {
            get
            {
                return ExchangeRatesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Status controller
        /// </summary>
        public StatusController Status
        {
            get
            {
                return StatusController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Customers controller
        /// </summary>
        public CustomersController Customers
        {
            get
            {
                return CustomersController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public RaaSV2Client() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public RaaSV2Client(string platformName = "QAPlatform2", string platformKey = "apYPfT6HNONpDRUj3CLGWYt7gvIHONpDRUYPfT6Hj")
        {
            Configuration.PlatformName = platformName;
            Configuration.PlatformKey = platformKey;
        }
    }
}