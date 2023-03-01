using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerRepository _manufacturer;

        public ManufacturerController(IManufacturerRepository manufacturer)
        {
            _manufacturer = manufacturer ?? throw new ArgumentNullException(nameof(manufacturer));
        }

        // Get All Manufacturers
        [HttpGet]
        [ActionName("GetManufacturers")]
        public async Task<IActionResult> GetManufacturers()
        {
            IEnumerable<DTOManufacturer> dtoManufacturers = await _manufacturer.GetManufacturers();

            if (dtoManufacturers.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoManufacturers);
        }

        // Create Manufacturer
        [HttpPost]
        public async Task<IActionResult> CreateManufacturer([FromBody] DTOManufacturer dtoManufacturer)
        {
            var result = await _manufacturer.CreateManufacturer(dtoManufacturer);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Manufacturer.");
            }

            return CreatedAtAction(nameof(CreateManufacturer), new { dtoManufacturer.Id }, dtoManufacturer);
        }
    }
}
