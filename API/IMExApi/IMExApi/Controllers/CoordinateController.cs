using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class CoordinateController : ControllerBase
    {
        private readonly ICoordinateRepository _coordinate;

        public CoordinateController(ICoordinateRepository coordinate)
        {
            _coordinate = coordinate ?? throw new ArgumentNullException(nameof(coordinate));
        }

        // Get All Coordinates
        [HttpGet]
        [ActionName("GetCoordinates")]
        public async Task<IActionResult> GetCoordinates()
        {
            IEnumerable<DTOCoordinate> dtoCoordinates = await _coordinate.GetCoordinates();

            if (dtoCoordinates.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoCoordinates);
        }

        // Get Single Coordinate
        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetCoordinate")]
        public async Task<IActionResult> GetCoordinate([FromRoute] Guid Id)
        {
            DTOCoordinate dtoCoordinate = await _coordinate.GetCoordinate(Id);

            if (dtoCoordinate == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No Coordinate Found.");
            }

            return Ok(dtoCoordinate);
        }
    }
}
