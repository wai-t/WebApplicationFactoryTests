using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TargetController : ControllerBase
    {
        private readonly IMyServiceInterface _service;

        public TargetController(IMyServiceInterface service)
        {
            _service = service;
        }

        [HttpGet("GetData")]
        public async Task<string> GetData()
        {
            return await _service.GetDataAsync();
        }

    }
}
