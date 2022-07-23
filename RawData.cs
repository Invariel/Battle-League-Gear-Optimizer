using System.Text.Json.Serialization;

namespace Gear_Optimizer
{
    public class RawData
    {
        [JsonPropertyName("Gear")]
        public Gearlist Gearlist { get; set; }
        public Dictionary<string, int[]> Characters { get; set; }
    }
}