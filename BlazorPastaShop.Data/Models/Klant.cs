using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPastaShop.Data.Models
{
    public class Klant
    {
        public int KlantId { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public string Telefoon { get; set; }
        public DateTime GeboorteDatum { get; set; }

//        public ICollection<Bestelling> Bestellingen { get; set; }

    }
}
