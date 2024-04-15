using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HTTPRequest.Controllers
{
    [Route("ticket")]
    public class TicketRegisterExampleController : Controller
    {
        [HttpPost("register")]
        public async Task<IActionResult> RegisterTicket([FromBody] JsonDocument data)
        {
            var phone = data.RootElement.GetProperty("phone").ToString();
            var description = data.RootElement.GetProperty("description").ToString();

            // TODO: create a ticket in an external CRM and get the ticket id and SLA (time to finish the task, in resume)
            var ticketId = Guid.NewGuid().ToString();
            var ticketSLA = "3d";

            return Ok(new
            {
                data = new
                {
                    ticket = new
                    {
                        id = ticketId,
                        sla = ticketSLA
                    }
                }
            });
        }
    }
}
