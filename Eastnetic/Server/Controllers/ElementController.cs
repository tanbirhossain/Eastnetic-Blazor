using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eastnetic.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElementController : ControllerBase
    {
        private readonly IElementService _elementService;

        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
        }

        [HttpGet]
        [Route("GetElements")]
        public async Task<IActionResult> GetElements()
        {
            var result = await _elementService.GetElements();
            return Ok(result);
        }

        [HttpGet]
        [Route("DeleteElementById")]
        public async Task<IActionResult> DeleteElementById(long id)
        {
            var result = await _elementService.DeleteById(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("SaveElement")]
        public async Task<IActionResult> SaveElement(SubElementDto dto)
        {
            var result = await _elementService.SaveElement(dto);
            return Ok(result);
        }
    }

}
