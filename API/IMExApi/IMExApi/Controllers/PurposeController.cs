using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class PurposeController : ControllerBase
    {
        private readonly IPurposeRepository _purpose;

        public PurposeController(IPurposeRepository purpose)
        {
            _purpose = purpose ?? throw new ArgumentNullException(nameof(purpose));
        }

        // Get All Purposes
        [HttpGet]
        [ActionName("GetPurposes")]
        public async Task<IActionResult> GetPurposes()
        {
            IEnumerable<DTOPurpose> dtoPurposes = await _purpose.GetPurposes();

            if (dtoPurposes.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoPurposes);
        }

        // Create Purpose
        [HttpPost]
        public async Task<IActionResult> CreatePurpose([FromBody] DTOPurpose dtoPurpose)
        {
            var result = await _purpose.CreatePurpose(dtoPurpose);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Purpose.");
            }

            return CreatedAtAction(nameof(CreatePurpose), new { dtoPurpose.Id }, dtoPurpose);
        }
    }
}
