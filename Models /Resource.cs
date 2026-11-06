namespace HumanitarianAPI.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; } // උදා: වතුර බෝතල්, ඖෂධ
        public int Quantity { get; set; }
        public string Location { get; set; }
        public string Status { get; set; } // උදා: Available, Dispatched
    }
}
