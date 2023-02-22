namespace Pop_AlexandruCristian_ProiectIEID3.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<AutomobilCategory>? AutomobilCategories { get; set; }
    }
}
