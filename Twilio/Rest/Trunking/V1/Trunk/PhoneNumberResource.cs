using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Trunking.V1.Trunk {

    public class PhoneNumberResource : Resource {
        public sealed class AddressRequirement : IStringEnum {
            public const string None = "none";
            public const string Any = "any";
            public const string Local = "local";
            public const string Foreign = "foreign";
        
            private string _value;
            
            public AddressRequirement() { }
            
            public AddressRequirement(string value) {
                _value = value;
            }
            
            public override string ToString() {
                return _value;
            }
            
            public static implicit operator AddressRequirement(string value) {
                return new AddressRequirement(value);
            }
            
            public static implicit operator string(AddressRequirement value) {
                return value.ToString();
            }
            
            public void FromString(string value) {
                _value = value;
            }
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="trunkSid"> The trunk_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> PhoneNumberFetcher capable of executing the fetch </returns> 
        public static PhoneNumberFetcher Fetcher(string trunkSid, string sid) {
            return new PhoneNumberFetcher(trunkSid, sid);
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="trunkSid"> The trunk_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> PhoneNumberDeleter capable of executing the delete </returns> 
        public static PhoneNumberDeleter Deleter(string trunkSid, string sid) {
            return new PhoneNumberDeleter(trunkSid, sid);
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="trunkSid"> The trunk_sid </param>
        /// <param name="phoneNumberSid"> The phone_number_sid </param>
        /// <returns> PhoneNumberCreator capable of executing the create </returns> 
        public static PhoneNumberCreator Creator(string trunkSid, string phoneNumberSid) {
            return new PhoneNumberCreator(trunkSid, phoneNumberSid);
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="trunkSid"> The trunk_sid </param>
        /// <returns> PhoneNumberReader capable of executing the read </returns> 
        public static PhoneNumberReader Reader(string trunkSid) {
            return new PhoneNumberReader(trunkSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a PhoneNumberResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneNumberResource object represented by the provided JSON </returns> 
        public static PhoneNumberResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<PhoneNumberResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; }
        [JsonProperty("address_requirements")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PhoneNumberResource.AddressRequirement addressRequirements { get; }
        [JsonProperty("api_version")]
        public string apiVersion { get; }
        [JsonProperty("beta")]
        public bool? beta { get; }
        [JsonProperty("capabilities")]
        public Dictionary<string, string> capabilities { get; }
        [JsonProperty("date_created")]
        public DateTime? dateCreated { get; }
        [JsonProperty("date_updated")]
        public DateTime? dateUpdated { get; }
        [JsonProperty("friendly_name")]
        public string friendlyName { get; }
        [JsonProperty("links")]
        public Dictionary<string, string> links { get; }
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Twilio.Types.PhoneNumber phoneNumber { get; }
        [JsonProperty("sid")]
        public string sid { get; }
        [JsonProperty("sms_application_sid")]
        public string smsApplicationSid { get; }
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod smsFallbackMethod { get; }
        [JsonProperty("sms_fallback_url")]
        public Uri smsFallbackUrl { get; }
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod smsMethod { get; }
        [JsonProperty("sms_url")]
        public Uri smsUrl { get; }
        [JsonProperty("status_callback")]
        public Uri statusCallback { get; }
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod statusCallbackMethod { get; }
        [JsonProperty("trunk_sid")]
        public string trunkSid { get; }
        [JsonProperty("url")]
        public Uri url { get; }
        [JsonProperty("voice_application_sid")]
        public string voiceApplicationSid { get; }
        [JsonProperty("voice_caller_id_lookup")]
        public bool? voiceCallerIdLookup { get; }
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod voiceFallbackMethod { get; }
        [JsonProperty("voice_fallback_url")]
        public Uri voiceFallbackUrl { get; }
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod voiceMethod { get; }
        [JsonProperty("voice_url")]
        public Uri voiceUrl { get; }
    
        public PhoneNumberResource() {
        
        }
    
        private PhoneNumberResource([JsonProperty("account_sid")]
                                    string accountSid, 
                                    [JsonProperty("address_requirements")]
                                    PhoneNumberResource.AddressRequirement addressRequirements, 
                                    [JsonProperty("api_version")]
                                    string apiVersion, 
                                    [JsonProperty("beta")]
                                    bool? beta, 
                                    [JsonProperty("capabilities")]
                                    Dictionary<string, string> capabilities, 
                                    [JsonProperty("date_created")]
                                    string dateCreated, 
                                    [JsonProperty("date_updated")]
                                    string dateUpdated, 
                                    [JsonProperty("friendly_name")]
                                    string friendlyName, 
                                    [JsonProperty("links")]
                                    Dictionary<string, string> links, 
                                    [JsonProperty("phone_number")]
                                    Twilio.Types.PhoneNumber phoneNumber, 
                                    [JsonProperty("sid")]
                                    string sid, 
                                    [JsonProperty("sms_application_sid")]
                                    string smsApplicationSid, 
                                    [JsonProperty("sms_fallback_method")]
                                    Twilio.Http.HttpMethod smsFallbackMethod, 
                                    [JsonProperty("sms_fallback_url")]
                                    Uri smsFallbackUrl, 
                                    [JsonProperty("sms_method")]
                                    Twilio.Http.HttpMethod smsMethod, 
                                    [JsonProperty("sms_url")]
                                    Uri smsUrl, 
                                    [JsonProperty("status_callback")]
                                    Uri statusCallback, 
                                    [JsonProperty("status_callback_method")]
                                    Twilio.Http.HttpMethod statusCallbackMethod, 
                                    [JsonProperty("trunk_sid")]
                                    string trunkSid, 
                                    [JsonProperty("url")]
                                    Uri url, 
                                    [JsonProperty("voice_application_sid")]
                                    string voiceApplicationSid, 
                                    [JsonProperty("voice_caller_id_lookup")]
                                    bool? voiceCallerIdLookup, 
                                    [JsonProperty("voice_fallback_method")]
                                    Twilio.Http.HttpMethod voiceFallbackMethod, 
                                    [JsonProperty("voice_fallback_url")]
                                    Uri voiceFallbackUrl, 
                                    [JsonProperty("voice_method")]
                                    Twilio.Http.HttpMethod voiceMethod, 
                                    [JsonProperty("voice_url")]
                                    Uri voiceUrl) {
            this.accountSid = accountSid;
            this.addressRequirements = addressRequirements;
            this.apiVersion = apiVersion;
            this.beta = beta;
            this.capabilities = capabilities;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.friendlyName = friendlyName;
            this.links = links;
            this.phoneNumber = phoneNumber;
            this.sid = sid;
            this.smsApplicationSid = smsApplicationSid;
            this.smsFallbackMethod = smsFallbackMethod;
            this.smsFallbackUrl = smsFallbackUrl;
            this.smsMethod = smsMethod;
            this.smsUrl = smsUrl;
            this.statusCallback = statusCallback;
            this.statusCallbackMethod = statusCallbackMethod;
            this.trunkSid = trunkSid;
            this.url = url;
            this.voiceApplicationSid = voiceApplicationSid;
            this.voiceCallerIdLookup = voiceCallerIdLookup;
            this.voiceFallbackMethod = voiceFallbackMethod;
            this.voiceFallbackUrl = voiceFallbackUrl;
            this.voiceMethod = voiceMethod;
            this.voiceUrl = voiceUrl;
        }
    }
}