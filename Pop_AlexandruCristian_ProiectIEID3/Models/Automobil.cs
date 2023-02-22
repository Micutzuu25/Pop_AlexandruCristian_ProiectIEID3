using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pop_AlexandruCristian_ProiectIEID3.Models
{
    public class Automobil
    {
        public  int ID { get; set; }

        [Display(Name="Nume Sofer")]
        public string Nume { get; set; }
        public string Firma { get; set; }

        public string Model { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataAparitie { get; set; }

        public int VanzatorID { get; set; }
        public Vanzator Vanzator { get; set; }

        public ICollection<AutomobilCategory> AutomobilCategories { get; set;}
    }
}
