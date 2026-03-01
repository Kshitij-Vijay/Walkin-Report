public class Walkin
{
    public int Id { get; set; }          // optional (DB auto increment)
    public string Name { get; set; }
    public string Area { get; set; }
    public string Pin { get; set; }
    public string Phone { get; set; }
    public string Source { get; set; }
    public string Team { get; set; }
    public string Status { get; set; }
    public string Category { get; set; }
    public string Products { get; set; }
    public string Store { get; set; }
    public string Remarks { get; set; }

    public float amount { get; set; }

    public int followup { get; set; }
    public int checkno { get; set; }

    // ✅ NEW
    public DateTime CreatedAt { get; set; }

    // Constructor
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