/*
 * RaaSV2.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using TangoCard.RaaSv2;
using TangoCard.RaaSv2.Utilities;
using TangoCard.RaaSv2.Http.Client;
using TangoCard.RaaSv2.Http.Response;
using TangoCard.RaaSv2.Exceptions;

namespace TangoCard.RaaSv2.Controllers
{
    public partial class BaseController
    {
        #region shared http client instance
        private static object syncObject = new object();
        private static IHttpClient clientInstance = null;

        public static IHttpClient ClientInstance
        {
            get
            {
                lock(syncObject)
                {
                    if(null == clientInstance)
                    {
                        clientInstance = new UnirestClient()
;
                        clientInstance.setTimeout(TimeSpan.FromMilliseconds(15000));
                    }
                    return clientInstance;
                }
            }
            set
            {
                lock (syncObject)
                {
                    if (value is IHttpClient)
                    {
                        clientInstance = value;
                    }
                }
            }
        }
        #endregion shared http client instance

        internal ArrayDeserialization ArrayDeserializationFormat = ArrayDeserialization.Indexed;
        internal static char ParameterSeparator = '&';

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="_response">The response recieved</param>
        /// <param name="_context">Context of the request and the recieved response</param>
        internal void ValidateResponse(HttpResponse _response, HttpContext _context)
        {
            if (_response.StatusCode == 400)
                throw new RaaS4xxException(@"Bad Request", _context);

            if (_response.StatusCode == 401)
                throw new RaaSGenericException(@"Unauthorized - Invalid Credentials", _context);

            if (_response.StatusCode == 403)
                throw new RaaS4xxException(@"Forbidden", _context);

            if (_response.StatusCode == 404)
                throw new RaaSGenericException(@"Not Found", _context);

            if (_response.StatusCode == 500)
                throw new RaaS5xxException(@"Internal Server Error - Retry Later", _context);

            if (_response.StatusCode == 503)
                throw new RaaS5xxException(@"Service Unavailable - Retry Later", _context);

            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new RaaSGenericException(@"API Error", _context);

        }
    }
} 