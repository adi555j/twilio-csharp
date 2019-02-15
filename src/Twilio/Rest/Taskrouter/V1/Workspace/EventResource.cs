/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// EventResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class EventResource : Resource 
    {
        private static Request BuildFetchRequest(FetchEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Events/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static EventResource Fetch(FetchEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(FetchEventOptions options, 
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
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static EventResource Fetch(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(pathWorkspaceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(string pathWorkspaceSid, 
                                                                                  string pathSid, 
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(pathWorkspaceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Events",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static ResourceSet<EventResource> Read(ReadEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(ReadEventOptions options, 
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathWorkspaceSid"> Filter events by those pertaining to a particular workspace </param>
        /// <param name="endDate"> Filter events by an end date. </param>
        /// <param name="eventType"> Filter events by those of a certain event type </param>
        /// <param name="minutes"> Filter events by up to 'x' minutes in the past. </param>
        /// <param name="reservationSid"> Filter events by those pertaining to a particular reservation </param>
        /// <param name="startDate"> Filter events by a start date. </param>
        /// <param name="taskQueueSid"> Filter events by those pertaining to a particular queue </param>
        /// <param name="taskSid"> Filter events by those pertaining to a particular task </param>
        /// <param name="workerSid"> Filter events by those pertaining to a particular worker </param>
        /// <param name="workflowSid"> Filter events by those pertaining to a particular workflow </param>
        /// <param name="taskChannel"> Filter events by those pertaining to a particular task channel </param>
        /// <param name="sid"> Filter events by those pertaining to a particular event </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static ResourceSet<EventResource> Read(string pathWorkspaceSid, 
                                                      DateTime? endDate = null, 
                                                      string eventType = null, 
                                                      int? minutes = null, 
                                                      string reservationSid = null, 
                                                      DateTime? startDate = null, 
                                                      string taskQueueSid = null, 
                                                      string taskSid = null, 
                                                      string workerSid = null, 
                                                      string workflowSid = null, 
                                                      string taskChannel = null, 
                                                      string sid = null, 
                                                      int? pageSize = null, 
                                                      long? limit = null, 
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(pathWorkspaceSid){EndDate = endDate, EventType = eventType, Minutes = minutes, ReservationSid = reservationSid, StartDate = startDate, TaskQueueSid = taskQueueSid, TaskSid = taskSid, WorkerSid = workerSid, WorkflowSid = workflowSid, TaskChannel = taskChannel, Sid = sid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathWorkspaceSid"> Filter events by those pertaining to a particular workspace </param>
        /// <param name="endDate"> Filter events by an end date. </param>
        /// <param name="eventType"> Filter events by those of a certain event type </param>
        /// <param name="minutes"> Filter events by up to 'x' minutes in the past. </param>
        /// <param name="reservationSid"> Filter events by those pertaining to a particular reservation </param>
        /// <param name="startDate"> Filter events by a start date. </param>
        /// <param name="taskQueueSid"> Filter events by those pertaining to a particular queue </param>
        /// <param name="taskSid"> Filter events by those pertaining to a particular task </param>
        /// <param name="workerSid"> Filter events by those pertaining to a particular worker </param>
        /// <param name="workflowSid"> Filter events by those pertaining to a particular workflow </param>
        /// <param name="taskChannel"> Filter events by those pertaining to a particular task channel </param>
        /// <param name="sid"> Filter events by those pertaining to a particular event </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(string pathWorkspaceSid, 
                                                                                              DateTime? endDate = null, 
                                                                                              string eventType = null, 
                                                                                              int? minutes = null, 
                                                                                              string reservationSid = null, 
                                                                                              DateTime? startDate = null, 
                                                                                              string taskQueueSid = null, 
                                                                                              string taskSid = null, 
                                                                                              string workerSid = null, 
                                                                                              string workflowSid = null, 
                                                                                              string taskChannel = null, 
                                                                                              string sid = null, 
                                                                                              int? pageSize = null, 
                                                                                              long? limit = null, 
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(pathWorkspaceSid){EndDate = endDate, EventType = eventType, Minutes = minutes, ReservationSid = reservationSid, StartDate = startDate, TaskQueueSid = taskQueueSid, TaskSid = taskSid, WorkerSid = workerSid, WorkflowSid = workflowSid, TaskChannel = taskChannel, Sid = sid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<EventResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<EventResource> NextPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<EventResource> PreviousPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns> 
        public static EventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account owning this event
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The actor_sid
        /// </summary>
        [JsonProperty("actor_sid")]
        public string ActorSid { get; private set; }
        /// <summary>
        /// The actor_type
        /// </summary>
        [JsonProperty("actor_type")]
        public string ActorType { get; private set; }
        /// <summary>
        /// The actor_url
        /// </summary>
        [JsonProperty("actor_url")]
        public Uri ActorUrl { get; private set; }
        /// <summary>
        /// A description of the event
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// Data about this specific event.
        /// </summary>
        [JsonProperty("event_data")]
        public object EventData { get; private set; }
        /// <summary>
        /// The time this event was sent
        /// </summary>
        [JsonProperty("event_date")]
        public DateTime? EventDate { get; private set; }
        /// <summary>
        /// The time this event was sent in ms
        /// </summary>
        [JsonProperty("event_date_ms")]
        public long? EventDateMs { get; private set; }
        /// <summary>
        /// An identifier for this event
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; private set; }
        /// <summary>
        /// The sid of the object this event is most relevant to
        /// </summary>
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }
        /// <summary>
        /// The type of object this event is most relevant to
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }
        /// <summary>
        /// The resource_url
        /// </summary>
        [JsonProperty("resource_url")]
        public Uri ResourceUrl { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The source
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; private set; }
        /// <summary>
        /// The source_ip_address
        /// </summary>
        [JsonProperty("source_ip_address")]
        public string SourceIpAddress { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        private EventResource()
        {

        }
    }

}