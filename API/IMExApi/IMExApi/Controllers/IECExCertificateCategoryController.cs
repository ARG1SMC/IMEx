using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class IECExCertificateCategoryController : ControllerBase
    {
        private readonly IIECExCertificateCategoryRepository _iecExCertificateCategory;

        public IECExCertificateCategoryController(IIECExCertificateCategoryRepository iecExCertificateCategory)
        {
            _iecExCertificateCategory = iecExCertificateCategory ?? throw new ArgumentNullException(nameof(iecExCertificateCategory));
        }

        // Get All IEC Ex Certificate Categories
        [HttpGet]
        [ActionName("GetIECExCertificateCategories")]
        public async Task<IActionResult> GetIECExCertificateCategories()
        {
            IEnumerable<DTOIECExCertificateCategory> dtoIECExCertificateCategories = await _iecExCertificateCategory.GetIECExCertificateCategories();

            if (dtoIECExCertificateCategories.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoIECExCertificateCategories);
        }

        // Create IECExCertificateCategory
        [HttpPost]
        public async Task<IActionResult> CreateIECExCertificateCategory([FromBody] DTOIECExCertificateCategory dtoIECExCertificateCategory)
        {
            var result = await _iecExCertificateCategory.CreateIECExCertificateCategory(dtoIECExCertificateCategory);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create IECExCertificateCategory.");
            }

            return CreatedAtAction(nameof(CreateIECExCertificateCategory), new { dtoIECExCertificateCategory.Id }, dtoIECExCertificateCategory);
        }
    }
}
