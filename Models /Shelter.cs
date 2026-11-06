namespace HumanitarianAPI.Models
{
    public class Shelter
    {
        public int Id { get; set; }
        public string Name { get; set; } // කඳවුරේ නම (උදා: අගලවත්ත මහා විද්‍යාලය)
        public string Location { get; set; } // පිහිටි ස්ථානය
        public int Capacity { get; set; } // උපරිම කීදෙනෙකුට ඉන්න පුළුවන්ද
        public int CurrentOccupancy { get; set; } // දැනට කඳවුරේ කීදෙනෙක් ඉන්නවාද
    }
}
