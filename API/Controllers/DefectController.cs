using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;
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
        [Route("{controller}/add")]
        public async Task<IActionResult> AddDefect([FromBody]DefectDTO defectDTO)
        {
            try
            {
                return Ok(await _defectService.Add(defectDTO));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{controller}/update")]
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
        [Route("{controller}/get")]
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
        [Route("{controller}/{id}")]
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