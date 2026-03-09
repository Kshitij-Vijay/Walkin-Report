using System.Text.Json.Serialization;

namespace Walkin_Report
{
    public class Status
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("status")]
        public string Name { get; set; }

        public Status() { }

        public Status(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}