/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// CallSummaryResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Insights.V1
{

    public class CallSummaryResource : Resource
    {
        public sealed class CallTypeEnum : StringEnum
        {
            private CallTypeEnum(string value) : base(value) {}
            public CallTypeEnum() {}
            public static implicit operator CallTypeEnum(string value)
            {
                return new CallTypeEnum(value);
            }

            public static readonly CallTypeEnum Carrier = new CallTypeEnum("carrier");
            public static readonly CallTypeEnum Sip = new CallTypeEnum("sip");
            public static readonly CallTypeEnum Trunking = new CallTypeEnum("trunking");
            public static readonly CallTypeEnum Client = new CallTypeEnum("client");
        }

        public sealed class CallStateEnum : StringEnum
        {
            private CallStateEnum(string value) : base(value) {}
            public CallStateEnum() {}
            public static implicit operator CallStateEnum(string value)
            {
                return new CallStateEnum(value);
            }

            public static readonly CallStateEnum Ringing = new CallStateEnum("ringing");
            public static readonly CallStateEnum Completed = new CallStateEnum("completed");
            public static readonly CallStateEnum Busy = new CallStateEnum("busy");
            public static readonly CallStateEnum Fail = new CallStateEnum("fail");
            public static readonly CallStateEnum Noanswer = new CallStateEnum("noanswer");
            public static readonly CallStateEnum Canceled = new CallStateEnum("canceled");
            public static readonly CallStateEnum Answered = new CallStateEnum("answered");
            public static readonly CallStateEnum Undialed = new CallStateEnum("undialed");
        }

        public sealed class ProcessingStateEnum : StringEnum
        {
            private ProcessingStateEnum(string value) : base(value) {}
            public ProcessingStateEnum() {}
            public static implicit operator ProcessingStateEnum(string value)
            {
                return new ProcessingStateEnum(value);
            }

            public static readonly ProcessingStateEnum Complete = new ProcessingStateEnum("complete");
            public static readonly ProcessingStateEnum Partial = new ProcessingStateEnum("partial");
        }

        public sealed class DirectionEnum : StringEnum
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
            public static implicit operator DirectionEnum(string value)
            {
                return new DirectionEnum(value);
            }

            public static readonly DirectionEnum Inbound = new DirectionEnum("inbound");
            public static readonly DirectionEnum OutboundApi = new DirectionEnum("outbound_api");
            public static readonly DirectionEnum OutboundDial = new DirectionEnum("outbound_dial");
            public static readonly DirectionEnum TrunkingOriginating = new DirectionEnum("trunking_originating");
            public static readonly DirectionEnum TrunkingTerminating = new DirectionEnum("trunking_terminating");
        }

        public sealed class DisconnectedByEnum : StringEnum
        {
            private DisconnectedByEnum(string value) : base(value) {}
            public DisconnectedByEnum() {}
            public static implicit operator DisconnectedByEnum(string value)
            {
                return new DisconnectedByEnum(value);
            }

            public static readonly DisconnectedByEnum Callee = new DisconnectedByEnum("callee");
            public static readonly DisconnectedByEnum Caller = new DisconnectedByEnum("caller");
            public static readonly DisconnectedByEnum Unknown = new DisconnectedByEnum("unknown");
        }

        private static Request BuildFetchRequest(FetchCallSummaryOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Voice/" + options.PathCallSid + "/Summary",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch CallSummary parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CallSummary </returns>
        public static CallSummaryResource Fetch(FetchCallSummaryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch CallSummary parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CallSummary </returns>
        public static async System.Threading.Tasks.Task<CallSummaryResource> FetchAsync(FetchCallSummaryOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="processingState"> The processing_state </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CallSummary </returns>
        public static CallSummaryResource Fetch(string pathCallSid,
                                                CallSummaryResource.ProcessingStateEnum processingState = null,
                                                ITwilioRestClient client = null)
        {
            var options = new FetchCallSummaryOptions(pathCallSid){ProcessingState = processingState};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="processingState"> The processing_state </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CallSummary </returns>
        public static async System.Threading.Tasks.Task<CallSummaryResource> FetchAsync(string pathCallSid,
                                                                                        CallSummaryResource.ProcessingStateEnum processingState = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchCallSummaryOptions(pathCallSid){ProcessingState = processingState};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CallSummaryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CallSummaryResource object represented by the provided JSON </returns>
        public static CallSummaryResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CallSummaryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The call_sid
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// The call_type
        /// </summary>
        [JsonProperty("call_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CallSummaryResource.CallTypeEnum CallType { get; private set; }
        /// <summary>
        /// The call_state
        /// </summary>
        [JsonProperty("call_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CallSummaryResource.CallStateEnum CallState { get; private set; }
        /// <summary>
        /// The processing_state
        /// </summary>
        [JsonProperty("processing_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CallSummaryResource.ProcessingStateEnum ProcessingState { get; private set; }
        /// <summary>
        /// The direction
        /// </summary>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CallSummaryResource.DirectionEnum Direction { get; private set; }
        /// <summary>
        /// The disconnected_by
        /// </summary>
        [JsonProperty("disconnected_by")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CallSummaryResource.DisconnectedByEnum DisconnectedBy { get; private set; }
        /// <summary>
        /// The start_time
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }
        /// <summary>
        /// The end_time
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }
        /// <summary>
        /// The duration
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The connect_duration
        /// </summary>
        [JsonProperty("connect_duration")]
        public int? ConnectDuration { get; private set; }
        /// <summary>
        /// The from
        /// </summary>
        [JsonProperty("from")]
        public object From { get; private set; }
        /// <summary>
        /// The to
        /// </summary>
        [JsonProperty("to")]
        public object To { get; private set; }
        /// <summary>
        /// The carrier_edge
        /// </summary>
        [JsonProperty("carrier_edge")]
        public object CarrierEdge { get; private set; }
        /// <summary>
        /// The client_edge
        /// </summary>
        [JsonProperty("client_edge")]
        public object ClientEdge { get; private set; }
        /// <summary>
        /// The sdk_edge
        /// </summary>
        [JsonProperty("sdk_edge")]
        public object SdkEdge { get; private set; }
        /// <summary>
        /// The sip_edge
        /// </summary>
        [JsonProperty("sip_edge")]
        public object SipEdge { get; private set; }
        /// <summary>
        /// The tags
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The attributes
        /// </summary>
        [JsonProperty("attributes")]
        public object Attributes { get; private set; }
        /// <summary>
        /// The properties
        /// </summary>
        [JsonProperty("properties")]
        public object Properties { get; private set; }

        private CallSummaryResource()
        {

        }
    }

}