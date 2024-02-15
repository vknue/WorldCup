using DAL.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public enum EventType
    {
        Goal,
        SubstitutionIn,
        SubstitutionOut,
        YellowCard,
        Unknown
        // Add more event types as needed
    }

    public class Event
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type_of_event")]
        [JsonConverter(typeof(EventTypeConverter))]
        public EventType TypeOfEvent { get; set; }  // Use the enum type

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
