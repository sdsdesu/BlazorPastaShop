using BlazorPastaShop.API.Service;
using BlazorPastaShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPastaShop.API.Controllers
{
    namespace BlazorPastaShop.API.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class KlantController : ControllerBase
        {
            private readonly PastaService _service;

            public KlantController(PastaService service)
            {
                _service = service;
            }

            [HttpPost]
            public async Task<IActionResult> PostKlant([FromBody] Klant klant)
            {
                if (klant == null)
                    return BadRequest();

                var nieuweKlant = await _service.VoegKlantToeAsync(klant);
                return CreatedAtAction(nameof(PostKlant), new { id = nieuweKlant.KlantId }, nieuweKlant);
            }
        }
    }
}
