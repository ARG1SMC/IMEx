using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class OPUController : ControllerBase
    {
        private readonly IOPURepository _opu;

        public OPUController(IOPURepository opu)
        {
            _opu = opu ?? throw new ArgumentNullException(nameof(opu));
        }

        // Get All OPUs
        [HttpGet]
        [ActionName("GetOPUs")]
        public async Task<IActionResult> GetOPUs()
        {
            IEnumerable<DTOOPU> dtoOPUs = await _opu.GetOPUs();

            if (dtoOPUs.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoOPUs);
        }

        // Get Single OPU
        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetOPU")]
        public async Task<IActionResult> GetOPU([FromRoute] Guid Id)
        {
            DTOOPU dtoOPU = await _opu.GetOPU(Id);

            if (dtoOPU == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No OPU Found.");
            }

            return Ok(dtoOPU);
        }
    }
}
