using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class LocationOneController : ControllerBase
    {
        private readonly ILocationOneRepository _locationOne;

        public LocationOneController(ILocationOneRepository locationOne)
        {
            _locationOne = locationOne ?? throw new ArgumentNullException(nameof(locationOne));
        }

        // Get All Location Ones
        [HttpGet]
        [ActionName("GetLocationOnes")]
        public async Task<IActionResult> GetLocationOnes()
        {
            IEnumerable<DTOLocationOne> dtoLocationOnes = await _locationOne.GetLocationOnes();

            if (dtoLocationOnes.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoLocationOnes);
        }

        // Create Location One
        [HttpPost]
        public async Task<IActionResult> CreateLocationOne([FromBody] DTOLocationOne dtoLocationOne)
        {
            var result = await _locationOne.CreateLocationOne(dtoLocationOne);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Location One.");
            }

            return CreatedAtAction(nameof(CreateLocationOne), new { dtoLocationOne.Id }, dtoLocationOne);
        }
    }
}
