using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _user;

        public UserController(IUserRepository user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
        }

        // Get All Users
        [HttpGet]
        [ActionName("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            IEnumerable<DTOUser> dtoUsers = await _user.GetUsers();

            if (dtoUsers == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Users Found.");
            }

            return Ok(dtoUsers);
        }

        // Get Single User
        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetUser")]
        public async Task<IActionResult> GetUser([FromRoute] Guid Id)
        {
            DTOUser dtoUser = await _user.GetUser(Id);

            if (dtoUser == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No User Found.");
            }

            return Ok(dtoUser);
        }

        // Create User
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] DTOUser dtoUser)
        {
            var result = await _user.CreateUser(dtoUser);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create User.");
            }

            return CreatedAtAction(nameof(CreateUser), new { dtoUser.Id }, dtoUser);
        }

        // Update User
        [HttpPut]
        [Route("{Id:guid}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid Id, [FromBody] DTOUser dtoUser)
        {
            var result = await _user.UpdateUser(Id, dtoUser);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Update User.");
            }

            return CreatedAtAction(nameof(UpdateUser), new { dtoUser.Id }, dtoUser);
        }

        // Delete User
        [HttpDelete]
        [Route("{Id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid Id)
        {
            var result = await _user.DeleteUser(Id);

            if (result == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Delete User.");
            }

            return CreatedAtAction(nameof(DeleteUser), new { Id });
        }
    }
}
