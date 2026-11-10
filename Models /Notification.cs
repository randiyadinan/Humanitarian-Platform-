namespace HumanitarianAPI.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Recipient { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Timestamp { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;
    }
}
