namespace Pop_AlexandruCristian_ProiectIEID3.Models
{
    public class Vanzator
    {
        public int ID { get; set; }

        public string NumeVanzator { get; set; }

        public ICollection<Automobil>? Automobile { get; set; }
    }
}
