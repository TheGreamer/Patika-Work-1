using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatikaClassWork1.Utilities
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => DateTime.Parse(reader.GetString());

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToLocalTime().ToString("yyyy-MM-dd"));
    }
}