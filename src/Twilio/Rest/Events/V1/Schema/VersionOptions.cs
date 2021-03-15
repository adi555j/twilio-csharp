/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Events.V1.Schema
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a paginated list of versions of the schema.
    /// </summary>
    public class ReadVersionOptions : ReadOptions<VersionResource>
    {
        /// <summary>
        /// The unique identifier of the schema.
        /// </summary>
        public string PathId { get; }

        /// <summary>
        /// Construct a new ReadVersionOptions
        /// </summary>
        /// <param name="pathId"> The unique identifier of the schema. </param>
        public ReadVersionOptions(string pathId)
        {
            PathId = pathId;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Fetch a specific schema and version.
    /// </summary>
    public class FetchVersionOptions : IOptions<VersionResource>
    {
        /// <summary>
        /// The unique identifier of the schema.
        /// </summary>
        public string PathId { get; }
        /// <summary>
        /// The version of the schema
        /// </summary>
        public int? PathSchemaVersion { get; }

        /// <summary>
        /// Construct a new FetchVersionOptions
        /// </summary>
        /// <param name="pathId"> The unique identifier of the schema. </param>
        /// <param name="pathSchemaVersion"> The version of the schema </param>
        public FetchVersionOptions(string pathId, int? pathSchemaVersion)
        {
            PathId = pathId;
            PathSchemaVersion = pathSchemaVersion;
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

}