using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepository _platform;

        public PlatformController(IPlatformRepository platform)
        {
            _platform = platform ?? throw new ArgumentNullException(nameof(platform));
        }

        // Get All Platforms
        [HttpGet]
        [ActionName("GetPlatforms")]
        public async Task<IActionResult> GetPlatforms()
        {
            IEnumerable<DTOPlatform> dtoPlatforms = await _platform.GetPlatforms();

            if (dtoPlatforms.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoPlatforms);
        }

        // Create Platform
        [HttpPost]
        public async Task<IActionResult> CreatePlatform([FromBody] DTOPlatform dtoPlatform)
        {
            var result = await _platform.CreatePlatform(dtoPlatform);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Platform.");
            }

            return CreatedAtAction(nameof(CreatePlatform), new { dtoPlatform.Id }, dtoPlatform);
        }
    }
}
