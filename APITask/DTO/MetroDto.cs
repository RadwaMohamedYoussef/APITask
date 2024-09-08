using APITask.Enum;
using System.Text.Json.Serialization;

namespace APITask.DTO
{
    public class MetroDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Stations StartStationId { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Stations DestinationStationId { get; set; }
    }

  
}
