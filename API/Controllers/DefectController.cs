using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [ApiController]
    public class DefectController : ControllerBase
    {
        private readonly IDefectService _defectService;
        
        public DefectController(IServiceProvider _serviceProvider)
        {
            _defectService = _serviceProvider.GetService<IDefectService>();
        }

        [HttpPost]
        [Route("add/defects")]
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

        [HttpPost]
        [Route("update/defect")]
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
        [Route("get/defects")]
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
        [Route("delete/defects/{id}")]
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

        [HttpGet]
        [Route("{controller}/page={pageNumber}/{filters}")]
        public async Task<IActionResult> GetDefectsWithParams(string pageNumber, string filters)
        {
            try
            {
                return Ok(" ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}