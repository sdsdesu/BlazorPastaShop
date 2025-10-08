using BlazorPastaShop.API.Service;
using BlazorPastaShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPastaShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BestellingController : ControllerBase
    {
        private readonly PastaService _service;

        public BestellingController(PastaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> PostBestelling([FromBody] Bestelling bestelling)
        {
            if (bestelling == null)
                return BadRequest();

            var nieuweBestelling = await _service.VoegBestellingToeAsync(bestelling);
            return CreatedAtAction(nameof(PostBestelling), new { id = nieuweBestelling.Id }, nieuweBestelling);
        }
    }
}