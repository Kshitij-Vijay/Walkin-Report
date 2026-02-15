namespace Walkin_Report
{
    public class Walkin
    {
        public int Id { get; set; }
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
            string remarks)
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
        }
    }
}
