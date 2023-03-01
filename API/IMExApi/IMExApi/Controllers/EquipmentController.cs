using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentRepository _equipment;

        public EquipmentController(IEquipmentRepository equipment)
        {
            _equipment = equipment ?? throw new ArgumentNullException(nameof(equipment));
        }

        // Get All Equipments
        [HttpGet]
        [ActionName("GetEquipments")]
        public async Task<IActionResult> GetEquipments() 
        {
            IEnumerable<DTOEquipment> dtoEquipments = await _equipment.GetEquipments();

            if (dtoEquipments == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Equipments Found.");
            }

            return Ok(dtoEquipments);
        }

        // Get Single Equipment
        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetEquipment")]
        public async Task<IActionResult> GetEquipment([FromRoute] Guid Id)
        {
            DTOEquipment dtoEquipment = await _equipment.GetEquipment(Id);

            if (dtoEquipment == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Equipment Found.");
            }

            return Ok(dtoEquipment);
        }

        // Create Equipment
        [HttpPost]
        public async Task<IActionResult> CreateEquipment([FromBody] DTOEquipment dtoEquipment)
        {
            var result = await _equipment.CreateEquipment(dtoEquipment);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Equipment.");
            }

            return CreatedAtAction(nameof(CreateEquipment), new { dtoEquipment.Id }, dtoEquipment);
        }

        // Update Equipment
        [HttpPut]
        [Route("{Id:guid}")]
        public async Task<IActionResult> UpdateEquipment([FromRoute] Guid Id, [FromBody] DTOEquipment dtoEquipment)
        {
            var result = await _equipment.UpdateEquipment(Id, dtoEquipment);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Update Equipment.");
            }

            return CreatedAtAction(nameof(UpdateEquipment), new { dtoEquipment.Id }, dtoEquipment);
        }

        // Delete Equipment
        [HttpDelete]
        [Route("{Id:guid}")]
        public async Task<IActionResult> DeleteEquipment([FromRoute] Guid Id)
        {
            var result = await _equipment.DeleteEquipment(Id);

            if (result == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Delete Equipment.");
            }

            return CreatedAtAction(nameof(DeleteEquipment), new { Id });
        }
    }
}
