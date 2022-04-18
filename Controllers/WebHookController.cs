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
        
        [HttpGet("ExecoutScript")]
        public string ExecoutScript([FromBody] object inDto)
        {
            try
            {
                var addr = _configuration.GetSection("VuePress").Value;
                Process.Start(addr);
                return "执行成功！";
            }
            catch (Exception ex)
            {
                return $"执行失败：{ex.Message}";
            }
        }
    }
}
