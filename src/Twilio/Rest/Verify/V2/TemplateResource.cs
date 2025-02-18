/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// TemplateResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Verify.V2
{

    public class TemplateResource : Resource
    {
        private static Request BuildReadRequest(ReadTemplateOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Templates",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// List all the available templates for a given Account.
        /// </summary>
        /// <param name="options"> Read Template parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Template </returns>
        public static ResourceSet<TemplateResource> Read(ReadTemplateOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<TemplateResource>.FromJson("templates", response.Content);
            return new ResourceSet<TemplateResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// List all the available templates for a given Account.
        /// </summary>
        /// <param name="options"> Read Template parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Template </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TemplateResource>> ReadAsync(ReadTemplateOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TemplateResource>.FromJson("templates", response.Content);
            return new ResourceSet<TemplateResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// List all the available templates for a given Account.
        /// </summary>
        /// <param name="friendlyName"> Filter templates using friendly name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Template </returns>
        public static ResourceSet<TemplateResource> Read(string friendlyName = null,
                                                         int? pageSize = null,
                                                         long? limit = null,
                                                         ITwilioRestClient client = null)
        {
            var options = new ReadTemplateOptions(){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// List all the available templates for a given Account.
        /// </summary>
        /// <param name="friendlyName"> Filter templates using friendly name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Template </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TemplateResource>> ReadAsync(string friendlyName = null,
                                                                                                 int? pageSize = null,
                                                                                                 long? limit = null,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new ReadTemplateOptions(){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TemplateResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TemplateResource>.FromJson("templates", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TemplateResource> NextPage(Page<TemplateResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<TemplateResource>.FromJson("templates", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TemplateResource> PreviousPage(Page<TemplateResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<TemplateResource>.FromJson("templates", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a TemplateResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TemplateResource object represented by the provided JSON </returns>
        public static TemplateResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TemplateResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Template
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A string to describe the verification template
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// Ojbect with the template translations.
        /// </summary>
        [JsonProperty("translations")]
        public object Translations { get; private set; }

        private TemplateResource()
        {

        }
    }

}