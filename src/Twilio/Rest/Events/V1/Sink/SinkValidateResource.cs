/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// SinkValidateResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Events.V1.Sink
{

    public class SinkValidateResource : Resource
    {
        private static Request BuildCreateRequest(CreateSinkValidateOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                "/v1/Sinks/" + options.PathSid + "/Validate",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Validate that a test event for a Sink was received.
        /// </summary>
        /// <param name="options"> Create SinkValidate parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SinkValidate </returns>
        public static SinkValidateResource Create(CreateSinkValidateOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Validate that a test event for a Sink was received.
        /// </summary>
        /// <param name="options"> Create SinkValidate parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SinkValidate </returns>
        public static async System.Threading.Tasks.Task<SinkValidateResource> CreateAsync(CreateSinkValidateOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Validate that a test event for a Sink was received.
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="testId"> A string that uniquely identifies the test event for a Sink being validated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SinkValidate </returns>
        public static SinkValidateResource Create(string pathSid, string testId, ITwilioRestClient client = null)
        {
            var options = new CreateSinkValidateOptions(pathSid, testId);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Validate that a test event for a Sink was received.
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="testId"> A string that uniquely identifies the test event for a Sink being validated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SinkValidate </returns>
        public static async System.Threading.Tasks.Task<SinkValidateResource> CreateAsync(string pathSid,
                                                                                          string testId,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new CreateSinkValidateOptions(pathSid, testId);
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SinkValidateResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SinkValidateResource object represented by the provided JSON </returns>
        public static SinkValidateResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SinkValidateResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Feedback indicating whether the given Sink was validated.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; private set; }

        private SinkValidateResource()
        {

        }
    }

}