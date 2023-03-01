using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class ProtectionTypeController : ControllerBase
    {
        private readonly IProtectionTypeRepository _protectionType;

        public ProtectionTypeController(IProtectionTypeRepository protectionType)
        {
            _protectionType = protectionType ?? throw new ArgumentNullException(nameof(protectionType));
        }

        // Get All Protection Types
        [HttpGet]
        [ActionName("GetProtectionTypes")]
        public async Task<IActionResult> GetProtectionTypes()
        {
            IEnumerable<DTOProtectionType> dtoProtectionTypes = await _protectionType.GetProtectionTypes();

            if (dtoProtectionTypes.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoProtectionTypes);
        }
    }
}
