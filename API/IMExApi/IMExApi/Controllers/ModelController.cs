using Microsoft.AspNetCore.Mvc;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class ModelController : ControllerBase
    {
        private readonly IModelRepository _model;

        public ModelController(IModelRepository model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
        }

        // Get All Models
        [HttpGet]
        [ActionName("GetModels")]
        public async Task<IActionResult> GetModels()
        {
            IEnumerable<DTOModel> dtoModels = await _model.GetModels();

            if (dtoModels.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoModels);
        }

        // Create Model
        [HttpPost]
        public async Task<IActionResult> CreateModel([FromBody] DTOModel dtoModel)
        {
            var result = await _model.CreateModel(dtoModel);

            if (result.Id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Cannot Create Model.");
            }

            return CreatedAtAction(nameof(CreateModel), new { dtoModel.Id }, dtoModel);
        }
    }
}
