using System.Text.Json.Serialization;

namespace Walkin_Report
{
    public class Store
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("sym")]
        public string Sym { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        public Store() { }

        public Store(int id, string sym, string name)
        {
            Id = id;
            Sym = sym;
            Name = name;
        }
    }
}