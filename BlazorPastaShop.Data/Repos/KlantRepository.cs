using BlazorPastaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPastaShop.Data.Repos
{
    public class KlantRepository
    {
        private readonly BlazorPastaShopDbContext _context;
        public KlantRepository(BlazorPastaShopDbContext context) {
            _context = context;
        }

        public async Task AddKlantAsync(Klant klant) {
            _context.Klanten.Add(klant);
            await _context.SaveChangesAsync();
        }


    }
}
