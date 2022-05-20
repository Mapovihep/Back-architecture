using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.DTO;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [ApiController]
    //[Authorize(Policy = "Bearer")]
    public class DefectsController : ControllerBase
    {
        private readonly IDefectService _defectService;

        /*public DefectController(IServiceProvider _serviceProvider)
        {
            _defectService = _serviceProvider.GetService<IDefectService>();
        }*/
        /*public DefectController([FromServices] IDefectService defectService)
        {
            _defectService = defectService;
        }*/
        public DefectsController(IDefectService defectService)
        {
            _defectService = defectService;
        }

        [HttpPost]
        //[Route("{controller}/add")]
        [Route("Defects/add")]
        public async Task<IActionResult> AddDefect([FromBody] DefectDTO defectDTO)
        {
            try
            {
                return Ok(await _defectService.Add(defectDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        //[Route("{controller}/updateDefect")]
        [Route("Defects/update")]
        public async Task<IActionResult> UpdateDefect([FromBody] DefectDTO defectDTO)
        {
            try
            {
                return Ok(await _defectService.Update(defectDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        //[Route("{controller}/getDefect")]
        [Route("Defects/get")]
        public async Task<IActionResult> GetDefects()
        {
            try
            {
                return Ok(await _defectService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        //[Route("{controller}/{id}/Defect")]
        [Route("Defects/delete")]
        public async Task<IActionResult> DeleteDefects(Guid id)
        {
            try
            {
                return Ok(await _defectService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}