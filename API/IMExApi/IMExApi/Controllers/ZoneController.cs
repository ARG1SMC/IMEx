using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class ZoneController : ControllerBase
    {
        private readonly IZoneRepository _zone;

        public ZoneController(IZoneRepository zone)
        {
            _zone = zone ?? throw new ArgumentNullException(nameof(zone));
        }

        // Get All Zones
        [HttpGet]
        [ActionName("GetZones")]
        public async Task<IActionResult> GetZones()
        {
            IEnumerable<DTOZone> dtoZones = await _zone.GetZones();

            if (dtoZones.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoZones);
        }
    }
}
