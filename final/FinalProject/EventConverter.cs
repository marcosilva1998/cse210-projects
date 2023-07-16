using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;public class EventConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(Event);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject eventObject = JObject.Load(reader);
        string eventType = eventObject["EventType"].Value<string>();

        Event eventItem;
        if (eventType == "SimpleEvent")
        {
            eventItem = eventObject["Event"].ToObject<SimpleEvent>();
        }
        else if (eventType == "DailyEvent")
        {
            eventItem = eventObject["Event"].ToObject<DialyEvent>();
        }
        else if (eventType == "WeeklyEvent")
        {
            eventItem = eventObject["Event"].ToObject<WeeklyEvent>();
        }
        else
        {
            throw new JsonSerializationException("Unknown event type: " + eventType);
        }

        return eventItem;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}