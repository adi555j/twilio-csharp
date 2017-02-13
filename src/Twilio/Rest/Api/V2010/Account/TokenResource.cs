using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class TokenResource : Resource 
    {
        private static Request BuildCreateRequest(CreateTokenOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Tokens.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Create a new token
        /// </summary>
        ///
        /// <param name="options"> Create Token parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Token </returns> 
        public static TokenResource Create(CreateTokenOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new token
        /// </summary>
        ///
        /// <param name="options"> Create Token parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Token </returns> 
        public static async System.Threading.Tasks.Task<TokenResource> CreateAsync(CreateTokenOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Create a new token
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="ttl"> The duration in seconds the credentials are valid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Token </returns> 
        public static TokenResource Create(string accountSid = null, int? ttl = null, ITwilioRestClient client = null)
        {
            var options = new CreateTokenOptions{AccountSid = accountSid, Ttl = ttl};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new token
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="ttl"> The duration in seconds the credentials are valid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Token </returns> 
        public static async System.Threading.Tasks.Task<TokenResource> CreateAsync(string accountSid = null, int? ttl = null, ITwilioRestClient client = null)
        {
            var options = new CreateTokenOptions{AccountSid = accountSid, Ttl = ttl};
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a TokenResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TokenResource object represented by the provided JSON </returns> 
        public static TokenResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TokenResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// An array representing the ephemeral credentials
        /// </summary>
        [JsonProperty("ice_servers")]
        public List<IceServer> IceServers { get; private set; }
        /// <summary>
        /// The temporary password used for authenticating
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; private set; }
        /// <summary>
        /// The duration in seconds the credentials are valid
        /// </summary>
        [JsonProperty("ttl")]
        public string Ttl { get; private set; }
        /// <summary>
        /// The temporary username that uniquely identifies a Token.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; private set; }
    
        private TokenResource()
        {
        
        }
    }

}