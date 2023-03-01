using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class IECExCertificateAuthorityController : ControllerBase
    {
        private readonly IIECExCertificateAuthorityRepository _iecExCertificateAuthority;

        public IECExCertificateAuthorityController(IIECExCertificateAuthorityRepository iecExCertificateAuthority)
        {
            _iecExCertificateAuthority = iecExCertificateAuthority ?? throw new ArgumentNullException(nameof(iecExCertificateAuthority));
        }

        // Get All IEC Ex Certificate Authorities
        [HttpGet]
        [ActionName("GetIECExCertificateAuthorities")]
        public async Task<IActionResult> GetIECExCertificateAuthorities()
        {
            IEnumerable<DTOIECExCertificateAuthority> dtoIECExCertificateAuthorities = await _iecExCertificateAuthority.GetIECExCertificateAuthorities();

            if (dtoIECExCertificateAuthorities.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoIECExCertificateAuthorities);
        }
    }
}
