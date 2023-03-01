using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class SerialNoController : ControllerBase
    {
        private readonly ISerialNoRepository _serialNo;

        public SerialNoController(ISerialNoRepository serialNo)
        {
            _serialNo = serialNo ?? throw new ArgumentNullException(nameof(serialNo));
        }

        // Get All Serial Nos
        [HttpGet]
        [ActionName("GetSerialNos")]
        public async Task<IActionResult> GetSerialNos()
        {
            IEnumerable<DTOSerialNo> dtoSerialNos = await _serialNo.GetSerialNos();

            if (dtoSerialNos.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoSerialNos);
        }

        // Create Serial No
        [HttpPost]
        public async Task<IActionResult> CreateSerialNo([FromBody] DTOSerialNo dtoSerialNo)
        {
            var result = await _serialNo.CreateSerialNo(dtoSerialNo);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Serial No.");
            }

            return CreatedAtAction(nameof(CreateSerialNo), new { dtoSerialNo.Id }, dtoSerialNo);
        }
    }
}
