using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class InspectionController : ControllerBase
    {
        private readonly IInspectionRepository _inspection;

        public InspectionController(IInspectionRepository inspection)
        {
            _inspection = inspection ?? throw new ArgumentNullException(nameof(inspection));
        }

        // Get All Inspections
        [HttpGet]
        [ActionName("GetInspections")]
        public async Task<IActionResult> GetInspections()
        {
            IEnumerable<DTOInspection> dtoInspections = await _inspection.GetInspections();

            if (dtoInspections == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Inspections Found.");
            }

            return Ok(dtoInspections);
        }

        // Get Single Inspection
        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetInspection")]
        public async Task<IActionResult> GetInspection([FromRoute] Guid Id)
        {
            DTOInspection dtoInspection = await _inspection.GetInspection(Id);

            if (dtoInspection == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Inspection Found.");
            }

            return Ok(dtoInspection);
        }

        // Create Inspection
        [HttpPost]
        public async Task<IActionResult> CreateInspection([FromBody] DTOInspection dtoInspection)
        {
            var result = await _inspection.CreateInspection(dtoInspection);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Inspection.");
            }

            return CreatedAtAction(nameof(CreateInspection), new { dtoInspection.Id }, dtoInspection);
        }

        // Update Inspection
        [HttpPut]
        [Route("{Id:guid}")]
        public async Task<IActionResult> UpdateInspection([FromRoute] Guid Id, [FromBody] DTOInspection dtoInspection)
        {
            var result = await _inspection.UpdateInspection(Id, dtoInspection);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Update Inspection.");
            }

            return CreatedAtAction(nameof(UpdateInspection), new { dtoInspection.Id }, dtoInspection);
        }

        // Delete Inspection
        [HttpDelete]
        [Route("{Id:guid}")]
        public async Task<IActionResult> DeleteInspection([FromRoute] Guid Id)
        {
            var result = await _inspection.DeleteInspection(Id);

            if (result == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Delete Inspection.");
            }

            return CreatedAtAction(nameof(DeleteInspection), new { Id });
        }
    }
}
