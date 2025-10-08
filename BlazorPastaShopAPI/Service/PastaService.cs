using BlazorPastaShop.Data.Models;

namespace BlazorPastaShop.API.Service
{
    public class PastaService
    {
        private readonly BlazorPastaShopDbContext _context;

        public PastaService(BlazorPastaShopDbContext context)
        {
            _context = context;
        }

        public async Task<Klant> VoegKlantToeAsync(Klant klant)
        {
            _context.Klanten.Add(klant);
            await _context.SaveChangesAsync();
            return klant;
        }

        public async Task<Bestelling> VoegBestellingToeAsync(Bestelling bestelling)
        {
            _context.Bestellingen.Add(bestelling);
            await _context.SaveChangesAsync();
            return bestelling;
        }

    }
}
