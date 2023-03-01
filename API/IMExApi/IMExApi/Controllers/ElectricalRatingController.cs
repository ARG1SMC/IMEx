using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class ElectricalRatingController : ControllerBase
    {
        private readonly IElectricalRatingRepository _electricalRating;

        public ElectricalRatingController(IElectricalRatingRepository electricalRating)
        {
            _electricalRating = electricalRating ?? throw new ArgumentNullException(nameof(electricalRating));
        }

        // Get All ElectricalRatings
        [HttpGet]
        [ActionName("GetElectricalRatings")]
        public async Task<IActionResult> GetElectricalRatings()
        {
            IEnumerable<DTOElectricalRating> dtoElectricalRatings = await _electricalRating.GetElectricalRatings();

            if (dtoElectricalRatings.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoElectricalRatings);
        }

        // Create Electrical Rating
        [HttpPost]
        public async Task<IActionResult> CreateElectricalRating([FromBody] DTOElectricalRating dtoElectricalRating)
        {
            var result = await _electricalRating.CreateElectricalRating(dtoElectricalRating);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Electrical Rating.");
            }

            return CreatedAtAction(nameof(CreateElectricalRating), new { dtoElectricalRating.Id }, dtoElectricalRating);
        }
    }
}
