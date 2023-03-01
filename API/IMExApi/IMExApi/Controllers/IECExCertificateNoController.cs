using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class IECExCertificateNoController : ControllerBase
    {
        private readonly IIECExCertificateNoRepository _iecExCertificateNo;

        public IECExCertificateNoController(IIECExCertificateNoRepository iecExCertificateNo)
        {
            _iecExCertificateNo = iecExCertificateNo ?? throw new ArgumentNullException(nameof(iecExCertificateNo));
        }

        // Get All IEC Ex Certificate Nos
        [HttpGet]
        [ActionName("GetIECExCertificateNos")]
        public async Task<IActionResult> GetIECExCertificateNos()
        {
            IEnumerable<DTOIECExCertificateNo> dtoIECExCertificateNos = await _iecExCertificateNo.GetIECExCertificateNos();

            if (dtoIECExCertificateNos.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoIECExCertificateNos);
        }

        // Create IEC Ex Certificate No
        [HttpPost]
        public async Task<IActionResult> CreateIECExCertificateNo([FromBody] DTOIECExCertificateNo dtoIECExCertificateNo)
        {
            var result = await _iecExCertificateNo.CreateIECExCertificateNo(dtoIECExCertificateNo);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create IEC Ex Certificate No.");
            }

            return CreatedAtAction(nameof(CreateIECExCertificateNo), new { dtoIECExCertificateNo.Id }, dtoIECExCertificateNo);
        }
    }
}
