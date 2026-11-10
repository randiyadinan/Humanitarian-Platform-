namespace HumanitarianAPI.Models
{
    public class CrisisEvent
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty; // Flood, Landslide, Cyclone
        public string Location { get; set; } = string.Empty;
        public string Severity { get; set; } = string.Empty; // Low, Medium, High, Critical
        public string DateReported { get; set; } = string.Empty;
    }
}
