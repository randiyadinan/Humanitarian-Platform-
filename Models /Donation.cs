namespace HumanitarianAPI.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public string DonationType { get; set; } // Monetary or Material
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
