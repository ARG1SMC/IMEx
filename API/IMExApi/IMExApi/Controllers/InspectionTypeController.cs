using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class InspectionTypeController : ControllerBase
    {
        private readonly IInspectionTypeRepository _inspectionType;

        public InspectionTypeController(IInspectionTypeRepository inspectionType)
        {
            _inspectionType = inspectionType ?? throw new ArgumentNullException(nameof(inspectionType));
        }

        // Get All Inspection Types
        [HttpGet]
        [ActionName("GetInspectionTypes")]
        public async Task<IActionResult> GetInspectionTypes()
        {
            IEnumerable<DTOInspectionType> dtoInspectionTypes = await _inspectionType.GetInspectionTypes();

            if (dtoInspectionTypes.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoInspectionTypes);
        }
    }
}
