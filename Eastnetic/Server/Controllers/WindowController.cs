using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eastnetic.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WindowController : ControllerBase
    {
        private readonly IWindowService _windowService;

        public WindowController(IWindowService windowService)
        {
            _windowService = windowService;
        }

        [HttpGet]
        [Route("GetWindows")]
        public async Task<IActionResult> GetWindows()
        {
            var result = await _windowService.GetWindows();
            return Ok(result);
        }
        [HttpGet]
        [Route("DeleteWindowById")]
        public async Task<IActionResult> DeleteWindowById(long id)
        {
            var result = await _windowService.DeleteById(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("SaveWindow")]
        public async Task<IActionResult> SaveWindow(WindowDto dto)
        {
            var result = await _windowService.SaveWindow(dto);
            return Ok(result);
        }
    }

}
