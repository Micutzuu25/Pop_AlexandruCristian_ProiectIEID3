namespace Pop_AlexandruCristian_ProiectIEID3.Models
{
    public class AutomobilCategory
    {
        public int ID { get; set; }
        public int AutomobilID { get; set; }
        public Automobil Automobil { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
