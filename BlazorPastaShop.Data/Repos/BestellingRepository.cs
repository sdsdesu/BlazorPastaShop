using BlazorPastaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPastaShop.Data.Repos
{
    public class BestellingRepository
    {
        private readonly BlazorPastaShopDbContext _context;

        public BestellingRepository(BlazorPastaShopDbContext context)
        {
            _context = context;
        }

        public async Task AddBestellingAsync(Bestelling bestelling)
        {
            _context.Bestellingen.Add(bestelling);
            await _context.SaveChangesAsync();
        }

        
    }
}
