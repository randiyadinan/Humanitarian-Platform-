namespace HumanitarianAPI.Models
{
    public class AssistanceRequest
    {
        public int Id { get; set; }
        public string Category { get; set; } // උදා: Food, Medicine, Shelter
        public string Urgency { get; set; } // උදා: High, Medium, Low
        public string Description { get; set; }
        public string Location { get; set; }
        public string Status { get; set; } // උදා: Pending, Assigned, Completed
    }
}
