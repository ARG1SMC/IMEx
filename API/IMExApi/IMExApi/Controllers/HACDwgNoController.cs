using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class HACDwgNoController : ControllerBase
    {
        private readonly IHACDwgNoRepository _hacDwgNo;

        public HACDwgNoController(IHACDwgNoRepository hacDwgNo)
        {
            _hacDwgNo = hacDwgNo ?? throw new ArgumentNullException(nameof(hacDwgNo));
        }

        // Get All HAC Dwg Nos
        [HttpGet]
        [ActionName("GeHACDwgNos")]
        public async Task<IActionResult> GetHACDwgNos()
        {
            IEnumerable<DTOHACDwgNo> dtoHACDwgNos = await _hacDwgNo.GetHACDwgNos();

            if (dtoHACDwgNos.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoHACDwgNos);
        }

        // Create HAC Dwg No
        [HttpPost]
        public async Task<IActionResult> CreateHACDwgNo([FromBody] DTOHACDwgNo dtoHACDwgNo)
        {
            var result = await _hacDwgNo.CreateHACDwgNo(dtoHACDwgNo);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create HAC Dwg No.");
            }

            return CreatedAtAction(nameof(CreateHACDwgNo), new { dtoHACDwgNo.Id }, dtoHACDwgNo);
        }
    }
}
