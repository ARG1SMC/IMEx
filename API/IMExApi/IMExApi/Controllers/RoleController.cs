using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _role;

        public RoleController(IRoleRepository role)
        {
            _role = role ?? throw new ArgumentNullException(nameof(role));
        }

        // Get All Roles
        [HttpGet]
        [ActionName("GetRoles")]
        public async Task<IActionResult> GetRoles()
        {
            IEnumerable<DTORole> dtoRoles = await _role.GetRoles();

            if (dtoRoles.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoRoles);
        }

        // Get Single Role
        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetRole")]
        public async Task<IActionResult> GetRole([FromRoute] Guid Id)
        {
            DTORole dtoRole = await _role.GetRole(Id);

            if (dtoRole == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Role Found.");
            }

            return Ok(dtoRole);
        }
    }
}
