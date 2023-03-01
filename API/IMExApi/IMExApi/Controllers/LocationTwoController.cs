using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class LocationTwoController : ControllerBase
    {
        private readonly ILocationTwoRepository _locationTwo;

        public LocationTwoController(ILocationTwoRepository locationTwo)
        {
            _locationTwo = locationTwo ?? throw new ArgumentNullException(nameof(locationTwo));
        }

        // Get All Location Twos
        [HttpGet]
        [ActionName("GetLocationTwos")]
        public async Task<IActionResult> GetLocationTwos()
        {
            IEnumerable<DTOLocationTwo> dtoLocationTwos = await _locationTwo.GetLocationTwos();

            if (dtoLocationTwos.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoLocationTwos);
        }

        // Create Location Two
        [HttpPost]
        public async Task<IActionResult> CreateLocationTwo([FromBody] DTOLocationTwo dtoLocationTwo)
        {
            var result = await _locationTwo.CreateLocationTwo(dtoLocationTwo);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Location Two.");
            }

            return CreatedAtAction(nameof(CreateLocationTwo), new { dtoLocationTwo.Id }, dtoLocationTwo);
        }
    }
}
