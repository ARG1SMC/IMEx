using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class IECExCertificateDetailController : ControllerBase
    {
        private readonly IIECExCertificateDetailRepository _iecExCertificateDetail;

        public IECExCertificateDetailController(IIECExCertificateDetailRepository iecExCertificateDetail)
        {
            _iecExCertificateDetail = iecExCertificateDetail ?? throw new ArgumentNullException(nameof(iecExCertificateDetail));
        }

        // Get All IEC Ex Certificate Details
        [HttpGet]
        [ActionName("GetIECExCertificateDetails")]
        public async Task<IActionResult> GetIECExCertificateDetails()
        {
            IEnumerable<DTOIECExCertificateDetail> dtoIECExCertificateDetails = await _iecExCertificateDetail.GetIECExCertificateDetails();

            if (dtoIECExCertificateDetails.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoIECExCertificateDetails);
        }

        // Create IEC Ex Certificate Detail
        [HttpPost]
        public async Task<IActionResult> CreateIECExCertificateDetail([FromBody] DTOIECExCertificateDetail dtoIECExCertificateDetail)
        {
            var result = await _iecExCertificateDetail.CreateIECExCertificateDetail(dtoIECExCertificateDetail);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create IEC Ex Certificate Detail.");
            }

            return CreatedAtAction(nameof(CreateIECExCertificateDetail), new { dtoIECExCertificateDetail.Id }, dtoIECExCertificateDetail);
        }
    }
}
