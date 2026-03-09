using System.Text.Json.Serialization;

namespace Walkin_Report
{
    public class Staff
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sym")]
        public string Sym { get; set; }

        public Staff() { }
    }
}