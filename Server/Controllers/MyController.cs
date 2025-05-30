using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("Target")]
    public class TargetController : ControllerBase
    {
        private readonly IMyServiceInterface _service;

        public TargetController(IMyServiceInterface service)
        {
            _service = service;
        }

        [HttpGet("GetData")]
        public async Task<string> AMethod()
        {
            return await _service.GetDataAsync();
        }

        [HttpPost("GetData")]
        public async Task<string> AMethodPost()
        {
            return await _service.GetDataAsync();
        }

        [HttpGet("GetData2")]
        public async Task<string> AMethod2()
        {
            return await _service.GetDataAsync();
        }
    }
}
