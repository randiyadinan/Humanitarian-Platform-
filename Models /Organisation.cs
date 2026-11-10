namespace HumanitarianAPI.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty; // Medical, Rescue, Food
        public string ContactPerson { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
