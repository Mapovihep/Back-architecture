using DomainDTO;
using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    [ApiController]
    public class DefectController : ControllerBase
    {
        private readonly ICRUDDefaultService<DefectDTO> _defectService;

        
        public DefectController(ICRUDDefaultService<DefectDTO> defectService)
        {
            _defectService = defectService;
        }

        [HttpPost]
        [Route("add/defects")]
        public async Task<IActionResult> AddDefect([FromBody]DefectDTO defectDTO)
        {
            try
            {
                return Ok(_defectService.Add(defectDTO));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}