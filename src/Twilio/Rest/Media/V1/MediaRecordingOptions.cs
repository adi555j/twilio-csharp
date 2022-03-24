/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Media.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Deletes a MediaRecording resource identified by a SID.
    /// </summary>
    public class DeleteMediaRecordingOptions : IOptions<MediaRecordingResource>
    {
        /// <summary>
        /// The SID that identifies the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMediaRecordingOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        public DeleteMediaRecordingOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Returns a single MediaRecording resource identified by a SID.
    /// </summary>
    public class FetchMediaRecordingOptions : IOptions<MediaRecordingResource>
    {
        /// <summary>
        /// The SID that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMediaRecordingOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        public FetchMediaRecordingOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Returns a list of MediaRecordings.
    /// </summary>
    public class ReadMediaRecordingOptions : ReadOptions<MediaRecordingResource>
    {
        /// <summary>
        /// The sort order of the list
        /// </summary>
        public MediaRecordingResource.OrderEnum Order { get; set; }
        /// <summary>
        /// Status to filter by
        /// </summary>
        public MediaRecordingResource.StatusEnum Status { get; set; }
        /// <summary>
        /// MediaProcessor to filter by
        /// </summary>
        public string ProcessorSid { get; set; }
        /// <summary>
        /// Source SID to filter by
        /// </summary>
        public string SourceSid { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (ProcessorSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ProcessorSid", ProcessorSid.ToString()));
            }

            if (SourceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceSid", SourceSid.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}