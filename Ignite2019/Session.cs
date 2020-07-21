using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ignite2019
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public partial class Session
    {
        [JsonProperty("@search.score")]
        public long SearchScore { get; set; }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public int attendeeCount { get; set; }
        public bool hasLiveStream { get; set; }
        public string sessionId { get; set; }
        public string sessionInstanceId { get; set; }
        public string sessionCode { get; set; }
        public string sessionCodeNormalized { get; set; }
        public string title { get; set; }
        public string sortTitle { get; set; }
        public long sortRank { get; set; }
        public string description { get; set; }
        public string registrationLink { get; set; }
        public DateTime? startDateTime { get; set; }
        public DateTime? endDateTime { get; set; }
        public int durationInMinutes { get; set; }
        public string sessionType { get; set; }
        public string sessionTypeLogical { get; set; }
        public List<object> learningPath { get; set; }
        public string level { get; set; }
        public List<string> products { get; set; }
        public string format { get; set; }
        public string topic { get; set; }
        public string sessionTypeId { get; set; }
        public string slideDeck { get; set; }
        public bool isMandatory { get; set; }
        public bool visibleToAnonymousUsers { get; set; }
        public bool visibleInSessionListing { get; set; }
        public string onDemand { get; set; }
        public string downloadVideoLink { get; set; }
        public string onDemandThumbnail { get; set; }
        public string techCommunityDiscussionId { get; set; }
        public List<string> speakerIds { get; set; }
        public List<string> speakerNames { get; set; }
        public List<string> speakerCompanies { get; set; }
        public List<string> sessionLinks { get; set; }
        public List<object> marketingCampaign { get; set; }
        public string links { get; set; }
        public DateTime lastUpdate { get; set; }
        public string techCommunityUrl { get; set; }
        public string launchLabLink { get; set; }
        public string captionFileLink { get; set; }
        public List<object> childModules { get; set; }
        public List<object> siblingModules { get; set; }

    }


}
