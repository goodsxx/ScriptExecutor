using Microsoft.AspNetCore.Mvc;
using ScriptExecutor.Dto;
using System.Diagnostics;

namespace ScriptExecutor.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WebHookController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public WebHookController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [HttpPost("ExecoutScript")]
        public string Post([FromBody] object inDto)
        {
            try
            {
                Process.Start("./start.sh");
                return "执行成功！";
            }
            catch (Exception ex)
            {
                return $"执行失败：{ex.Message}";
            }
        }
    }
}
