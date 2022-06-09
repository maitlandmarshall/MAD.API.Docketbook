using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MAD.API.Docketbook.Dockets
{
    internal class DocketIngestDtoDateTimeConverter : IsoDateTimeConverter
    {
        public DocketIngestDtoDateTimeConverter()
        {
            this.DateTimeFormat = "yyyy-MM-dd";
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            base.WriteJson(writer, value, serializer);
        }
    }
}