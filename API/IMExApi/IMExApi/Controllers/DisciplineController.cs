using Microsoft.AspNetCore.Mvc;
using IMExApi.Repository.Interfaces;
using IMExApi.DTO;

namespace IMExApi.Controllers
{
    [ApiController]
    [Route("/")]
    //[Route("api/[controller]")]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineRepository _discipline;

        public DisciplineController(IDisciplineRepository discipline)
        {
            _discipline = discipline ?? throw new ArgumentNullException(nameof(discipline));
        }

        // Get All Disciplines
        [HttpGet]
        [ActionName("GetDisciplines")]
        public async Task<IActionResult> GetDisciplines()
        {
            IEnumerable<DTODiscipline> dtoDisciplines = await _discipline.GetDisciplines();

            if (dtoDisciplines.Count() == 0)
            {
                return NotFound("Not Found.");
            }

            return Ok(dtoDisciplines);
        }
    }
}
