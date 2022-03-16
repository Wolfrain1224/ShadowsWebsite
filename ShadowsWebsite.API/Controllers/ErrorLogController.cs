using System.Threading.Tasks;
using ShadowsWebsite.api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ShadowsWebsite.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorLogController : ControllerBase
    {
        private readonly ErrorLogRepository _errorLogRepository;

        public ErrorLogController(ErrorLogRepository errorLogRepository)
        {
            _errorLogRepository = errorLogRepository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetErrorLogs()
        {
            return Ok(await _errorLogRepository.GetAllErrorLogs());
        }
    }
}