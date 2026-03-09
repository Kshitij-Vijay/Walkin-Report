using System.Text.Json.Serialization;

public class Walkin
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("area")]
    public string Area { get; set; }

    [JsonPropertyName("pin")]
    public string Pin { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("team")]
    public string Team { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("categor")]
    public string Category { get; set; }

    [JsonPropertyName("products")]
    public string Products { get; set; }

    [JsonPropertyName("store")]
    public string Store { get; set; }

    [JsonPropertyName("remarks")]
    public string Remarks { get; set; }

    [JsonPropertyName("amount")]
    public float amount { get; set; }

    [JsonPropertyName("followup")]
    public int followup { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    public int checkno { get; set; }
    public Walkin(
        string name,
        string area,
        string pin,
        string phone,
        string source,
        string team,
        string status,
        string category,
        string products,
        string store,
        string remarks,
        DateTime createdAt
    )
    {
        Name = name;
        Area = area;
        Pin = pin;
        Phone = phone;
        Source = source;
        Team = team;
        Status = status;
        Category = category;
        Products = products;
        Store = store;
        Remarks = remarks;
        CreatedAt = createdAt;
    }

    // Optional: parameterless constructor (useful for DataGridView / ORM)
    public Walkin() { }
}