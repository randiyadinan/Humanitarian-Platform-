namespace HumanitarianAPI.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skills { get; set; } // උදා: ප්‍රථමාධාර, පිහිනුම්
        public string ContactNumber { get; set; }
        public string Status { get; set; } // උදා: Available, Deployed
    }
}
