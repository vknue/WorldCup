using DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converters
{
    public class EventTypeConverter : JsonConverter<EventType>
    {
        private static readonly Dictionary<string, EventType> eventTypeMap = new Dictionary<string, EventType>
    {
        { "goal", EventType.Goal },
        { "SubstitutionIn", EventType.SubstitutionIn },
        { "SubstitutionOut", EventType.SubstitutionOut },
        { "yellow-card", EventType.YellowCard }
        // Add more mappings as needed
    };

        public override EventType ReadJson(JsonReader reader, Type objectType, EventType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                string value = (string)reader.Value;
                if (eventTypeMap.TryGetValue(value, out EventType eventType))
                {
                    return eventType;
                }
            }

            // Handle the case when the JSON value doesn't match any enum value.
            // You can return a default value or throw an exception as needed.
            return EventType.Unknown; // Assuming you have an "Unknown" enum value.
        }

        public override void WriteJson(JsonWriter writer, EventType value, JsonSerializer serializer)
        {
            // Write the enum value as a string
            writer.WriteValue(value.ToString());
        }
    }
}
