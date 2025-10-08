using System.ComponentModel.DataAnnotations;

namespace BlazorPastaShop.Blazor.Client.Models
{
    public class KlantModel
    {
        [Required(ErrorMessage = "{0} is een verplicht veld")]
        public string Voornaam { get; set; }
        [Required(ErrorMessage = "{0} is een verplicht veld")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "{0} is een verplicht veld")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} is een verplicht veld")]
        public string Telefoon { get; set; }
        [GeboortedatumValidator(ErrorMessage = "Geboortedatum moet in het verleden liggen")]
        public DateTime Geboortedatum { get; set; }
    }
    public class GeboortedatumValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;
            if (!(value is DateTime))
                return false;
            return ((DateTime)value) < DateTime.Today;
        }
    }
}

