using HTTPRequest.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTTPRequest.Controllers
{
    [Route("protocols")]
    public class ProtocolExampleController : Controller
    {
        [HttpGet("register")]
        public IActionResult RegisterProtocol([FromQuery] string cpf)
        {
            // TODO: call an external service to generate a real protocol
            var formattedCpf = cpf.Replace(".", "").Replace("-", "");
            var protocol = $"{DateTime.UtcNow.ToString("yyyyMMddss")}{formattedCpf}";

            return Json(new FlowActionSendText($"O protocolo deste atendimento é {protocol}"));
        }
    }
}
