using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPastaShop.Data.Models
{
    public class Bestelling
    {
        public int Id { get; set; }

        // Foreign keys
        // public int KlantId { get; set; }
        public PastaSoort PastaSoort { get; set; }
        public Grootte Grootte { get; set; }
        public GekozenSaus Saus { get; set; }
    }
}
